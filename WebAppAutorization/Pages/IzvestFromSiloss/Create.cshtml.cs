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

namespace WebAppAutorization.Pages.IzvestFromSiloss
{
    [Authorize]
    [Authorize(Policy = "Известь из силоса")]
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
        public IzvestFromSilos IzvestFromSilos { get; set; } = default!;
        public IzvestFromSilos _foundDubl { get; set; } = default!;


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
                IzvestFromSilos.userId = currentUser.Id;
            }
            //Делаем из даты DateTrial и время TimeTrial измерения одно поле дата время измерения DateTimeTrial
            IzvestFromSilos.DoDateTimeTrial();

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.IzvestFromSilos.FirstOrDefaultAsync(
                f => f.DateTimeTrial == IzvestFromSilos.DateTimeTrial);

            if (!ModelState.IsValid || _context.IzvestFromSilos == null || IzvestFromSilos == null || foundDubl != null)
            {
                    _foundDubl = foundDubl;
                    return Page();
            }

            _context.IzvestFromSilos.Add(IzvestFromSilos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
