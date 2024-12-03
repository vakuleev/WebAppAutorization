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
using Microsoft.IdentityModel.Tokens;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public RoleManager<IdentityRole> _roleManager;
        public EditModel(
            RoleManager<IdentityRole> roleManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
        }

        [BindProperty]
        public IdentityRole EditRole { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _roleManager == null)
            {
                return NotFound();
            }
            //Ищем роль для операции Edit по Id из базы данных
            var editRole = await _roleManager.FindByIdAsync(id);
            if (editRole == null)
            {
                return NotFound();
            }
            EditRole = editRole;
            return Page();
        }

        [HttpPost]
        public async Task<RedirectToPageResult> OnPostSaveRole(string Id)
        {
            // получаем пользователя
            var role = await _roleManager.FindByIdAsync(Id);
            if (role != null)
            {
                //Из класса модели с вебформы забираем новое значение EditRole.Name;
                role.Name = EditRole.Name;
                await _roleManager.UpdateAsync(role);
            }
            return RedirectToPage("./Index");

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.

        public async Task<IActionResult> OnPostAsync(IdentityRole Model, string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            //if (!_roleManager.Roles.IsNullOrEmpty())
            //{
            //    return Page();
            //}
            try
            {
                if (role != null)
                {
                    role.Name = EditRole.Name;
                    await _roleManager.UpdateAsync(role);
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
            return RedirectToPage("./Index");
        }

        private bool ApplicationIdentityRoleExists(string id)
        {
          return (_context.Roles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
