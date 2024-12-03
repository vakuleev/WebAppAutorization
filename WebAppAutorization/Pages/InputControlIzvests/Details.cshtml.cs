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
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

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
    }
}
