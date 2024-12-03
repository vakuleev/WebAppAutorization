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
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.InputControlSands
{
    [Authorize]
    [Authorize(Policy = "Входной контроль песка")]
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
        public InputControlSand InputControlSand { get; set; } = default!;
        public InputControlSand _foundDubl { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.InputControlSands == null)
            {
                return NotFound();
            }

            var inputcontrolsand =  await _context.InputControlSands.FirstOrDefaultAsync(m => m.Id == id);
            if (inputcontrolsand == null)
            {
                return NotFound();
            }
            InputControlSand = inputcontrolsand;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.InputControlSands.FirstOrDefaultAsync(
               f => f.DateReceipt == InputControlSand.DateReceipt &&
               f.Id != InputControlSand.Id);

            if (!ModelState.IsValid || foundDubl != null)
            {
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

                //IzvestFromSilos.CreateAt = DateTime.Now; // В конструкторе заполняется один раз при срабатывании.
                InputControlSand.userId = currentUser.Id;
            }

            _context.Attach(InputControlSand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InputControlSandExists(InputControlSand.Id))
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

        private bool InputControlSandExists(long id)
        {
          return (_context.InputControlSands?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
