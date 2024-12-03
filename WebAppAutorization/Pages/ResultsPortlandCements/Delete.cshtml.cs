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

namespace WebAppAutorization.Pages.ResultsPortlandCements
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

       // [BindProperty]
      public ResultsPortlandCement ResultsPortlandCement { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.ResultsPortlandCements == null)
            {
                return NotFound();
            }

            var resultsportlandcement = await _context.ResultsPortlandCements.FirstOrDefaultAsync(m => m.Id == id);

            if (resultsportlandcement == null)
            {
                return NotFound();
            }
            else 
            {
                ResultsPortlandCement = resultsportlandcement;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.ResultsPortlandCements == null)
            {
                return NotFound();
            }
            var resultsportlandcement = await _context.ResultsPortlandCements.FindAsync(id);

            if (resultsportlandcement != null)
            {
                ResultsPortlandCement = resultsportlandcement;
                _context.ResultsPortlandCements.Remove(ResultsPortlandCement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
