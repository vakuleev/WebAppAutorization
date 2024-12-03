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
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.H_object == null)
            {
                return NotFound();
            }
            var h_object = await _context.H_object.FindAsync(id);

            if (h_object != null)
            {
                H_object = h_object;
                _context.H_object.Remove(H_object);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
