using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize(Policy = "Шаблоны")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public Company curCompany { get; set; } = default!;
        public IList<Company> Company { get; set; } = default!;
        public IList<Sheetf> Shablon { get; set; } = default!;

        public IndexModel(
           UserManager<User> userManager,
           WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            Company = new List<Company>();
            curUser = new User();
        }

        public IList<Sheetf> Sheetf { get;set; } = default!;

        public async Task<IActionResult> OnPostSelectShablon(long Id)
        {
            //var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
            //if (currentUser  != null)
            //{
            //    curUser = currentUser;
            //    curUser.AdminKeyActive = "SelectShablon";
            //}
            if  (curUser.AdminKeyActive != "SelectShablon")
            {
                curUser.AdminKeyActive = "SelectShablon";
            }
            else
            {
                curUser.AdminKeyActive = "";
            }

            return RedirectToPage("./Index");
        }


        public async Task OnGetAsync()
        {
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                //curUser.AdminKeyActive = "";
                // Определяем по пользователю его текущую Компанию для ввода документов
                curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);

                // получаем список Companies пользователя user через промежуточную таблицу CompanyUsers по userId
                var userCompanies = await _context.Companies.Where(u => u.CompanyUsers.Any(c => c.userId == curUser.Id)).ToListAsync();
                if (userCompanies.Count > 0)
                {
                    Company = userCompanies;
                }
            }

            if (_context.Sheetfs != null)
            {
                // определяем по пользователю  curUser.CurrentCompanyId 
                // Компанию для формирования списка шаблонов (DocType == "S")
                Shablon = await _context.Sheetfs
                .Where(s => (s.companyId == curUser.CurrentCompanyId) && (s.DocType == "S")).ToListAsync();

                // определяем по пользователю  curUser.CurrentCompanyId 
                // Компанию для формирования списка документов (DocType == "D")
                if (curUser.ViewDelete) {
                    //Показываем все, в том числе помеченные как удаленные
                    Sheetf = await _context.Sheetfs
                    .Where(s => (s.companyId == curUser.CurrentCompanyId) &&
                                (s.DocType == "S"))
                    .ToListAsync();
                } else {
                    //Показываем без записей помеченные как удаленные
                    Sheetf = await _context.Sheetfs
                    .Where(s => (s.companyId == curUser.CurrentCompanyId) &&
                                (s.DocType == "S") &&
                                !s.Delete)
                    .ToListAsync();
                }
            }

        }
        [HttpPost]
        //               
        public async Task<IActionResult> OnPostSelectCompany(long Id)
        {
            // получаем пользователя
            var currentUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
            if (currentUser != null)
            {
                //Конструкция await _userManager.UpdateAsync(User) "User"
                //- не сработает из-за блокировки вызванной асинхронизмом,
                //- поэтому нужно  создавать перед сохранением локальный объект user
                var user = await _userManager.FindByIdAsync(currentUser.Id);
                if (user != null) // && !User.LockoutEnabled)
                {
                    user.CurrentCompanyId = Id;
                    var updateError = await _userManager.UpdateAsync(user);
                }
            }
            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostDeSelectCompany(long Id)
        {
            // получаем пользователя
            var currentUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
            if (currentUser != null)
            {
                //Конструкция await _userManager.UpdateAsync(User) "User"
                //- не сработает из-за блокировки вызванной асинхронизмом,
                //- поэтому нужно  создавать перед сохранением локальный объект user
                var user = await _userManager.FindByIdAsync(currentUser.Id);
                if (user != null) // && !User.LockoutEnabled)
                {
                    user.CurrentCompanyId = 0;
                    var updateError = await _userManager.UpdateAsync(user);
                }
            }
            return RedirectToPage("./Index");
        }

    }
}
