using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_eemps
{
    [Authorize]
    [Authorize(Policy = "ХАБ Метрологии")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int id_factory_return { get; set; } = default;
        [BindProperty]
        public int id_division_return { get; set; } = default;
        [BindProperty]
        public int id_object_return { get; set; } = default;
        [BindProperty]
        public H_eemp H_eemp { get; set; } = default!;
        //                                         int id_division, int id_factory
        public async Task<IActionResult> OnGetAsync(int? id, int id_object, int id_division, int id_factory)
        {
            if (id_object != 0)
            {
                id_object_return   = id_object;
                id_division_return = id_division;
                id_factory_return  = id_factory;
            }
            if (id == null || _context.H_eemp == null)
            {
                return NotFound();
            }

            var h_eemp =  await _context.H_eemp.FirstOrDefaultAsync(m => m.id_eemp == id);
            if (h_eemp == null)
            {
                return NotFound();
            }
            H_eemp = h_eemp;
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

            _context.Attach(H_eemp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!H_eempExists(H_eemp.id_eemp))
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

        private bool H_eempExists(int id)
        {
          return (_context.H_eemp?.Any(e => e.id_eemp == id)).GetValueOrDefault();
        }
    }
}
