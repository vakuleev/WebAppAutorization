using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;
//using System.Data.SqlClient;

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize]
    public class OrderEditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public OrderEditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        //public Sheetf Sheetf { get; set; } = default!;
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
           //ViewData["SheetfId"] = new SelectList(_context.Sheetfs, "Id", "Id");

            //------------------------ Список связанных полей --------------------//
            ViewData["sheetfId"] = new SelectList(_context.Sheetfs, "Id", "Id");

            ViewData["ProductName"] = new SelectList(_context.Products, "Name", "Name");
            ViewData["ResName"]     = new SelectList(_context.Resource, "ResName", "ResName");
            //------------------------ Список связанных полей --------------------//

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Order.DocType = "S";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Находим и подставляем код ресурса
            var ResType = _context.Resource.FirstOrDefault(r => r.ResName == Order.ResName).Id;
            if (ResType != null)
            {
                Order.ResType = ResType;
            }
            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                //var Sheetf = await _context.Orders.FirstOrDefaultAsync(s => s.Id == Order.SheetfId);
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
            //return RedirectToPage("./Index");
            //                     /Sheetfs/Edit?id=1 
            //return RedirectToPage("../Sheetfs/Edit?id=" + Convert.ToString(Order.SheetfId));
            Response.Redirect("../Shablons/Edit?id=" + Convert.ToString(Order.sheetfId));
            return Page();
        }

        private bool OrderExists(long id)
        {
          return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
