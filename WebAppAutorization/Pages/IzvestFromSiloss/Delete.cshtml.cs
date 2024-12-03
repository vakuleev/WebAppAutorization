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

namespace WebAppAutorization.Pages.IzvestFromSiloss
{
    [Authorize]
    [Authorize(Policy = "Известь из силоса")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      //  [BindProperty]
      public IzvestFromSilos IzvestFromSilos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.IzvestFromSilos == null)
            {
                return NotFound();
            }

            var izvestfromsilos = await _context.IzvestFromSilos.FirstOrDefaultAsync(m => m.Id == id);

            if (izvestfromsilos == null)
            {
                return NotFound();
            }
            else 
            {
                IzvestFromSilos = izvestfromsilos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.IzvestFromSilos == null)
            {
                return NotFound();
            }
            var izvestfromsilos = await _context.IzvestFromSilos.FindAsync(id);

            if (izvestfromsilos != null)
            {
                IzvestFromSilos = izvestfromsilos;
                _context.IzvestFromSilos.Remove(IzvestFromSilos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
