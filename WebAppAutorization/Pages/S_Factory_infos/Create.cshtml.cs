using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.S_Factory_infos
{
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
        public S_Factory_info S_Factory_info { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.S_Factory_infos == null || S_Factory_info == null)
            {
                return Page();
            }

            _context.S_Factory_infos.Add(S_Factory_info);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
