using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.S_Factory_infos
{
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public DeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public S_Factory_info S_Factory_info { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.S_Factory_infos == null)
            {
                return NotFound();
            }

            var s_factory_info = await _context.S_Factory_infos.FirstOrDefaultAsync(m => m.load_dttm == id);

            if (s_factory_info == null)
            {
                return NotFound();
            }
            else 
            {
                S_Factory_info = s_factory_info;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.S_Factory_infos == null)
            {
                return NotFound();
            }
            var s_factory_info = await _context.S_Factory_infos.FindAsync(id);

            if (s_factory_info != null)
            {
                S_Factory_info = s_factory_info;
                _context.S_Factory_infos.Remove(S_Factory_info);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
