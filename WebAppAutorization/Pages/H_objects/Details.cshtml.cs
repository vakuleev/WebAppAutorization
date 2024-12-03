using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_objects
{
    [Authorize]
    [Authorize(Policy = "ХАБ Объекты")]
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DetailsModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

      public H_object H_object { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.H_object == null)
            {
                return NotFound();
            }

            var h_object = await _context.H_object.FirstOrDefaultAsync(m => m.id_object == id);
            if (h_object == null)
            {
                return NotFound();
            }
            else 
            {
                H_object = h_object;
            }
            return Page();
        }
    }
}
