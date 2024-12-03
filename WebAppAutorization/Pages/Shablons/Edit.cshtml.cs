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

namespace WebAppAutorization.Pages.Shablons
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public Company curCompany { get; set; } = default!;

        [BindProperty]
        public Sheetf Sheetf { get; set; } = default!;
        public IList<Order> Orders { get; set; } = default!;

        //public long SheetfId { get; set; }
        //public long OrderId { get; set; }

        public EditModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            curCompany = new Company();
            Sheetf = new Sheetf();
            Orders = new List<Order>();
            curUser = new User();
        }


        // Подчиненная таблица строк Order --------------------------------------//
        //public Order Order1 { get; set; } = default!;                           //
        //public Order Order2 { get; set; } = default!;                           //
        public IList<Order> Order { get; set; } = default!;                      //
        // Подчиненная таблица строк Order --------------------------------------//

        public long newSheetfFromShablon(long? id)
        {
            // Функция создания документа по шаблону с номером id 
            // возвращает новый номер созданного документа newSheetfId
            if (id == null || _context.Sheetfs == null)
            {
                return 0;
            }
            var shablon = _context.Sheetfs.FirstOrDefault(m => m.Id == id);
            if (shablon == null)
            {
                return 0;
            }
            Sheetf.DocType = "D";
            Sheetf.DateAct = DateTime.Now;
            if (Sheetf.CreateAt == null) { Sheetf.CreateAt = DateTime.Now; }
            //Sheetf.CreateAt = DateTime.Now;
            Sheetf.NumAct          = shablon.NumAct;
            Sheetf.Pokupat         = shablon.Pokupat;
            Sheetf.Prodavec        = shablon.Prodavec;
            Sheetf.ProductName     = shablon.ProductName;
            Sheetf.ResType         = shablon.ResType;
            Sheetf.ResName         = shablon.ResName;
            Sheetf.ProductEdIzm    = shablon.ProductEdIzm;
            Sheetf.ProductTarif    = shablon.ProductTarif;
            Sheetf.ProductNalog    = shablon.ProductNalog;
            Sheetf.ProductCount    = shablon.ProductCount;
            Sheetf.companyId       = shablon.companyId;
            //Sheetf.ProductStoim    = shablon.ProductStoim;
            //Sheetf.SumNalog        = shablon.SumNalog;
            //Sheetf.SumProductNalog = shablon.SumProductNalog;

            var orders = _context.Orders.Where(o => o.sheetfId == shablon.Id).ToList();
            if (orders != null)
            {
                Orders = orders;
            }
            //----------------------------------------------------------------------------------------------------//

            _context.Sheetfs.Add(Sheetf);
            _context.SaveChanges();

            var lastSheetf = _context.Sheetfs.OrderBy(s => s.Id).Last();
            long newSheetfId = lastSheetf.Id;

            var countOrders = Orders.Count();
            for (int i = 0; i < countOrders; i++)
            {
                //Order[i].sheetfId = newSheetfId;
                //var lastOrder = _context.Orders.OrderBy(s => s.Id).Last();
                var newOrder = new Order();
                newOrder.ProductName  = Orders[i].ProductName;
                newOrder.ProductEdIzm = Orders[i].ProductEdIzm;
                newOrder.ProductNalog = Orders[i].ProductNalog;
                newOrder.ProductTarif = Orders[i].ProductTarif;
                newOrder.ProductCount = Orders[i].ProductCount;
                newOrder.ResType      = Orders[i].ResType;
                newOrder.ResName      = Orders[i].ResName;
                newOrder.OverLimit    = Orders[i].OverLimit;
                newOrder.sheetfId     = newSheetfId;
                newOrder.DocType      = "S";
                newOrder.Delete       = false;
                _context.Orders.Add(newOrder);
            }
            _context.SaveChanges();

            return newSheetfId;
        }
        public async Task<IActionResult> OnGetAsync(long? id, long? shablonId)
        {
            if (shablonId > 0)   //Режим создания документа по шаблону
            {
                id = newSheetfFromShablon(shablonId);
            }
            //Режим корректировки документа
            if (id == 0 || _context.Sheetfs == null)
            {
                return NotFound();
            }
            var sheetf =  await _context.Sheetfs.FirstOrDefaultAsync(m => m.Id == id);
            if (sheetf == null)
            {
                return NotFound();
            }
            Sheetf = sheetf;

            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                // Определяем по пользователю его текущую Компанию для ввода документов
                curCompany = await _context.Companies.FindAsync(curUser.CurrentCompanyId);

                Sheetf.companyId = curCompany.Id;
                Sheetf.userId = curUser.Id;
                currentUser.AdminKeyActive = "EndSelectShablon";
                await _userManager.UpdateAsync(currentUser);
            }

            //------------------------ Список связанных полей ----------------------------------//
            ViewData["Prodavec"]     = new SelectList(_context.Agents, "Name", "Name");         //
            ViewData["Pokupat"]      = new SelectList(_context.Companies, "Name", "Name");      //
            ViewData["ProductName"]  = new SelectList(_context.Products, "Name", "Name");       //
            ViewData["ProductEdIzm"] = new SelectList(_context.Products, "EdIzm", "EdIzm");     //
            ViewData["ResName"]      = new SelectList(_context.Resource, "ResName", "ResName"); //
            //------------------------ Список связанных полей ----------------------------------//

            // Подчиненная таблица строк Order -------------------------------------------------//
            if (_context.Orders != null)                                                        //
            {
                //OrderList = await _context.Orders.ToListAsync();                              //
                Order = await _context.Orders.Include(o => o.Sheetf)
                    //.OrderBy(o => o.ProductName) // Сортировать по наименованию продукта(услуги)
                    .Where(o => o.sheetfId == id)
                    .ToListAsync();             //
            }                                                                                   //
            // Подчиненная таблица строк Order -------------------------------------------------//

            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//       "кВт.ч"
            Sheetf.ProductCount = await _context.Orders.Where(o => 
                o.sheetfId == id && 
                o.ProductEdIzm == Sheetf.ProductEdIzm)
                .SumAsync(o => o.ProductCount);
            Sheetf.ProductStoim = await _context.Orders.Where(o => o.sheetfId == id)
                .SumAsync(o => o.ProductStoim);
            Sheetf.SumNalog = await _context.Orders.Where(o => o.sheetfId == id)
                .SumAsync(o => o.SumNalog);
            Sheetf.SumProductNalog = await _context.Orders.Where(o => o.sheetfId == id)
                .SumAsync(o => o.SumProductNalog);
            if (Sheetf.ProductCount != 0) {
                Sheetf.ProductTarif = Convert.ToDouble(Sheetf.ProductStoim) / Sheetf.ProductCount;
             }
            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
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

                Sheetf.companyId = curCompany.Id;
                Sheetf.userId    = curUser.Id;
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sheetf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SheetfExists(Sheetf.Id))
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

        private bool SheetfExists(long id)
        {
          return (_context.Sheetfs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
