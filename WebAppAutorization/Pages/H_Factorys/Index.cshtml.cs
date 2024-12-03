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

namespace WebAppAutorization.Pages.H_Factorys
{
    [Authorize]
    [Authorize(Policy = "ХАБ Фабрики")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<H_Factory> H_Factory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.H_Factory != null)
            {
                H_Factory = await _context.H_Factory
                    .OrderBy(f => f.name_factory)
                    .ToListAsync();
            }
        }
    }
}
