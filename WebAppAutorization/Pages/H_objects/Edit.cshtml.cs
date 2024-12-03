using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.ISData;

namespace WebAppAutorization.Pages.H_objects
{
    [Authorize]
    [Authorize(Policy = "ХАБ Объекты")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public H_eemp _foundDubl { get; set; } = default!;

        public IList<H_eemp> H_eemp { get; set; }
        public S_object_info _S_object_info { get; set; }
        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public H_eemp EempAdd { get; set; } = default!;
        [BindProperty]
        public int id_factory_return { get; set; } = default;
        [BindProperty]
        public int id_division_return { get; set; } = default;
        [BindProperty]
        public H_object H_object { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id, int id_division, int id_factory)
        {
            if (id_division != 0)
            {
                id_division_return = id_division;
                id_factory_return = id_factory;
            }
            if (id == null || _context.H_object == null)
            {
                return NotFound();
            }

            var h_object =  await _context.H_object.FirstOrDefaultAsync(m => m.id_object == id);
            if (h_object == null)
            {
                return NotFound();
            }
            H_object = h_object;

            //Подгружаем последнюю связанную запись сателита к object ------------------------------------------------------------------------------------//
            var s_object_info = await _context.S_object_infos.OrderBy(s => s.load_dttm).LastOrDefaultAsync(m => m.id_object == H_object.id_object);
            if (s_object_info != null)
            {
                _S_object_info = s_object_info;
                //return NotFound();
            }
            //Подгружаем последнюю связанную запись сателита к object ------------------------------------------------------------------------------------//


            // Формируем список h_eemp принадлежащих H_object через промежуточную таблицу I_object_eemps по id ------------------------//
            var h_eemp = await _context.H_eemp.Where(u => u.I_object_eemps.Any(c => c.id_object == id))
                //Сортируем для удобного вывода поиска
                .OrderBy(u => u.name_point)
                .ToListAsync();
            if (h_eemp == null)
            {
                return NotFound();
            }
            H_eemp = h_eemp;
            // Формируем список h_eemp принадлежащих H_object через промежуточную таблицу I_object_eemps по id ------------------------//


            return Page();
        }
        [HttpPost]
        //<IActionResult>
        public async Task<IActionResult> OnPostObjectAddEemp(int id_object)
        {
            //Забираем id_object из переданного через ViewData в поле ObjectAdd.name_object
            //int id_object = Convert.ToInt32(ObjectAdd.name_object);

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            //    проверка на наличие дубликата по имени -------------------------------------------
            var foundDubl = await _context.H_eemp.FirstOrDefaultAsync(f => f.name_point == EempAdd.name_point && f.prefix == H_object.name_object);

            if (foundDubl != null)
            {
                _foundDubl = foundDubl;//await _context.H_Division.FirstOrDefaultAsync(d => d.id_division == id_division);
                await OnGetAsync(id_object, id_division_return, id_factory_return);
                return Page();
            }
            else
            {
                // Процедура копирования либо из справочника либо поле ввода пользователем
                // 1) Добавляем в основную таблицу Object prefix и наименование
                var curObject = await _context.H_object.FirstOrDefaultAsync(f => f.id_object == id_object);
                if (curObject != null)
                {
                    // Определяем по текущему H_Division prefix для добавленного H_object
                    //ObjectAdd.prefix = curDivision.name_division;//Головной родитель
                    EempAdd.prefix = curObject.prefix;
                }
                _context.H_eemp.Add(EempAdd);
                await _context.SaveChangesAsync();

                var lastEemp = await _context.H_eemp.OrderBy(s => s.id_eemp).LastAsync();
                int id_eemp = lastEemp.id_eemp;
                // По индексу lastDivision.id_division добавляем Сателит для EempAdd в таблицу _S_eemp_info
                //TODO - Необходимо в форме добавить кнопку добавления сателлита _S_eemp_info
                //_S_eemp_info = new _S_eemp_info
                //{
                //    id_eemp = id_eemp,
                //    description = $" {id_eemp} нужно заполнить !",
                //    load_dttm = DateTime.Now,
                //    id_source = 1
                //};
                //_context.S_eemp_infos.Add(_S_eemp_info);

                // 2) В таблицу связей добавляем индексы один ко многим
                var addI_Object_Eemp = new I_object_eemp();
                addI_Object_Eemp.id_object = id_object;
                addI_Object_Eemp.id_eemp = id_eemp;
                await _context.I_object_eemps.AddAsync(addI_Object_Eemp);
                await _context.SaveChangesAsync();
            }
            // Обновляем страницу
            await OnGetAsync(id_object, id_division_return, id_factory_return);

            return Page();

            //H_Factorys/Edit?id=1
            //string path = $"H_Factorys/Edit?id={id}";
            //return RedirectToPage(path);
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(H_object).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!H_objectExists(H_object.id_object))
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

        private bool H_objectExists(int id)
        {
          return (_context.H_object?.Any(e => e.id_object == id)).GetValueOrDefault();
        }
    }
}
