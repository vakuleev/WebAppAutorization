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

namespace WebAppAutorization.Pages.H_eemps
{
    [Authorize]
    [Authorize(Policy = "ХАБ Метрологии")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<H_eemp> H_eemp { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.H_eemp != null)
            {
                H_eemp = await _context.H_eemp.ToListAsync();
            }
        }
    }
}
