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

namespace WebAppAutorization.Pages.SBDataLabs
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      public SBDataLab SBDataLab { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.SBDataLabs == null)
            {
                return NotFound();
            }

            var sbdatalab = await _context.SBDataLabs.FirstOrDefaultAsync(m => m.Id == id);
            if (sbdatalab == null)
            {
                return NotFound();
            }
            else 
            {
                SBDataLab = sbdatalab;
            }
            return Page();
        }
    }
}
