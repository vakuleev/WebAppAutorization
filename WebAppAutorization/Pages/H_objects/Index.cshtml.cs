using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_objects
{
    [Authorize]
    [Authorize(Policy = "ХАБ Объекты")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<H_object> H_object { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.H_object != null)
            {
                H_object = await _context.H_object.ToListAsync();
            }
        }
    }
}
