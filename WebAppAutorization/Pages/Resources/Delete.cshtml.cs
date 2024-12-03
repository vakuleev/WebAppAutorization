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

namespace WebAppAutorization.Pages.Resources
{
    [Authorize(Policy = "Ресурсы")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Resource Resource { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }

            var resource = await _context.Resource.FirstOrDefaultAsync(m => m.Id == id);

            if (resource == null)
            {
                return NotFound();
            }
            else 
            {
                Resource = resource;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }
            var resource = await _context.Resource.FindAsync(id);

            if (resource != null)
            {
                Resource = resource;
                _context.Resource.Remove(Resource);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
