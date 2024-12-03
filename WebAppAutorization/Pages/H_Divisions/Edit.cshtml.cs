using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_Divisions
{
    [Authorize]
    [Authorize(Policy = "ХАБ Дивизионы")]

    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public H_object _foundDubl { get; set; } = default!;
        public S_Division_info S_Division_info { get; set; }
        public S_object_info _S_object_info { get; set; }
        public IList<H_object> H_object { get; set; }

        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            //id_factory_return = id_factory;
        }

        [BindProperty]
        public H_object ObjectAdd { get; set; } = default!;

        //[BindProperty]
        //public int id_division_return { get; set; } = default;

        [BindProperty]
        public int id_factory_return { get; set; } = default;

        [BindProperty]
        public H_Division H_Division { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id, int id_factory)
        {
            if (id_factory != 0){
                id_factory_return = id_factory;
            }
            if (id == null || _context.H_Division == null)
            {
                return NotFound();
            }

            var h_division =  await _context.H_Division.FirstOrDefaultAsync(m => m.id_division == id);
            if (h_division == null)
            {
                return NotFound();
            }
            H_Division = h_division;


            //------------------------ Список связанных полей ----------------------------------//
            //ViewData["prefix"] = new SelectList(_context.H_Factory, "name_division", "name_division").OrderBy(d => d.Text);        //
            //ViewData["name_division"] = new SelectList(_context.H_Division, "name_division", "name_division").OrderBy(d => d.Text);        //
            //------------------------ Список связанных полей ----------------------------------//

            //var nv = ViewData;

            //Подгружаем последнюю связанную запись сателита к Division ------------------------------------------------------------------------------------//
            var s_division_info = await _context.S_Division_infos.OrderBy(s => s.load_dttm).LastOrDefaultAsync(m => m.id_division == H_Division.id_division);
            if (s_division_info != null)
            {
                S_Division_info = s_division_info;
                //return NotFound();
            }
            //Подгружаем последнюю связанную запись сателита к Division ------------------------------------------------------------------------------------//


            // Формируем список h_object принадлежащих H_Division через промежуточную таблицу I_Division_objects по id ------------------------//
            var h_object = await _context.H_object.Where(u => u.I_division_objects.Any(c => c.id_division == id))
                //Сортируем для удобного вывода поиска
                .OrderBy(u => u.name_object)
                .ToListAsync();
            if (h_object == null)
            {
                return NotFound();
            }
            H_object = h_object;
            // Формируем список h_object принадлежащих H_Division через промежуточную таблицу I_Division_objects по id ------------------------//



            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var i = 0;
                i++;
                return Page();
            }

            //string _prefix = H_Division.prefix;
            _context.Attach(H_Division).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!H_DivisionExists(H_Division.id_division))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            if (id_factory_return != 0) // Возвращаемся на редактирование Factory и List<Division>
            {
                return Redirect($"/H_Factorys/Edit?id={id_factory_return}");
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }

        [HttpPost]
        //<IActionResult>
        public async Task<IActionResult> OnPostDivisionAddObject(int id_division)
        {
            //Забираем id_division из переданного через ViewData в поле DivisionAdd.name_division
            //int id_division = Convert.ToInt32(DivisionAdd.name_division);

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            //    проверка на наличие дубликата по имени -------------------------------------------
            var foundDubl = await _context.H_object.FirstOrDefaultAsync(f => f.name_object == ObjectAdd.name_object && f.prefix == H_Division.name_division);

            if (foundDubl != null)
            {
                _foundDubl = foundDubl;//await _context.H_Division.FirstOrDefaultAsync(d => d.id_division == id_division);
                await OnGetAsync(id_division, id_factory_return);
                return Page();
            }
            else
            {
                // Процедура копирования либо из справочника либо поле ввода пользователем
                // 1) Добавляем в основную таблицу Object prefix и наименование
                var curDivision = await _context.H_Division.FirstOrDefaultAsync(f => f.id_division == id_division);
                if (curDivision != null)
                {
                    // Определяем по текущему H_Division prefix для добавленного H_object
                    //ObjectAdd.prefix = curDivision.name_division;//Головной родитель
                    ObjectAdd.prefix = curDivision.prefix;
                }
                _context.H_object.Add(ObjectAdd);
                await _context.SaveChangesAsync();

                var lastObject = await _context.H_object.OrderBy(s => s.id_object).LastAsync();
                int id_object  = lastObject.id_object;
                // По индексу lastDivision.id_division добавляем Сателит для DivisionAdd в таблицу S_division_info
                //TODO - Необходимо в форме добавить кнопку добавления сателлита S_object_info
                //_S_object_info = new S_object_info
                //{
                //    id_object = id_object,
                //    description = $" {id_object} нужно заполнить !",
                //    load_dttm = DateTime.Now,
                //    id_source = 1
                //};
                //_context.S_object_infos.Add(_S_object_info);

                // 2) В таблицу связей добавляем индексы один ко многим
                var addI_Division_Object = new I_division_object();
                addI_Division_Object.id_division = id_division;
                addI_Division_Object.id_object   = id_object;
                await _context.I_division_objects.AddAsync(addI_Division_Object);
                await _context.SaveChangesAsync();
            }
            // Обновляем страницу
            await OnGetAsync(id_division, id_factory_return);

            return Page();

            //H_Factorys/Edit?id=1
            //string path = $"H_Factorys/Edit?id={id}";
            //return RedirectToPage(path);
        }


        private bool H_DivisionExists(int id)
        {
          return (_context.H_Division?.Any(e => e.id_division == id)).GetValueOrDefault();
        }
    }
}
