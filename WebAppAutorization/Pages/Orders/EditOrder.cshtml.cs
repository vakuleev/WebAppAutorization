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
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Orders
{
    [Authorize]
    [Authorize(Policy = "Ордера")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order =  await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            Order = order;
 
            //------------------------ Список связанных полей --------------------//
           ViewData["SheetfId"] = new SelectList(_context.Sheetfs, "Id", "Id");

           ViewData["ProductName"] = new SelectList(_context.Products, "Name", "Name");
            //------------------------ Список связанных полей --------------------//


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

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexOrder");
        }

        private bool OrderExists(long id)
        {
          return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
