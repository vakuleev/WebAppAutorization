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

namespace WebAppAutorization.Pages.SandSludgePools
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        public CreateModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context     = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SandSludgePool SandSludgePool { get; set; } = default!;
        public SandSludgePool _foundDubl { get; set; } = default!;


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

                //SandSludgePool.CreateAt = DateTime.Now; // В конструкторе заполняется один раз при срабатывании.
                SandSludgePool.userId   = currentUser.Id;
            }
            //Делаем из даты DateTrial и время TimeTrial измерения одно поле дата время измерения DateTimeTrial
            SandSludgePool.DoDateTimeTrial();

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.SandSludgePools.FirstOrDefaultAsync(
                f => f.DateTimeTrial == SandSludgePool.DateTimeTrial &&
                f.NumPool == SandSludgePool.NumPool);

            if (!ModelState.IsValid || _context.SandSludgePools == null || SandSludgePool == null || foundDubl != null)
            {
                    _foundDubl = foundDubl;
                    return Page();
            }

            _context.SandSludgePools.Add(SandSludgePool);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
