using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.IzvestFromSiloss
{
    [Authorize]
    [Authorize(Policy = "Известь из силоса")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IzvestFromSilos IzvestFromSilos { get; set; } = default!;
        public IzvestFromSilos _foundDubl { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.IzvestFromSilos == null)
            {
                return NotFound();
            }

            var izvestfromsilos =  await _context.IzvestFromSilos.FirstOrDefaultAsync(m => m.Id == id);
            if (izvestfromsilos == null)
            {
                return NotFound();
            }
            IzvestFromSilos = izvestfromsilos;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //Делаем из даты DateTrial и время TimeTrial измерения одно поле дата время измерения DateTimeTrial
            IzvestFromSilos.DoDateTimeTrial();

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            var foundDubl = await _context.IzvestFromSilos.FirstOrDefaultAsync(
                f => f.DateTimeTrial == IzvestFromSilos.DateTimeTrial &&
                f.Id != IzvestFromSilos.Id);

            if (!ModelState.IsValid || foundDubl != null)
            {
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                _foundDubl = foundDubl;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                return Page();
            }

            _context.Attach(IzvestFromSilos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzvestFromSilosExists(IzvestFromSilos.Id))
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

        private bool IzvestFromSilosExists(long id)
        {
          return (_context.IzvestFromSilos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
