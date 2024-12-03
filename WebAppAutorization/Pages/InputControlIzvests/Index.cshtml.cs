﻿using System;
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

namespace WebAppAutorization.Pages.InputControlIzvests
{
    [Authorize]
    [Authorize(Policy = "Входной контроль извести")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        public string _dateFiltrStart;
        public string _dateFiltrEnd;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public string _messageString { get; set; } = default!;
        public IList<InputControlIzvest> InputControlIzvests { get; set; } = default!;

        public IndexModel(
               UserManager<User> userManager,
               WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            curUser = new User();
            InputControlIzvests = new List<InputControlIzvest>();
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

            if (_context.InputControlIzvests != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                InputControlIzvests = await _context.InputControlIzvests.Where(
                    s => s.DateReceipt >= curUser.DateFiltrStart &&
                         s.DateReceipt <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateReceipt).ToListAsync();
            }
        }
        [HttpPost]
        public async Task<IActionResult> OnPostChangeGoFiltr()
        {
            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                currentUser.DateFiltrStart = curUser.DateFiltrStart;
                currentUser.DateFiltrEnd = curUser.DateFiltrEnd;

                // Сохраняем параметры фильтра текущего пользователя
                var updateError = await _userManager.UpdateAsync(currentUser);
            }

            //DataFiltr.Id = Id;
            //_context.Attach(DataFiltr).State = EntityState.Modified;
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostConvertToExcelClosedXML(long Id)
        {
            // Сохраняем параметры фильтра текущего пользователя
            await OnPostChangeGoFiltr();

            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                _dateFiltrStart = currentUser.DateFiltrStart.Value.ToShortDateString();
                _dateFiltrEnd   = currentUser.DateFiltrEnd.Value.ToShortDateString();

            }
            var MessageString = "Ведется работа по реализации выгрузки данных в Excel ! ConvertToExcelClosedXML ";
            _messageString = MessageString;

            //await GetOperationControls();
            if (_context.InputControlIzvests != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                InputControlIzvests = await _context.InputControlIzvests.Where(
                    s => s.DateReceipt >= curUser.DateFiltrStart &&
                         s.DateReceipt <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateReceipt)
                    //.ThenBy(s => s.Agent)
                    .ToListAsync();
            }
            //                                          ВНИМАНИЕ - данный путь верен для локальной отладки,
            //                                          в случае запуска на веб сервере IIS путь размещения
            //                                          файлов шаблонов берется с сервера независимо от клиента !!!
            try
            {
                using (XLWorkbook workbook = new XLWorkbook("C:\\APP.IIS\\gns-au.net\\Shablons\\InputControlIzvest.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook("D:\\APP.IIS\\gns-au.net\\Shablons\\InputControlIzvest.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook())
                {
                    //Операц_контроль_материалов
                    var worksheet = workbook.Worksheet("OperControl");
                    if (worksheet == null)
                    {
                        worksheet = workbook.Worksheets.Add("OperControl");
                    }

                    //нумерация строк/столбцов начинается с индекса 1 (не 0)

                    int rowCur = 16;  // пропускаем в шаблоне строки заголовка формы до позиции 16 на основе визуального оформления шаблона
                    int maxCol = 7;
                    DateTime _dtPrevious = DateTime.MinValue;
                    foreach (var InputControlIzvest in InputControlIzvests)
                    {
                        //rowCur++;
                        //кто НЕ понимает зачем индекс курсора строки с префиксным инкрементом заменяет отдельную с постфиксным инкрементом - ТОМУ ВООБЩЕ ТУТ НЕЧЕГО ДЕЛАТЬ :))
                        // Делаем вставку строки и заполняем её значениями
                        //worksheet.Row(++rowCur).InsertRowsAbove(1); // при вставке ячейки обрамленые рамкой
                        worksheet.Row(++rowCur).InsertRowsBelow(1);   // при вставке ячейки не обрамлены рамкой
                        worksheet.Cell(rowCur, 1).Value = InputControlIzvest.DateReceipt;
                        worksheet.Cell(rowCur, 2).Value = InputControlIzvest.UnquencheGrains;
                        worksheet.Cell(rowCur, 3).Value = InputControlIzvest.Activity;
                        worksheet.Cell(rowCur, 4).Value = InputControlIzvest.WetBulkDensity;
                        worksheet.Cell(rowCur, 5).Value = InputControlIzvest.ExtinguishingTime;
                        worksheet.Cell(rowCur, 6).Value = InputControlIzvest.ExtinguishingTemperature;
                        worksheet.Cell(rowCur, 7).Value = InputControlIzvest.UniformityVolumeChange;

                        //------------------- Устанавливаем границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\
                        worksheet.Cell(rowCur, 1).Style.Border.SetLeftBorder(XLBorderStyleValues.Medium);

                        for (int i = 1; i <= maxCol; i++)
                        {
                            if (InputControlIzvest.DateReceipt != null)       // Если дата не определена, то не выводим обрамление
                            {
                                worksheet.Cell(rowCur, i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                            }
                            // Устанавливаем более толстые линиии для выделения разделов согласно шаблона
                            if (i == 1 || i == 6)
                            {
                                worksheet.Cell(rowCur, i).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                            }
                            else
                            {
                                worksheet.Cell(rowCur, i).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                            }
                        }
                        worksheet.Cell(rowCur, maxCol).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                    }
                    for (int i = 1; i <= maxCol; i++)
                    {
                        worksheet.Cell(rowCur, i).Style.Border.BottomBorder = XLBorderStyleValues.Medium;
                    }
                    //---------------------------------- границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        stream.Flush();
                        // DTBetween - формирование в имени выгружаемого по шаблону файлу даты диапазона 
                        string DTBetween = _dateFiltrStart + ".." + _dateFiltrEnd;
                        return new FileContentResult(stream.ToArray(),
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                        {
                            //FileDownloadName = $"brands_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                            FileDownloadName = $"InputControlIzvest_{DTBetween}.xlsx"
                        };
                    }
                }
                return Page();
            }
            catch (Exception ex)
            {
                _messageString = _messageString + "Ошибка при экспорте данных в Excel: " + ex.Message;
                return Page();
            }
            finally
            {
                //return Page();
                //return RedirectToPage("./Index");
            }
        }

    }
}
