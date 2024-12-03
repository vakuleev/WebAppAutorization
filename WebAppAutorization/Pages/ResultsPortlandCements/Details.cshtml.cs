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
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

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
    }
}
