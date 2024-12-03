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

namespace WebAppAutorization.Pages.S_Factory_infos
{
    [Authorize(Policy = "Доп инфо компании")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public IndexModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IList<S_Factory_info> S_Factory_info { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.S_Factory_infos != null)
            {
                S_Factory_info = await _context.S_Factory_infos.ToListAsync();
            }
        }
    }
}
