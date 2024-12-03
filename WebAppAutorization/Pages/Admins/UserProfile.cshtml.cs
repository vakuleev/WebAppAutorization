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

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class UserProfileModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        public UserProfileModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _userManager == null)
            {
                return NotFound();
            }
            //Ищем User для операции редактирования по Id из базы данных
            var profilUser = await _userManager.FindByIdAsync(id);
            if (profilUser == null)
            {
                return NotFound();
            }
            User = profilUser;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(User Model, string id)
        {
            //Ищем user для операции редактирования по id в базе данных
            var profilUser = await _userManager.FindByIdAsync(id);
            if (profilUser != null)
            {
                User = profilUser;
                //Сохранение user в базе данных
                if (profilUser != null)
                {
                    await _userManager.UpdateAsync(Model);
                }
            }
            return RedirectToPage("./Index");
        }
     }
}
