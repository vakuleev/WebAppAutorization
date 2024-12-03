using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Messaging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebAppAutorization.Pages.Shablons

{
    [Authorize]
    public class OrderCreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public OrderCreateModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            Order = new Order();
        }
        [BindProperty]

        public Order Order { get; set; } = default!;

        //public IActionResult OnGet()

        //ВНИМАНИЕ - в вызывающей форме HTML надо предать в значение           sheetfId        <- Sheetf.Id
        // - :
        //<a class="btn btn-primary btn-sm" asp-page="./OrderCreate" asp-route-sheetfId  ="@Model.Sheetf.Id">Создать новую строку Order</a>
        //                                                                     имя принимаемой <- передаваемое поле
        //                                                                     _______________    _________________
        public async Task<IActionResult> OnGetAsync(long? sheetfId)
        {
            //Order = new Order();
            // Для передачи указателя на SheetfId в форму html
            Order.sheetfId = (long)sheetfId;
            // TODO Order.SheetfId = _context.Entry(_context.Sheetfs).Property("Id").CurrentValue;

            //------------------------ Список связанных полей ------------------------//

            ViewData["sheetfId"]    = new SelectList(_context.Sheetfs, "Id", "Id");
            ViewData["ProductName"] = new SelectList(_context.Products, "Name", "Name");
            ViewData["ResName"] = new SelectList(_context.Resource, "ResName", "ResName");
            //------------------------ Список связанных полей ------------------------//

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid || _context.Orders == null || Order == null)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");
            Response.Redirect("../Shablons/Edit?id=" + Convert.ToString(Order.sheetfId));
            return Page();

        }
    }
}
