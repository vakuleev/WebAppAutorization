using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
//using Microsoft.CodeAnalysis.CSharp;
using WebAppAutorization.Data.Tables;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //private readonly RoleManager<IdentityRole> _roleManager;
        public RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<User> _userManager;
        //public IList<ApplicationIdentityRole> _listRole { get; set; } = default!;                      //

        public IndexModel(
            ILogger<IndexModel> logger,
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager)
            
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
            //_listRole    = _roleManager.Roles;

        }
        //public void OnGet()
        //{
            //_listRoles = listRoles;
            //var listRole = _roleManager.Roles;
            //_listRole = (IList<ApplicationIdentityRole>?)listRole;
        //}

        //public async Task OnGetAsync()
        //{
            // Подчиненная таблица строк Role -------------------------------------------------//
            //if (_roleManager.Roles != null)                                                    //
            //{
            //    //OrderList = await _context.Orders.ToListAsync();                             //
            //    //              (IList<ApplicationIdentityRole>)
            //    //var listRole = await _roleManager.Roles.ToListAsync();
            //    //_listRoles = listRoles;
            //}                                                                                  //
            // Подчиненная таблица строк Role -------------------------------------------------//

        //}
        public void OnPost()
        {

        }

        public async Task OnPostNewRole(Role Model)
        {
            string roleName = Model.RoleName.Trim();
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
        public async Task OnPostAddRole(Role model)
        {
            string roleName = model.RoleName.Trim();
            if (!string.IsNullOrEmpty(roleName))
            {
                var usr = await _userManager.GetUserAsync(this.User);
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                await _userManager.AddToRoleAsync(usr, roleName);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            }

        }
        public async Task OnPostRemoveRole(Role model)
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