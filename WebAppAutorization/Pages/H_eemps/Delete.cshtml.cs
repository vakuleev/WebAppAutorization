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

namespace WebAppAutorization.Pages.H_eemps
{
    [Authorize]
    [Authorize(Policy = "ХАБ Метрологии")]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public H_eemp H_eemp { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.H_eemp == null)
            {
                return NotFound();
            }

            var h_eemp = await _context.H_eemp.FirstOrDefaultAsync(m => m.id_eemp == id);

            if (h_eemp == null)
            {
                return NotFound();
            }
            else 
            {
                H_eemp = h_eemp;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.H_eemp == null)
            {
                return NotFound();
            }
            var h_eemp = await _context.H_eemp.FindAsync(id);

            if (h_eemp != null)
            {
                H_eemp = h_eemp;
                _context.H_eemp.Remove(H_eemp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
