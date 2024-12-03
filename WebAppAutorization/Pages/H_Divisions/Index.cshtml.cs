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

namespace WebAppAutorization.Pages.H_Divisions
{
    [Authorize]
    [Authorize(Policy = "ХАБ Дивизионы")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<H_Division> H_Division { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.H_Division != null)
            {
                H_Division = await _context.H_Division.OrderBy(h => h.prefix)
                                                       .ThenBy(h => h.name_division).ToListAsync();
            }
        }
    }
}
