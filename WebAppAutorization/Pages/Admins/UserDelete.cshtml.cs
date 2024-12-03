using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class UserDeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        public UserDeleteModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public User _deleteUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _userManager == null)
            {
                return NotFound();
            }
            //Ищем роль для операции Delete по Id из базы данных
            var deleteUser = await _userManager.FindByIdAsync(id);
            if (deleteUser == null)
            {
                return NotFound();
            }
            _deleteUser = deleteUser;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(User Model, string id)
        {
            //Ищем user для операции удаления по id из базы данных
            var deleteUser = await _userManager.FindByIdAsync(id);
            if (deleteUser != null)
            {
                _deleteUser = deleteUser;
                //Удаление user из базы данных
                if (_deleteUser != null)
                {
                    await _userManager.DeleteAsync(_deleteUser);
                    await _userManager.UpdateAsync(Model);
                }
            }
            return RedirectToPage("./Index");
        }
    }

    /*///////////////////////////////////////////////////////////////////////////////////////////
    public class UserDeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserDeleteModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ApplicationIdentityRole ApplicationIdentityRole { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ApplicationIdentityRole == null || ApplicationIdentityRole == null)
            {
                return Page();
            }

            _context.ApplicationIdentityRole.Add(ApplicationIdentityRole);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
    *////////////////////////////////////////////////////////////////////////////////////////////
}
