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

namespace WebAppAutorization.Pages.Sheetfs
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public Company curCompany { get; set; } = default!;

        public DeleteModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
      public Sheetf Sheetf { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Sheetfs == null)
            {
                return NotFound();
            }

            var sheetf = await _context.Sheetfs.FirstOrDefaultAsync(m => m.Id == id);

            if (sheetf == null)
            {
                return NotFound();
            }
            else 
            {
                Sheetf = sheetf;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            // Определяем loginUserName пользователя вошедшего в систему
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            var loginUserName = User.Identity.Name;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (currentUser != null)
            {
                curUser = currentUser;
                // Определяем по пользователю его текущую Компанию для ввода документов
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.

                var softDelete = curUser.SoftDelete;
            }
            if (id == null || _context.Sheetfs == null)
            {
                return NotFound();
            }
            var sheetf = await _context.Sheetfs.FindAsync(id);

            if (sheetf != null)
            {
                Sheetf = sheetf;
                // Проверяем настройки удаления пользователем
                if (curUser.SoftDelete)
                {
                    Sheetf.Delete = true;
                } else
                {
                    _context.Sheetfs.Remove(Sheetf);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostRecovery(long id)
        {
#pragma warning disable CS0472 // Результат значения всегда одинаковый, так как значение этого типа никогда не равно NULL
            if (id == null || _context.Sheetfs == null)
            {
                return NotFound();
            }
#pragma warning restore CS0472 // Результат значения всегда одинаковый, так как значение этого типа никогда не равно NULL
            var sheetf = await _context.Sheetfs.FindAsync(id);

            if (sheetf != null)
            {
                Sheetf = sheetf;
                Sheetf.Delete = false;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

    }
}
