using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.Sheetfs
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

        // Подчиненная таблица строк Order ---------------------------------------//
        //public Order Order1 { get; set; } = default!;                           //
        //public Order Order2 { get; set; } = default!;                           //
        [BindProperty]
        public List<Order> Order { get; set; } = default!;                        //
        // Подчиненная таблица строк Order ---------------------------------------//
        [BindProperty]
        public List<Sheetf> OrderItog { get; set; } = default!;                        //

        public EditModel(
            UserManager<User> userManager,
            WebAppAutorization.Data.gnsDbContext context)
        {
            _context     = context;
            _userManager = userManager;
            curCompany   = new Company();
            Sheetf       = new Sheetf();  // ВЛИЯНИЕ НА ПОВТОРНОЕ СОЗДАНИЕ !!!
            Orders       = new List<Order>();
            //Order        = new List<Order>();
            curUser      = new User();
        }

        public async Task<IActionResult> OrderRender(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Order[Id]).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order[Id].Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //Response.Redirect("../Sheetfs/Edit?id=" + Convert.ToString(Order[Id].sheetfId));
            //return Page();
            return RedirectToPage("../Sheetfs/Edit?id=" + Convert.ToString(Order[Id].sheetfId));
        }

        public async Task<IActionResult> OrderSave(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Order[Id]).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order[Id].Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //Response.Redirect("../Sheetfs/Edit?id=" + Convert.ToString(Order[Id].sheetfId));
            //return Page();
            return RedirectToPage("../Sheetfs/Edit?id=" + Convert.ToString(Order[Id].sheetfId));
        }

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

            //TODO Стоит попробовать определение наличия строки с превышением лимита true через запрос ------------------------------ TODO --------- //
            var OwerLimit = false;
            var ExistOverLimit = _context.Orders.FirstOrDefault(o => o.sheetfId == shablon.Id && o.OverLimit);
            if (ExistOverLimit != null) { OwerLimit = true; }
            var orders = _context.Orders.Where(o => o.sheetfId == shablon.Id).ToList();
            if (orders != null)
            {
                Orders = orders;
            }
            //    foreach (var item in Orders) {
            //        if (item.OverLimit)
            //        {
            //            OwerLimit = true;
            //            break;
            //        }
            //    }
            //}
            //TODO Стоит попробовать определение наличия строки с превышением лимита true через запрос ------------------------------ TODO --------- //

            //// 2023-12-25 !!!      ПЕРЕНЕСЕНО ИЗ КОНСТРУКТОРА В ФУНКЦИЮ (ИСКЛЮЧЕНИЕ ПОВТОРА СОЗДАНИЯ) ------------------------------------------------------------
            //Sheetf = new Sheetf();
            //// 2023-12-25 !!!      ПЕРЕНЕСЕНО ИЗ КОНСТРУКТОРА В ФУНКЦИЮ (ИСКЛЮЧЕНИЕ ПОВТОРА СОЗДАНИЯ) ------------------------------------------------------------

            Sheetf.DocType = "D";
            Sheetf.DateAct = DateTime.Now;
            if (Sheetf.CreateAt == null) { Sheetf.CreateAt = DateTime.Now; }
            //Sheetf.CreateAt = DateTime.Now;
            Sheetf.NumAct          = shablon.NumAct;
            Sheetf.Pokupat         = shablon.Pokupat;
            Sheetf.Prodavec        = shablon.Prodavec;
            Sheetf.ProductName     = shablon.ProductName;
            Sheetf.ProductEdIzm    = shablon.ProductEdIzm;
            Sheetf.ProductTarif    = shablon.ProductTarif;
            Sheetf.ProductNalog    = shablon.ProductNalog;
            Sheetf.ProductCount    = shablon.ProductCount;
            Sheetf.companyId       = shablon.companyId;
            Sheetf.ResType         = shablon.ResType;
            Sheetf.ResName         = shablon.ResName;
            Sheetf.OverLimit       = OwerLimit;               
            //----------------------------------------------------------------------------------------------------//

            _context.Sheetfs.Add(Sheetf);
            _context.SaveChanges();

            var lastSheetf = _context.Sheetfs.OrderBy(s => s.Id).Last();
            long newSheetfId = lastSheetf.Id;
            var countOrders = Orders.Count();
            for (int i = 0; i < countOrders; i++)
            {
                var newOrder = new Order();
                newOrder.ProductName  = Orders[i].ProductName;
                newOrder.ProductEdIzm = Orders[i].ProductEdIzm;
                newOrder.Calories     = Orders[i].Calories;
                newOrder.ProductNalog = Orders[i].ProductNalog;
                newOrder.ProductTarif = Orders[i].ProductTarif;
                newOrder.ProductCount = Orders[i].ProductCount;
                newOrder.sheetfId     = newSheetfId;
                newOrder.DocType      = "D";
                newOrder.Delete       = false;
                newOrder.ResType      = Orders[i].ResType;
                newOrder.ResName      = Orders[i].ResName;
                newOrder.OverLimit    = Orders[i].OverLimit;
                _context.Orders.Add(newOrder);
            }
            _context.SaveChanges();

            return newSheetfId;
        }
        public async Task<IActionResult> OnGetAsync(long? id, long? shablonId)
        {
            if (shablonId > 0)                       //Режим создания документа по шаблону
            {
                id = newSheetfFromShablon(shablonId);
            }
            if (id == 0 || _context.Sheetfs == null) //Режим корректировки документа
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
            ViewData["Prodavec"]     = new SelectList(_context.Agents, "Name", "Name");   //
            ViewData["Pokupat"]      = new SelectList(_context.Companies, "Name", "Name");       //
            ViewData["ProductName"]  = new SelectList(_context.Products, "Name", "Name");        //
            ViewData["ProductEdIzm"] = new SelectList(_context.Products, "EdIzm", "EdIzm");     //
            ViewData["ResName"]      = new SelectList(_context.Resource, "ResName", "ResName"); //
            //------------------------ Список связанных полей ----------------------------------//

            //if (Order != null)
            //// Сохраняем все изменения загруженного списка --------------------------------------------------------//
            //{
            //    foreach (var item in Order)
            //    {
            //        _context.Attach(item).State = EntityState.Modified;
            //        //_context.Orders.Update(item);
            //        await _context.SaveChangesAsync();
            //    }
            //}
            //// Сохраняем все изменения загруженного списка --------------------------------------------------------//

            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//       "кВт.ч"
            recalcSheetf(id);
            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//

            // Подчиненная таблица строк Order -------------------------------------------------//

            if (_context.Orders != null)                                                        //
            {
                //OrderList = await _context.Orders.ToListAsync();                              //
                if (!Sheetf.OverLimit)
                {
                    var readOrder = await _context.Orders.Include(o => o.Sheetf)
                    .Where(o => o.sheetfId == id && !o.OverLimit)
                    .ToListAsync();
                    if (readOrder != null)
                    {
                        Order = readOrder;
                    }
                }
                else
                {
                    var readOrder = await _context.Orders.Include(o => o.Sheetf)
                    .Where(o => o.sheetfId == id)
                    //.Where(o => o.sheetfId == id)
                    .ToListAsync();

                    if (readOrder != null)
                    {
                        Order = readOrder;
                    }
                }

            }
            //
            // Подчиненная таблица строк Order -------------------------------------------------//
            // Загрузка итога для более выразительного форматирования таблицы ------------------//
            var oi = await _context.Sheetfs
                .Where(s => s.Id == Sheetf.Id)
                .ToListAsync();
            if (oi != null)
            {
                OrderItog = oi;
            }
            return Page();
        }

        public void recalcSheetf(long? id)
        {
            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//       "кВт.ч"
            // При асинхронном подходе - отрабатывает исключение конкурентных записей в разных потоках ПОЭТОМУ ВЫЗОВ фунцкии БЕЗ АСИНХРОННЫХ !!!
            Sheetf.ProductCount = _context.Orders.Where(o =>
                o.sheetfId == id &&
                o.ProductEdIzm == Sheetf.ProductEdIzm)
                .Sum(o => o.ProductCount);
            Sheetf.ProductStoim = _context.Orders.Where(o => o.sheetfId == id)
                .Sum(o => o.ProductStoim);
            Sheetf.SumNalog = _context.Orders.Where(o => o.sheetfId == id)
                .Sum(o => o.SumNalog);
            Sheetf.SumProductNalog = _context.Orders.Where(o => o.sheetfId == id)
                .Sum(o => o.SumProductNalog);
            if (Sheetf.ProductCount != 0)
            {
                Sheetf.ProductTarif = Convert.ToDouble(Sheetf.ProductStoim) / Sheetf.ProductCount;
            }
            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//

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

            // Надо достать те ордера которые в html были модифицированы и сохранить изменения ----------------------------------//
            //var countOrders = Order.Count;
            //for (int i = 0; i < countOrders; i++)
            //{
            //    _context.Attach(Order[i]).State = EntityState.Modified;
            //    //_context.Orders.Update(Order[i]);
            //
            //    try
            //    {
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!OrderExists(Order[i].Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //}
            // Надо достать те ордера которые в html были модифицированы и сохранить изменения ----------------------------------//

            if (Order != null)
            // Сохраняем все изменения загруженного списка --------------------------------------------------------//
            {
                foreach (var item in Order)
                {
                    //Для исключения ошибки в расчетах при снятии признака Превышены лимиты обнуляем количество в строках лимитов --------------------------ВАЖНО !-------!
                    if (!Sheetf.OverLimit && item.OverLimit)
                    {
                        item.ProductCount = 0;
                    }
                    //Для исключения ошибки в расчетах при снятии признака Превышены лимиты обнуляем количество в строках лимитов --------------------------ВАЖНО !-------!

                    _context.Attach(item).State = EntityState.Modified;
                    //_context.Orders.Update(item);
                    try
                    {
                        await _context.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!OrderExists(item.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            // Сохраняем все изменения загруженного списка --------------------------------------------------------//

            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//       "кВт.ч"
            recalcSheetf(Sheetf.Id);
            // Пересчет значений из таблицы Orders в поля Sheetfs ------------------------------//

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
        private bool OrderExists(long id)
        {
            return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
