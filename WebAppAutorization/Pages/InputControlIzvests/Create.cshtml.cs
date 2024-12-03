using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.InputControlIzvests
{
    [Authorize]
    [Authorize(Policy = "Входной контроль извести")]
    public class CreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        public CreateModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InputControlIzvest InputControlIzvest { get; set; } = default!;
        public InputControlIzvest _foundDubl { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                // Определяем по пользователю (если надо :)) его текущую Компанию для ввода документов
                //curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);

                //IzvestFromSilos.CreateAt = DateTime.Now; // В конструкторе заполняется один раз при срабатывании.
                InputControlIzvest.userId = currentUser.Id;
            }
            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.InputControlIzvests.FirstOrDefaultAsync(
               f => f.DateReceipt == InputControlIzvest.DateReceipt);

            if (!ModelState.IsValid || _context.InputControlIzvests == null || InputControlIzvest == null || foundDubl != null)
            {
                _foundDubl = foundDubl;
                return Page();
            }

            _context.InputControlIzvests.Add(InputControlIzvest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
