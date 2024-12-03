using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.S_Factory_infos
{
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
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

            var s_factory_info =  await _context.S_Factory_infos.FirstOrDefaultAsync(m => m.load_dttm == id);
            if (s_factory_info == null)
            {
                return NotFound();
            }
            S_Factory_info = s_factory_info;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(S_Factory_info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!S_Factory_infoExists(S_Factory_info.load_dttm))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool S_Factory_infoExists(string id)
        {
          return (_context.S_Factory_infos?.Any(e => e.load_dttm == id)).GetValueOrDefault();
        }
    }
}
