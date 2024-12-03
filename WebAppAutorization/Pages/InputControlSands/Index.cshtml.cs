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

namespace WebAppAutorization.Pages.InputControlSands
{
    [Authorize]
    [Authorize(Policy = "Входной контроль песка")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;

        public UserManager<User> _userManager;

        public string _dateFiltrStart;
        public string _dateFiltrEnd;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public string _messageString { get; set; } = default!;
        public IList<InputControlSand> InputControlSands { get; set; } = default!;

        public IndexModel(
               UserManager<User> userManager,
               WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            _userManager = userManager;
            curUser = new User();
            InputControlSands = new List<InputControlSand>();
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

            if (_context.InputControlSands != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                InputControlSands = await _context.InputControlSands.Where(
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
            if (_context.InputControlSands != null)
            {
                //IzvestFromSilos = await _context.IzvestFromSilos.OrderBy(s => s.DateTimeTrial).ToListAsync();
                InputControlSands = await _context.InputControlSands.Where(
                    s => s.DateReceipt >= curUser.DateFiltrStart &&
                         s.DateReceipt <= curUser.DateFiltrEnd)
                    .OrderBy(s => s.DateReceipt).ToListAsync();
            }

            //                                          ВНИМАНИЕ - данный путь верен для локальной отладки,
            //                                          в случае запуска на веб сервере IIS путь размещения файлов шаблонов берется с сервера независимо от клиента !!!
            //
            try
            {
                using (XLWorkbook workbook = new XLWorkbook("C:\\APP.IIS\\gns-au.net\\Shablons\\ResultsPortlandCement.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook("D:\\APP.IIS\\gns-au.net\\Shablons\\InputControlSand.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook())
                {
                    //Операц_контроль_материалов
                    var worksheet = workbook.Worksheet("OperControl");
                    if (worksheet == null)
                    {
                        worksheet = workbook.Worksheets.Add("OperControl");
                    }

                    //нумерация строк/столбцов начинается с индекса 1 (не 0)

                    int rowCur  = 18;  // пропускаем в шаблоне строки заголовка формы до позиции 18 на основе визуального оформления шаблона
                    int maxCol  = 6;
                    int _cntTSR = 0;
                    int _cntWS  = 0;
                    int _cntWBD = 0;
                    int _cntCS  = 0;
                    int _cntSM  = 0;
                    decimal? _TotalSandReceived = 0;
                    decimal? _WaterSand         = 0;
                    decimal? _WetBulkDensity    = 0;
                    decimal? _ClaySubstances    = 0;
                    decimal? _SizeModulus       = 0;

                    foreach (var InputControlSand in InputControlSands)
                    {
                        //rowCur++;
                        // Делаем вставку строки и заполняем её знгачениями
                        //worksheet.Row(++rowCur).InsertRowsAbove(1); // при вставке ячейки обрамленые рамкой
                        worksheet.Row(++rowCur).InsertRowsBelow(1);   // при вставке ячейки не обрамлены рамкой
                        worksheet.Cell(rowCur, 1).Value = InputControlSand.DateReceipt;
                        if (InputControlSand.TotalSandReceived != 0 && InputControlSand.TotalSandReceived != null)
                        {
                            worksheet.Cell(rowCur, 2).Value = InputControlSand.TotalSandReceived;
                            _cntTSR++;
                            _TotalSandReceived += InputControlSand.TotalSandReceived;
                        }
                        if (InputControlSand.WaterSand != 0 && InputControlSand.WaterSand != null)
                        {
                            worksheet.Cell(rowCur, 3).Value = InputControlSand.WaterSand;
                            _cntWS++;
                            _WaterSand += InputControlSand.WaterSand;
                        }
                        if (InputControlSand.WetBulkDensity != 0 && InputControlSand.WetBulkDensity != null)
                        {
                            worksheet.Cell(rowCur, 4).Value = InputControlSand.WetBulkDensity;
                            _cntWBD++;
                            _WetBulkDensity += InputControlSand.WetBulkDensity;
                        }
                        if (InputControlSand.ClaySubstances != 0 && InputControlSand.ClaySubstances != null)
                        {
                            worksheet.Cell(rowCur, 5).Value = InputControlSand.ClaySubstances;
                            _cntCS++;
                            _ClaySubstances += InputControlSand.ClaySubstances;
                        }
                        if (InputControlSand.SizeModulus != 0 && InputControlSand.SizeModulus != null)
                        {
                            worksheet.Cell(rowCur, 6).Value = InputControlSand.SizeModulus;
                            _cntSM++;
                            _SizeModulus += InputControlSand.SizeModulus;
                        }

                        //------------------- Устанавливаем границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\
                        worksheet.Cell(rowCur, 1).Style.Border.SetLeftBorder(XLBorderStyleValues.Medium);

                        for (int i = 1; i <= maxCol; i++)
                        {
                            if (InputControlSand.DateReceipt != null)       // Если дата не определена, то не выводим обрамление
                            {
                                worksheet.Cell(rowCur, i).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                            }// Устанавливаем более толстые линиии для выделения разделов согласно шаблона
                            if (i == 0) 
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

                    // Вывод итогов -----------------------------------------------------------------------------------------------------------------\\
                    rowCur++;
                    //worksheet.Row(rowCur).InsertRowsBelow(1); // при вставке ячейки НЕ обрамленые рамкой
                    worksheet.Column(1).Width = 16.5;
                    //worksheet.Cell(rowCur, 1).Value = "Сумма";
                    //worksheet.Cell(rowCur + 1, 1).Value = "Колличество";
                    //worksheet.Cell(rowCur + 2, 1).Value = "Среднее значение";
                    if (_TotalSandReceived != 0)
                    {
                        worksheet.Cell(rowCur    , 2).Value = _TotalSandReceived;
                        //worksheet.Cell(rowCur + 1, 2).Value = _cntTSR;
                        //worksheet.Cell(rowCur + 2, 2).Value = _TotalSandReceived / _cntTSR;
                    }
                    if (_cntWS != 0)
                    {
                        //worksheet.Cell(rowCur    , 3).Value = _WaterSand;
                        //worksheet.Cell(rowCur + 1, 3).Value = _cntWS;
                        worksheet.Cell(rowCur, 3).Value = _WaterSand / _cntWS;
                    }
                    if (_cntWBD != 0)
                    {
                        //worksheet.Cell(rowCur    , 4).Value = _WetBulkDensity;
                        //worksheet.Cell(rowCur + 1, 4).Value = _cntWBD;
                        worksheet.Cell(rowCur, 4).Value = _WetBulkDensity / _cntWBD;
                    }
                    if (_cntCS != 0)
                    {
                        //worksheet.Cell(rowCur    , 5).Value = _ClaySubstances;
                        //worksheet.Cell(rowCur + 1, 5).Value = _cntCS;
                        worksheet.Cell(rowCur, 5).Value = _ClaySubstances / _cntCS;
                    }
                    if (_cntSM != 0)
                    {
                        //worksheet.Cell(rowCur    , 6).Value = _SizeModulus;
                        //worksheet.Cell(rowCur + 1, 6).Value = _cntSM;
                        worksheet.Cell(rowCur, 6).Value = _SizeModulus / _cntSM;
                    }

                    // Вывод итогов -----------------------------------------------------------------------------------------------------------------\\

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
                            FileDownloadName = $"InputControlSand_{DTBetween}.xlsx"
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
