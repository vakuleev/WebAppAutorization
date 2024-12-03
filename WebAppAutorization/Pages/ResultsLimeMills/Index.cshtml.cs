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

namespace WebAppAutorization.Pages.ResultsLimeMills
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        public string _dateFiltrStart;
        public string _dateFiltrEnd;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public string _messageString { get; set; } = default!;
        public IList<ResultsLimeMill> ResultsLimeMills { get; set; } = default!;

        public IndexModel(
               UserManager<User> userManager,
               WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            curUser = new User();
            ResultsLimeMills = new List<ResultsLimeMill>();
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

            if (_context.ResultsLimeMills != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                ResultsLimeMills = await _context.ResultsLimeMills.Where(
                    s => s.DateTrial >= curUser.DateFiltrStart &&
                         s.DateTrial <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateTrial)
                    .ThenBy(s => s.TimeTrial)
                    .ToListAsync();
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
                currentUser.DateFiltrEnd   = curUser.DateFiltrEnd;

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
                _dateFiltrEnd = currentUser.DateFiltrEnd.Value.ToShortDateString();

            }
            var MessageString = "Ведется работа по реализации выгрузки данных в Excel ! ConvertToExcelClosedXML ";
            _messageString = MessageString;

            //await GetOperationControls();
            if (_context.ResultsLimeMills != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                ResultsLimeMills = await _context.ResultsLimeMills.Where(
                    s => s.DateTrial >= curUser.DateFiltrStart &&
                         s.DateTrial <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateTrial)
                    .ThenBy(s => s.TimeTrial)
                    //.ThenBy(s => s.Agent)
                    .ToListAsync();
            }
            //                                          ВНИМАНИЕ - данный путь верен для локальной отладки,
            //                                          в случае запуска на веб сервере IIS путь размещения
            //                                          файлов шаблонов берется с сервера независимо от клиента !!!
            try
            {
                using (XLWorkbook workbook = new XLWorkbook("C:\\APP.IIS\\gns-au.net\\Shablons\\ResultsLimeMills.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook("D:\\APP.IIS\\gns-au.net\\Shablons\\ResultsLimeMills.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook())
                {
                    //Операц_контроль_материалов
                    var worksheet = workbook.Worksheet("OperControl");
                    if (worksheet == null)
                    {
                        worksheet = workbook.Worksheets.Add("OperControl");
                    }

                    //нумерация строк/столбцов начинается с индекса 1 (не 0)

                    int rowCur = 10;  // пропускаем в шаблоне строки заголовка формы до позиции 10 на основе визуального оформления шаблона
                    int maxCol = 13;
                    DateTime _dtPrevious = DateTime.MinValue; 
                    foreach (var ResultsLimeMill in ResultsLimeMills)
                    {
                        //rowCur++;
                        //кто НЕ понимает зачем индекс курсора строки с префиксным инкрементом заменяет отдельную с постфиксным инкрементом - ТОМУ ВООБЩЕ ТУТ НЕЧЕГО ДЕЛАТЬ :))
                        // Делаем вставку строки и заполняем её значениями
                        //worksheet.Row(++rowCur).InsertRowsAbove(1); // при вставке ячейки обрамленые рамкой
                        worksheet.Row(++rowCur).InsertRowsBelow(1);   // при вставке ячейки не обрамлены рамкой
                        if (ResultsLimeMill.DateTrial == _dtPrevious)
                        {// При повторной дате пропускаем заполнение даты поля в таблице для улучшения восприятия визуализации 
                            ResultsLimeMill.DateTrial = null; 
                        }
                        else
                        {
                            _dtPrevious = (DateTime)ResultsLimeMill.DateTrial;
                            worksheet.Cell(rowCur, 1).Value = ResultsLimeMill.DateTrial;
                        }
                        worksheet.Cell(rowCur, 2).Value = ResultsLimeMill.TimeTrial;
                        worksheet.Cell(rowCur, 3).Value = ResultsLimeMill.Agent;
                        worksheet.Cell(rowCur, 4).Value = ResultsLimeMill.DateLimeOnManufakt;
                        worksheet.Cell(rowCur, 5).Value = ResultsLimeMill.Sito200;
                        worksheet.Cell(rowCur, 6).Value = ResultsLimeMill.Sito80;
                        worksheet.Cell(rowCur, 7).Value = ResultsLimeMill.ActiveLime;
                        worksheet.Cell(rowCur, 8).Value = ResultsLimeMill.Entalpya;
                        worksheet.Cell(rowCur, 9).Value = ResultsLimeMill.SandProc;
                        worksheet.Cell(rowCur, 10).Value = ResultsLimeMill.LimeMn;
                        worksheet.Cell(rowCur, 11).Value = ResultsLimeMill.SandMn;
                        worksheet.Cell(rowCur, 12).Value = ResultsLimeMill.LimeMnK;
                        worksheet.Cell(rowCur, 13).Value = ResultsLimeMill.SandMnK;

                        //------------------- Устанавливаем границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\
                        worksheet.Cell(rowCur, 1).Style.Border.SetLeftBorder(XLBorderStyleValues.Medium);

                        for (int i = 1; i <= maxCol; i++)
                        {
                            if (ResultsLimeMill.DateTrial != null)       // Если дата не определена, то не выводим обрамление
                            {
                                worksheet.Cell(rowCur, i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                            }
                            // Устанавливаем более толстые линиии для выделения разделов согласно шаблона
                            if (i == 1 || i == 4 || i == 6 || i == 7 || i == 8 || i == 9 || i == 11) 
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
                            FileDownloadName = $"ResultsLimeMills_{DTBetween}.xlsx"
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
