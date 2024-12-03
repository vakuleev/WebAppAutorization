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
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      //  [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.SandSludgePools == null)
            {
                return NotFound();
            }
            var sandsludgepool = await _context.SandSludgePools.FindAsync(id);

            if (sandsludgepool != null)
            {
                SandSludgePool = sandsludgepool;
                _context.SandSludgePools.Remove(SandSludgePool);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
