using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.CopyAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace WebAppAutorization.Pages.Admins
{
    [Authorize(Policy = "Administrators")]
    public class DeleteModel : PageModel
    {
        //private readonly WebAppAutorization.Data.gnsDbContext _context;
        public RoleManager<IdentityRole> _roleManager;

        public DeleteModel(
            RoleManager<IdentityRole> roleManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            //_context = context;
            _roleManager = roleManager;
        }

        //[BindProperty]
        //public RoleManager<ApplicationIdentityRole> ApplicationIdentityRole { get; set; } = default!;
        //public ApplicationIdentityRole ApplicationIdentityRole { get; set; } = default!;
        //[BindProperty]
        public IdentityRole DeleteRole { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _roleManager == null)
            {
                return NotFound();
            }
            //Ищем роль для операции Delete по Id из базы данных
            var deleteRole = await _roleManager.FindByIdAsync(id);
            if (deleteRole == null)
            {
                return NotFound();
            }
            DeleteRole = deleteRole;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Role Model, string id)
        {
            //Ищем роль для операции удаления по id из базы данных
            var delRole = await _roleManager.FindByIdAsync(id);
            if (delRole != null)
            {
                DeleteRole = delRole;
                //Удаление роли из базы данных
                if (DeleteRole != null)
                {
                    await _roleManager.DeleteAsync(DeleteRole);
                    await _roleManager.UpdateAsync(Model);
                }
            }
            return RedirectToPage("./Index");
        }
    }
}
