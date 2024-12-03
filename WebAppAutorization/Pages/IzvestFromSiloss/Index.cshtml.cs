using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.IzvestFromSiloss
{
    [Authorize]
    [Authorize(Policy = "Известь из силоса")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        public string _dateFiltrStart;
        public string _dateFiltrEnd;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public string _messageString { get; set; } = default!;
        public IList<IzvestFromSilos> IzvestFromSiloss { get; set; } = default!;

        public IndexModel(
               UserManager<User> userManager,
               WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            curUser = new User();
            IzvestFromSiloss = new List<IzvestFromSilos>();

        }


        public async Task OnGetAsync()
        {
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                //await GetOperationControls();
            }

            if (_context.IzvestFromSilos != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                IzvestFromSiloss = await _context.IzvestFromSilos.Where(
                    s => s.DateTrial >=  curUser.DateFiltrStart &&
                         s.DateTrial <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateTimeTrial).ToListAsync();
            }
        }
        [HttpPost]
        public async Task<IActionResult> OnPostChangeGoFiltr(long Id)
        {
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                currentUser.DateFiltrStart = curUser.DateFiltrStart;
                currentUser.DateFiltrEnd   = curUser.DateFiltrEnd;

                // Сохраняем параметры фильтра текущего пользователя
                var updateError = await _userManager.UpdateAsync(currentUser);
            }

            //DataFiltr.Id = Id;
            //_context.Attach(DataFiltr).State = EntityState.Modified;
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
