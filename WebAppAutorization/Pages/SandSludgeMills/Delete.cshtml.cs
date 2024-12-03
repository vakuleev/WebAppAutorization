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

namespace WebAppAutorization.Pages.SandSludgeMills
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        //[BindProperty]
      public SandSludgeMill SandSludgeMill { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.SandSludgeMills == null)
            {
                return NotFound();
            }

            var sandsludgemill = await _context.SandSludgeMills.FirstOrDefaultAsync(m => m.Id == id);

            if (sandsludgemill == null)
            {
                return NotFound();
            }
            else 
            {
                SandSludgeMill = sandsludgemill;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.SandSludgeMills == null)
            {
                return NotFound();
            }
            var sandsludgemill = await _context.SandSludgeMills.FindAsync(id);

            if (sandsludgemill != null)
            {
                SandSludgeMill = sandsludgemill;
                _context.SandSludgeMills.Remove(SandSludgeMill);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
