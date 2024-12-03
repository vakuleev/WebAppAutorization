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

namespace WebAppAutorization.Pages.ResultsLimeMills
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
      public ResultsLimeMill ResultsLimeMill { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.ResultsLimeMills == null)
            {
                return NotFound();
            }

            var resultslimemill = await _context.ResultsLimeMills.FirstOrDefaultAsync(m => m.Id == id);

            if (resultslimemill == null)
            {
                return NotFound();
            }
            else 
            {
                ResultsLimeMill = resultslimemill;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.ResultsLimeMills == null)
            {
                return NotFound();
            }
            var resultslimemill = await _context.ResultsLimeMills.FindAsync(id);

            if (resultslimemill != null)
            {
                ResultsLimeMill = resultslimemill;
                _context.ResultsLimeMills.Remove(ResultsLimeMill);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
