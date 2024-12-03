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

namespace WebAppAutorization.Pages.Orders
{
    [Authorize]
    [Authorize(Policy = "Ордера")]
    public class CreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public CreateModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        //ViewData["sheetfId"] = new SelectList(_context.Sheetfs, "Id", "Id");
            //------------------------ Список связанных полей --------------------//
            ViewData["sheetfId"] = new SelectList(_context.Sheetfs, "Id", "Id");

            ViewData["ProductName"] = new SelectList(_context.Products, "Name", "Name");
            //------------------------ Список связанных полей --------------------//

            return Page();
        }

        [BindProperty]
        public Order Order { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Orders == null || Order == null)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./IndexOrder");
        }
    }
}
