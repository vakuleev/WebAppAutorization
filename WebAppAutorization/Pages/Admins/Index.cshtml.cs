using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Versioning;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;
//using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<ApplicationIdentityUser> _userManager;
        public RoleManager<IdentityRole> _roleManager;
        public UserManager<User> _userManager;
        //public UserManager<IdentityUser> _userManager;
        [BindProperty]
        public List<IdentityRole> _roleAll { get; set; }
        public IdentityRole DeleteRole { get; set; } = default!;
        //public IdentityUser DeleteUser { get; set; } = default!;
        public User DeleteUser { get; set; } = default!;
        public User LogInUser { get; set; } = default!;

        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }

        public List<Company>? AllCompanies { get; set; }
        //public IList<Company>? UserCompanies { get; set; }
        public List<Company>? UserCompanies { get; set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)

        {
            _context     = context;
            _logger      = logger;
            _roleManager = roleManager;
            _userManager = userManager;
            //UserRoles  = await _userManager.GetRolesAsync();
            _roleAll     = new List<IdentityRole>();
            AllRoles     = new List<IdentityRole>();
            AllCompanies = new List<Company>();
            UserCompanies = new List<Company>();
            LogInUser     = new User();
        }
        public async Task OnGetAsync()
        {
            if (_context != null)
            {
                //_roleAll = await _roleAll.OrderBy(r => r.Name).ToListAsync();
            }
        }

        public async Task OnPostListUserCompanies(string Id)
        {
            // получаем пользователя user по его Id
            var user = await _userManager.FindByIdAsync(Id);
            if (user != null)
            {
                UserId = user.Id;

                var allCompanies = await _context.Companies
                    //Сортируем для удобного вывода поиска
                    .OrderBy(c => c.Name)
                    .ToListAsync();

                // получаем список Companies пользователя user через промежуточную таблицу CompanyUsers по userId
                var userCompanies = await _context.Companies.Where(u => u.CompanyUsers.Any(c => c.userId == UserId))
                    //Сортируем для удобного вывода поиска
                    //.OrderBy(u => u.Name)
                    .ToListAsync();

                // ТАК (если нужно) получаем список Users компании company через промежуточную таблицу CompanyUsers по companyId = 1 () целое число идентификатора
                // var companyUsers = await _context.Users.Where(u => u.CompanyUsers.Any(c => c.companyId == 1)).ToListAsync();

                AllCompanies  = allCompanies;
                // (IList<string>?)
                UserCompanies = userCompanies;
            }
            //TODO ViewBAG по CompanyId relation вытянуть Companies.Name  
            // получаем пользователя вошедшего в систему
            var loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (loginUser != null)
            {
                LogInUser = loginUser;
                //Запоминаем активность нажатия ListUserRoles
                LogInUser.AdminKeyActive = "ListUserCompanies";
            }

        }
        public async Task OnPostListUserRoles(string Id)
        {
            // получаем пользователя
            //User
            var user = await _userManager.FindByIdAsync(Id);
            //if (user != null)
            //{
            // получем список ролей пользователя
            var userRoles = await _userManager.GetRolesAsync(user);
            var allRoles  = await _roleManager.Roles
                 //Сортируем для удобного вывода поиска
                .OrderBy(r => r.Name)
                .ToListAsync();
            //ChangeRoleViewModel model = new ChangeRoleViewModel
            //{
            UserId = user.Id;
            UserEmail = user.Email;
            UserRoles = userRoles;
            AllRoles  = allRoles;

            // получаем пользователя вошедшего в систему
            var loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (loginUser != null)
            {
                LogInUser = loginUser;
                //Запоминаем активность нажатия ListUserRoles
                LogInUser.AdminKeyActive = "ListUserRoles";
            }
        }

        [HttpPost]
        public async Task OnPostConfirmedUser(string Id)
        {
            // получаем пользователя
            var user = await _userManager.FindByIdAsync(Id);
            if (user != null)
            {
                if (user.EmailConfirmed)
                     { user.EmailConfirmed = false; }
                else 
                     { user.EmailConfirmed = true; }     //Подтвержденный логин пользователя (пользователь имеет право на вход в приложение)

                await _userManager.UpdateAsync(user);
            }
        }

        [HttpPost]
        public async Task OnPostSaveUserRoles(string userId, List<string> roles)
        {
            // получаем пользователя
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                // получем список ролей пользователя
                var userRoles = await _userManager.GetRolesAsync(user);
                // получаем все роли
                var allRoles = _roleManager.Roles.ToList();
                // получаем список ролей, которые были добавлены
                var addedRoles = roles.Except(userRoles);
                // получаем роли, которые были удалены
                var removedRoles = userRoles.Except(roles);

                await _userManager.AddToRolesAsync(user, addedRoles);

                await _userManager.RemoveFromRolesAsync(user, removedRoles);

                //return RedirectToAction("UserList");
            }
            //Завершаем активность нажатой клавиши ListUserRoles
            //LogInUser.AdminKeyActive = "";
            //return NotFound();
        }

        [HttpPost]
        public async Task OnPostSaveUserCompanies(string Id, List<string> companyChecked)
        {
            // получаем пользователя
            var user = await _userManager.FindByIdAsync(Id);
            if (user != null)
            {
                UserId = user.Id;
                // получаем список всех Companies
                var allCompanies = await _context.Companies.ToListAsync();

                // получем список Companies пользователя
                var userCompanies = await _context.Companies.Where(u => u.CompanyUsers.Any(c => c.userId == UserId)).ToListAsync();

                // Создаем список компаний отмеченных в List<string> companyChecked который получен от Администратора
                var сompanies = new List<Company>();
                for (int i = 0; i < companyChecked.Count; i++)
                {
                    foreach (Company company in allCompanies)
                    {
                        if (company.Name == companyChecked[i])
                        {
                            сompanies.Add(company);
                        }
                    }
                }

                // получаем список компаний addedCompanies, которые были добавлены
                var addedCompanies = сompanies.Except(userCompanies);

                // получаем список компаний removedCompanies, которые были удалены
                var removedCompanies = userCompanies.Except(сompanies);

                foreach (var company in addedCompanies)
                {
                    user.CompanyUsers.Add(new CompanyUser { company = company });
                }
                
                foreach (var company in removedCompanies)
                {
                    user.CompanyUsers.Remove(_context.CompanyUsers.Find(company.Id, UserId));
                }

                // Фиксируем изменения для АКТУАЛЬНОГО состояния user
                await _context.SaveChangesAsync();
                // Определяем компанию пользователя по умолчанию
                var firstCompany = await _context.CompanyUsers.FirstOrDefaultAsync(u=> u.userId == UserId);
                if (firstCompany != null)
                {
                    user.CurrentCompanyId = firstCompany.companyId;
                }
                else
                {
                    // Ситуация когда нет назначенных компаний
                    user.CurrentCompanyId = 0;
                }
                UserId = "";
                //Завершаем активность нажатой клавиши ListUserCompanies
                //LogInUser.AdminKeyActive = "";
                // Фиксируем изменения для АКТУАЛЬНОГО состояния user
                await _context.SaveChangesAsync();

                //return RedirectToAction("UserList");
            }

            //return NotFound();
        }

        public async Task OnPostNewRole(Role model)
        {
            try
            {
                if (!string.IsNullOrEmpty(model.RoleName))
                {
                    string roleName = model.RoleName.Trim();
                    if (!string.IsNullOrEmpty(roleName))
                    {
                        if (!await _roleManager.RoleExistsAsync(roleName))
                        {
                            //Создание роли
                            await _roleManager.CreateAsync(new IdentityRole
                            {
                                Name = roleName,
                                NormalizedName = roleName
                            });
                        }
                    }
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ApplicationIdentityRoleExists(ApplicationIdentityRole.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }
        }

        public async Task OnPostDelRole(Role model, string Id)
        {
            //Ищем роль для операции удаления по Id из базы данных
            var delRole = _roleManager.FindByIdAsync(Id);
            if (delRole != null)
            {
                DeleteRole = await delRole;
                //Удаление роли из базы данных
                if (DeleteRole != null)
                {
                    await _roleManager.DeleteAsync(DeleteRole);
                    await _roleManager.UpdateAsync(model);
                }
            }
        }
        public async Task OnPostDelUser(User model, string Id)
        {
            //Ищем user для операции удаления по Id из базы данных
            var delUser = _userManager.FindByIdAsync(Id);
            if (delUser != null)
            {
                DeleteUser = await delUser;
                //Удаление user из базы данных
                if (DeleteRole != null)
                {
                    await _userManager.DeleteAsync(DeleteUser);
                    await _userManager.UpdateAsync(model);
                }
            }
        }
        public async Task OnPostAddRole(Role model)
        {
            if (model.RoleName != "")
            {
                string roleName = model.RoleName.Trim();
                if (!string.IsNullOrEmpty(roleName))
                {
                    var usr = await _userManager.GetUserAsync(this.User);
                    await _userManager.AddToRoleAsync(usr, roleName);
                }
            }

        }
        public async Task OnPostRemoveRole(Role model)
        {
            if (model.RoleName != "")
            {
                string roleName = model.RoleName.Trim();
                if (!string.IsNullOrEmpty(roleName))
                {
                    var usr = await _userManager.GetUserAsync(this.User);
                    await _userManager.RemoveFromRoleAsync(usr, roleName);
                }
            }
        }

    }
}
