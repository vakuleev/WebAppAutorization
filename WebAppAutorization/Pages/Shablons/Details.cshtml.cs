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

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      public Sheetf Sheetf { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Sheetfs == null)
            {
                return NotFound();
            }

            var sheetf = await _context.Sheetfs.FirstOrDefaultAsync(m => m.Id == id);
            if (sheetf == null)
            {
                return NotFound();
            }
            else 
            {
                Sheetf = sheetf;
            }
            return Page();
        }
    }
}
