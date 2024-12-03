using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppAutorization.Data.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebAppAutorization.Pages.SandSludgeMills
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public UserManager<User> _userManager;

        public EditModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public SandSludgeMill SandSludgeMill { get; set; } = default!;

        public SandSludgeMill _foundDubl { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.SandSludgeMills == null)
            {
                return NotFound();
            }

            var sandsludgemill =  await _context.SandSludgeMills.FirstOrDefaultAsync(m => m.Id == id);
            if (sandsludgemill == null)
            {
                return NotFound();
            }
            SandSludgeMill = sandsludgemill;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //Делаем из даты DateTrial и время TimeTrial измерения одно поле дата время измерения DateTimeTrial
            SandSludgeMill.DoDateTimeTrial();

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.SandSludgeMills.FirstOrDefaultAsync(
                f=>f.DateTimeTrial == SandSludgeMill.DateTimeTrial && 
                f.NumPool == SandSludgeMill.NumPool && 
                f.Id != SandSludgeMill.Id);
            if (!ModelState.IsValid || foundDubl != null)
            {
                //yield return new ValidationResult("Дубликат ! Такая запись уже есть !", new string[] {"Ошибка"});
                _foundDubl = foundDubl;
                return Page();
            }
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                // Определяем по пользователю (если надо :)) его текущую Компанию для ввода документов
                //curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);

                //SandSludgeMill.CreateAt = DateTime.Now; // В конструкторе заполняется один раз при срабатывании.
                SandSludgeMill.userId = currentUser.Id;
            }

            _context.Attach(SandSludgeMill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SandSludgeMillExists(SandSludgeMill.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SandSludgeMillExists(long id)
        {
          return (_context.SandSludgeMills?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
