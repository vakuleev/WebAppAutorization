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

namespace WebAppAutorization.Pages.InputControlIzvests
{
    [Authorize]
    [Authorize(Policy = "Входной контроль извести")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      //  [BindProperty]
      public InputControlIzvest InputControlIzvest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.InputControlIzvests == null)
            {
                return NotFound();
            }

            var inputcontrolizvest = await _context.InputControlIzvests.FirstOrDefaultAsync(m => m.Id == id);

            if (inputcontrolizvest == null)
            {
                return NotFound();
            }
            else 
            {
                InputControlIzvest = inputcontrolizvest;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.InputControlIzvests == null)
            {
                return NotFound();
            }
            var inputcontrolizvest = await _context.InputControlIzvests.FindAsync(id);

            if (inputcontrolizvest != null)
            {
                InputControlIzvest = inputcontrolizvest;
                _context.InputControlIzvests.Remove(InputControlIzvest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
