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

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize]
    public class OrderDeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public OrderDeleteModel(WebAppAutorization.Data.gnsDbContext context)
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

            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);

            if (order != null)
            {
                Order = order;
                _context.Orders.Remove(Order);
                await _context.SaveChangesAsync();
            }

            //return RedirectToPage("./Index");
            Response.Redirect("../Shablons/Edit?id=" + Convert.ToString(Order.sheetfId));
            return Page();
        }
    }
}
