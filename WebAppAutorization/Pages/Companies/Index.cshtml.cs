using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Companies
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Companies != null)
            {
                Company = await _context.Companies.OrderBy(c => c.Name).ToListAsync();
            }
        }
    }
}
