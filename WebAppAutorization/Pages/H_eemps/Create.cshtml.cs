using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_eemps
{
    [Authorize]
    [Authorize(Policy = "ХАБ Метрологии")]
    public class CreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public CreateModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public H_eemp H_eemp { get; set; } = new H_eemp();
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.H_eemp == null || H_eemp == null)
            {
                return Page();
            }

            _context.H_eemp.Add(H_eemp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
