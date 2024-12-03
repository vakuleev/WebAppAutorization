using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class UserEditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        [BindProperty]
        public User User { get; set; } = default!;

        public UserEditModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            // получаем пользователя
            //var user = await _userManager.FindByIdAsync(id);

            var user =  await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            User = user;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        [HttpPost] //                                             имя:     checkBox           checkBox
        public async Task<IActionResult> OnPostSaveUser(string id, string SoftDelete, string ViewDelete)
        {
            // получаем пользователя
            if (User.Id == id) {
                //Конструкция await _userManager.UpdateAsync(User) "User"
                //- не сработает из-за блокировки вызванной асинхронизмом,
                //- поэтому нужно  создавать перед сохранением локольный объект user
                var user = await _userManager.FindByIdAsync(id);
                if (user != null) // && !User.LockoutEnabled)
                {
                    user.Email       = User.Email;
                    user.PhoneNumber = User.PhoneNumber;
                    user.FirstName   = User.FirstName;
                    user.LastName    = User.LastName;
                    user.FamilyName  = User.FamilyName;
                    // Конфигурация мягкого удаления с/в восстановления данных
                    if (SoftDelete != null)
                    {
                        user.SoftDelete = true;
                    }
                    else
                    {
                        user.SoftDelete = false;
                    }
                    // Конфигурация видеть удаленые с/в восстановления данных
                    if (ViewDelete != null)
                    {
                        user.ViewDelete = true;
                    }
                    else
                    {
                        user.ViewDelete = false;
                    }
                    await _userManager.UpdateAsync(user);
                }
            }
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            _context.Attach(User).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                // получаем пользователя
                //var user = await _userManager.FindByIdAsync(id);
                //if (User != null)
                //{
                //    await _userManager.UpdateAsync(User);
                //}

            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!UserExists(User.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return RedirectToPage("./Index");
        }

        //private bool UserExists(string id)
        //{
        //  return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
