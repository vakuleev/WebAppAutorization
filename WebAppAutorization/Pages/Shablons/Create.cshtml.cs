using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public Company curCompany { get; set; } = default!;

        [BindProperty]
        public Sheetf Sheetf { get; set; } = default!;

        public CreateModel(
            UserManager<User> userManager,  
            WebAppAutorization.Data.gnsDbContext context)
        {
            _userManager = userManager;
            _context = context;
            curUser = new User();
            Sheetf = new Sheetf();
        }

        public IActionResult OnGet()
        {
            //------------------------ Список связанных полей ----------------------------------//
            ViewData["companyId"] = new SelectList(_context.Companies, "Id", "Id");
            //------------------------ Список связанных полей ----------------------------------//
            ViewData["Prodavec"] = new SelectList(_context.Agents, "Name", "Name");   //
            ViewData["Pokupat"] = new SelectList(_context.Companies, "Name", "Name");       //
            ViewData["ProductName"] = new SelectList(_context.Products, "Name", "Name");        //
            ViewData["ProductEdIzm"] = new SelectList(_context.Products, "EdIzm", "EdIzm");     //
            ViewData["ResName"] = new SelectList(_context.Resource, "ResName", "ResName"); //
            //------------------------ Список связанных полей ----------------------------------//

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                // Определяем по пользователю его текущую Компанию для ввода документов
                curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);

                Sheetf.CreateAt  = DateTime.Now;
                Sheetf.DocType   = "S";
                Sheetf.companyId = curCompany.Id;
                Sheetf.userId    = curUser.Id;
            }

            if (!ModelState.IsValid || _context.Sheetfs == null || Sheetf == null)
            {
                return Page();
            }

            await _context.Sheetfs.AddAsync(Sheetf);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

}
