using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.OperationControlMaterials
{
    [Authorize(Policy = "Операционный контроль сырья")]
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
        public IzvestFromSilos IzvestFromSilos { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.IzvestFromSilos == null || IzvestFromSilos == null)
            {
                return Page();
            }

            _context.IzvestFromSilos.Add(IzvestFromSilos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
