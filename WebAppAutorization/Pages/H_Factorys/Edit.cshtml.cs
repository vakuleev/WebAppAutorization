using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.ISData;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Pages.H_Factorys
{
    [Authorize]
    [Authorize(Policy = "ХАБ Фабрики")]
    public class EditModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public H_Division _foundDubl { get; set; } = default!;
        //public S_Division_info _S_Division_info { get; set; } = default!;
        public EditModel(WebAppAutorization.Data.gnsDbContext context)
        {
            _context      = context;
            //H_Division    = new List<H_Division>();
            //H_DivisionAll = new List<H_Division>();
            //DivisionAdd = new H_Division();
            //H_Factory = new H_Factory();
            //S_Factory_info = new S_Factory_info();
        }

        [BindProperty]
        public S_Factory_info S_Factory_info { get; set; } = new S_Factory_info();

        [BindProperty]
        public H_Division DivisionAdd { get; set; } = default!;
        [BindProperty]
        public H_Factory H_Factory { get; set; } = default!;
        [BindProperty]
        public IList<H_Division> H_Division { get; set; } = default!;
        [BindProperty]
        public S_Factory_info SatelitAdd { get; set; }
        //public S_Factory_info SatelitAdd { get; private set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _context.H_Factory == null)
            {
                return NotFound();
            }

            var h_factory =  await _context.H_Factory.FirstOrDefaultAsync(m => m.id_factory == id);
            if (h_factory == null)
            {
                return NotFound();
            }
            H_Factory = h_factory;

            //------------------------ Список связанных полей ----------------------------------//
            //ViewData["name_division"] = new SelectList(_context.H_Division, "name_division", "name_division").OrderBy(d=> d.Text);        //
            //------------------------ Список связанных полей ----------------------------------//

            //var nv = ViewData;

            //Подгружаем последнюю связанную запись сателита к Factory ------------------------------------------------------------------------------------//
            var s_factory_info = await _context.S_Factory_infos.OrderBy(s => s.load_dttm).LastOrDefaultAsync(m => m.id_factory == H_Factory.id_factory);
            if (s_factory_info != null)
            {
                S_Factory_info = s_factory_info;
                //S_Factory_info.id_factory = H_Factory.id_factory;
            }
            else
            {
                S_Factory_info = new S_Factory_info();
            }

            //Подгружаем последнюю связанную запись сателита к Factory ------------------------------------------------------------------------------------//

            // Формируем список divisions принадлежащих H_Factory через промежуточную таблицу I_Factory_Divisions по id ------------------------//
            var h_divisions = await _context.H_Division.Where(u => u.I_Factory_Divisions.Any(c => c.id_factory == id))
                //Сортируем для удобного вывода поиска
                .OrderBy(u => u.name_division)
                .ToListAsync();
            if (h_divisions == null)
            {
                return NotFound();
            }
            H_Division = h_divisions;
            // Формируем список divisions принадлежащих H_Factory через промежуточную таблицу I_Factory_Divisions по id ------------------------\\

            return Page();
        }

        [HttpPost]
        //<IActionResult>
        public async Task<IActionResult> OnPostFactoryAddDivision(int id_factory)
        {
            //Забираем id_division из переданного через ViewData в поле DivisionAdd.name_division
            //int id_division = Convert.ToInt32(DivisionAdd.name_division);

            //Определяем наличие дубликата для контроля данных вводимых ПОЛЬЗОВАТЕЛЕМ
            //    проверка на наличие дубликата по имени -------------------------------------------
            var foundDubl  = await _context.H_Division.FirstOrDefaultAsync(f => f.name_division== DivisionAdd.name_division && f.prefix == H_Factory.name_factory);

            if (foundDubl != null)
            {
                _foundDubl = foundDubl;//await _context.H_Division.FirstOrDefaultAsync(d => d.id_division == id_division);
                await OnGetAsync(id_factory);
                return Page();
            }
            else
            {
                // Процедура копирования либо из справочника либо поле ввода пользователем
                // 1) Добавляем в основную таблицу Division prefix и наименование
                var curFactory  = await _context.H_Factory.FirstOrDefaultAsync(f => f.id_factory == id_factory);
                if (curFactory != null)
                {
                    // Определяем по текущему H_Factory prefix для добавленного H_Division
                    DivisionAdd.prefix = curFactory.name_factory;
                }
                _context.H_Division.Add(DivisionAdd);
                await _context.SaveChangesAsync();

                var lastDivision   = await _context.H_Division.OrderBy(s => s.id_division).LastAsync();
                int id_division = lastDivision.id_division;
                // По индексу lastDivision.id_division добавляем Сателит для DivisionAdd в таблицу S_division_info
                //_S_Division_info = new S_Division_info {
                //                                           id_division = id_division,
                //                                           description = $" {id_division} нужно заполнить !",
                //                                           load_dttm   = DateTime.Now,
                //                                           id_source   = 1
                //                                       };
                //_context.S_Division_infos.Add(_S_Division_info);

                // 2) В таблицу связей добавляем индексы один ко многим
                var addI_Factory_Division = new I_Factory_Division();
                addI_Factory_Division.id_division = id_division;
                addI_Factory_Division.id_factory  = id_factory;
                await _context.I_Factory_Divisions.AddAsync(addI_Factory_Division);
                await _context.SaveChangesAsync();
            }
            // Обновляем страницу
            await OnGetAsync(id_factory);

            return Page();

            //H_Factorys/Edit?id=1
            //string path = $"H_Factorys/Edit?id={id}";
            //return RedirectToPage(path);
        }

        public async Task<IActionResult> OnPostFactoryAddSatelit(int id_factory)
        {
            //- поэтому нужно  создавать перед сохранением локольный объект s_factory_info

            if (S_Factory_info.Status)
            {
                //var s_factory_info = await _context.S_Factory_infos.OrderBy(s => s.load_dttm).LastOrDefaultAsync(m => m.id_factory == H_Factory.id_factory);
                //if (s_factory_info != null)
                //{
                //    s_factory_info.Status      = S_Factory_info.Status;
                //    s_factory_info.description = S_Factory_info.description;
                //    s_factory_info.adress      = S_Factory_info.adress;
                //
                //    //S_Factory_info.id_factory = id_factory;
                //    //_context.Attach(S_Factory_info).State = EntityState.Modified;
                //    //_context.S_Factory_infos..Update(S_Factory_info);
                //    //_context.S_Factory_infos.Update(S_Factory_info);// (S_Factory_info);
                //    //_context.S_Factory_infos.Update(s_factory_info);
                //}
                _context.Attach(S_Factory_info).State = EntityState.Modified;
            }
            else
            {
                SatelitAdd = new S_Factory_info();
                SatelitAdd.load_dttm      = Convert.ToString(DateTime.Now);
                SatelitAdd.id_factory     = id_factory;
                SatelitAdd.description    = S_Factory_info.description;
                SatelitAdd.adress         = S_Factory_info.adress;
                _context.S_Factory_infos.Add(SatelitAdd);
            }

            //await _context.SaveChangesAsync();
            var saved = false;
            while (!saved)
            {
                try
                {
                    await _context.SaveChangesAsync();
                    saved = true;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    //if (!S_Factory_infoExists(S_Factory_info.load_dttm))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}

                    foreach (var entry in ex.Entries)
                    {
                        if (entry.Entity is S_Factory_info)
                        {
                            var proposedValues = entry.CurrentValues;
                            var databaseValues = entry.GetDatabaseValues();

                            foreach (var property in proposedValues.Properties)
                            {
                                var proposedValue = proposedValues[property];
                                if (databaseValues != null)
                                {
                                    var databaseValue = databaseValues[property];
                                }

                                // TODO: decide which value should be written to database
                                // proposedValues[property] = <value to be saved>;
                                // S_Factory_info.description = S_Factory_info.description;
                                // S_Factory_info.adress = S_Factory_info.adress;
                                if (property.Name == "description")
                                {
                                    proposedValues[property.Name] = S_Factory_info.description;
                                }
                                if (property.Name == "adress")
                                {
                                    proposedValues[property.Name] = S_Factory_info.adress;
                                }
                            }
                            //databaseValues
                            // Refresh original values to bypass next concurrency check
                            if (proposedValues != null)
                            {
                                entry.OriginalValues.SetValues(databaseValues);
                                //entry.OriginalValues.SetValues(proposedValues);
                            }
                        }
                        else
                        {
                            throw new NotSupportedException(
                                "Не знаю, как обрабатывать конфликты параллелизма для "
                                + entry.Metadata.Name);
                        }
                    }
                }
            }

            S_Factory_info.Status = false;

            await OnGetAsync(id_factory);

            return Page();

            //H_Factorys/Edit?id=1
            //string path = $"H_Factorys/Edit?id={id_factory}";
            //return RedirectToPage(path);
        }

        [HttpPost]
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //var str_key = H_Factory.load_dttm;
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            _context.Attach(H_Factory).State      = EntityState.Modified;
            //_context.Attach(S_Factory_info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!H_FactoryExists(H_Factory.id_factory))
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

        private bool H_FactoryExists(int id)
        {
          return (_context.H_Factory?.Any(e => e.id_factory == id)).GetValueOrDefault();
        }
        private bool S_Factory_infoExists(string load_dttm)
        {
            return (_context.S_Factory_infos?.Any(e => e.load_dttm == load_dttm)).GetValueOrDefault();
        }
    }
}
