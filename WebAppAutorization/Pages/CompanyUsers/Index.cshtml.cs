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
//using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;


namespace WebAppAutorization.Pages.CompanyUsers
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public IList<Company> Company { get; set; } = default!;
        public IndexModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            Company = new List<Company>();
        }


        public async Task OnGetAsync()
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            var currentUserName = User.Identity.Name;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (currentUser != null)
            {
                curUser = currentUser;
                // получаем список Companies пользователя user через промежуточную таблицу CompanyUsers по userId
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                var userCompanies = await _context.Companies.Where(u => u.CompanyUsers.Any(c => c.userId == curUser.Id)).ToListAsync();
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                if (userCompanies.Count > 0)
                {
                    Company = userCompanies;
                }
            }
            //if (_context.Companies != null)
            //{
            //    Company = await _context.Companies.ToListAsync();
            //}
        }

        [HttpPost]
        //               
        public async Task<IActionResult> OnPostSelectCompany(long Id)
        {
            // получаем пользователя
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            var currentUserName = User.Identity.Name;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (currentUser != null)
            {
                //Конструкция await _userManager.UpdateAsync(User) "User"
                //- не сработает из-за блокировки вызванной асинхронизмом,
                //- поэтому нужно  создавать перед сохранением локальный объект user
                var user = await _userManager.FindByIdAsync(currentUser.Id);
                if (user != null)
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
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            var currentUserName = User.Identity.Name;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (currentUser != null)
            {
                //Конструкция await _userManager.UpdateAsync(User) "User"
                //- не сработает из-за блокировки вызванной асинхронизмом,
                //- поэтому нужно  создавать перед сохранением локальный объект user
                var user = await _userManager.FindByIdAsync(currentUser.Id);
                if (user != null) 
                {
                    user.CurrentCompanyId = 0;
                    var updateError = await _userManager.UpdateAsync(user);
                }
            }
            return RedirectToPage("./Index");
        }

    }
}
