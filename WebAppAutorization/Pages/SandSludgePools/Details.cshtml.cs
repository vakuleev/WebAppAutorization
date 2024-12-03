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

namespace WebAppAutorization.Pages.SandSludgePools
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      public SandSludgePool SandSludgePool { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.SandSludgePools == null)
            {
                return NotFound();
            }

            var sandsludgepool = await _context.SandSludgePools.FirstOrDefaultAsync(m => m.Id == id);
            if (sandsludgepool == null)
            {
                return NotFound();
            }
            else 
            {
                SandSludgePool = sandsludgepool;
            }
            return Page();
        }
    }
}
