using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Options;
using NuGet.Protocol;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;
//using ClosedXML;
//using XLParser;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
//using DocumentFormat.OpenXml.Office2010.ExcelAc;
//using Microsoft.CodeAnalysis.CodeActions;
//using DocumentFormat.OpenXml;
//using System.Dynamic;
//using Microsoft.Office.Interop.Excel;
//using DocumentFormat.OpenXml.Spreadsheet;
//using Excel = Microsoft.Office.Interop.Excel;
//using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
//using Workbook = DocumentFormat.OpenXml.Spreadsheet.Workbook;
//using Microsoft.Graph;
//using DocumentFormat.OpenXml.Spreadsheet;
//using System.Web;
//using Magnum.FileSystem;
//using DocumentFormat.OpenXml.Wordprocessing;
//using Microsoft.CodeAnalysis.CodeFixes;
//using DocumentFormat.OpenXml.Bibliography;
//using System.Diagnostics;
//using System.Web.HttpResponse;

namespace WebAppAutorization.Pages.OperationControlMaterials
{
    [Authorize]
    [Authorize(Policy = "Операционный контроль сырья")]
    public class IndexModel : PageModel
    {
        private readonly WebAppAutorization.Data.gnsDbContext _context;
        public IList<IzvestFromSilos> IzvestFromSilos { get; set; } = default!;
        public IList<OperationControl> OperationControls { get; set; } = default!;
        public string vDateTrial { get; set; } = default!;
        //public DateTime DateStart { get; set; } = default!;
        //public DateTime DateEnd { get; set; } = default!;

        public UserManager<User> _userManager;

        public string _dateFiltrStart;
        public string _dateFiltrEnd;

        [BindProperty]
        public User curUser { get; set; } = default!;
        public Company curCompany { get; set; } = default!;
        public IList<Company> Company { get; set; } = default!;
        //public DataFiltr DataFiltr { get; set; } = default!;
        public string _connectionString { get; set; } = default!;
        public string _messageString { get; set; } = default!;
       public IndexModel(
              UserManager<User> userManager,
              WebAppAutorization.Data.gnsDbContext context)
        {
            _context = context;
            // -------- ВНИМАНИЕ ИСПОЛЬЗУЕТСЯ подключение без возможностей Entity Framework Core для формирования виртуальной таблицы из 3-х таблиц
            _connectionString = _context.Database.GetConnectionString();
            // -------- ВНИМАНИЕ ИСПОЛЬЗУЕТСЯ подключение без возможностей Entity Framework Core для формирования виртуальной таблицы из 3-х таблиц

            OperationControls = new List<OperationControl>();

            _userManager = userManager;
            Company = new List<Company>();
            curUser = new User();

        }

        public async Task GetOperationControls()
        //public IList<OperationControl> GetOperationControls()
        {
            var _operationControls = new List<OperationControl>();

            string filtrStart, filtrEnd;

            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                //currentUser.DateFiltrStart = curUser.DateFiltrStart;
                //currentUser.DateFiltrEnd = curUser.DateFiltrEnd;

                // Сохраняем параметры фильтра текущего пользователя
                //var updateError = _userManager.UpdateAsync(currentUser);
                filtrStart = currentUser.DateFiltrStart.Value.ToShortDateString();
                filtrEnd   = currentUser.DateFiltrEnd.Value.ToShortDateString();
            } else
            {
                filtrStart = DateTime.Now.ToShortDateString();
                filtrEnd   = DateTime.Now.ToShortDateString();
            }

            //var datafiltr = _context.DataFiltrs.FirstOrDefault(m => m.Id == 1);
            //DataFiltr  = datafiltr;

            //DateStart  = DataFiltr.DateFiltrStart.Value;
            //DateEnd    = DataFiltr.DateFiltrEnd.Value;
            //filtrStart = datafiltr.DateFiltrStart.Value.ToShortDateString();
            //filtrEnd   = datafiltr.DateFiltrEnd.Value.ToShortDateString();

            //filtrStart = datafiltr.DateFiltrStart.Value.ToString();
            //filtrEnd = datafiltr.DateFiltrEnd.Value.ToString();

            //select isnull(datalab.IzvestFromSiloss.DateTimeTrial, isnull(datalab.SandSludgePools.DateTimeTrial, datalab.SandSludgeMills.DateTimeTrial)) DTT, 
            //datalab.IzvestFromSiloss.DateTimeTrial, datalab.SandSludgePools.DateTimeTrial,  datalab.SandSludgeMills.DateTimeTrial
            //from datalab.IzvestFromSiloss
            //     full join datalab.SandSludgePools on datalab.IzvestFromSiloss.DateTimeTrial = datalab.SandSludgePools.DateTimeTrial
            //	   full join datalab.SandSludgeMills on datalab.SandSludgePools.DateTimeTrial = datalab.SandSludgeMills.DateTimeTrial	   
            //	   order by DTT

            //-------------------------- Виртуальная сводная таблица ОПЕРАЦИОННЫЙ КОНТРОЛЬ МАТЕРИАЛОВ -------------------------------------
            using (SqlConnection connectionCommentstop = new SqlConnection(_connectionString))
            {
                connectionCommentstop.Open();
                string sql = "SET DATEFORMAT dmy ; " +
                  "SELECT " +                                           // reader(index) //Проставляем индексы для облегчения внимания
                     "isnull(datalab.IzvestFromSiloss.DateTrial, " +               //0
                     "isnull(datalab.SandSludgePools.DateTrial, datalab.SandSludgeMills.DateTrial)) dt, " +

                     "isnull(datalab.IzvestFromSiloss.DateTimeTrial, " +           //1
                     "isnull(datalab.SandSludgePools.DateTimeTrial, datalab.SandSludgeMills.DateTimeTrial)) dtt, " +

                     "datalab.IzvestFromSiloss.DateTrial, " +                      //2
                     "datalab.IzvestFromSiloss.TimeTrial, " +                      //3
                     "datalab.IzvestFromSiloss.DateTimeTrial, " +                  //4
                     "datalab.IzvestFromSiloss.Enthalpiy, " +                      //5
                     "datalab.IzvestFromSiloss.Activity, " +                       //6
                     "datalab.IzvestFromSiloss.Time, " +                           //7
                     "datalab.IzvestFromSiloss.Temperature, " +                    //8

                     "datalab.SandSludgePools.DateTrial, " +                       //9
                     "datalab.SandSludgePools.TimeTrial, " +                       //10
                     "datalab.SandSludgePools.DateTimeTrial, " +                   //11
                     "datalab.SandSludgePools.NumPool, " +                         //12
                     "datalab.SandSludgePools.Density, " +                         //13
                     "datalab.SandSludgePools.ResidueOnSieve, " +                  //14
                     "datalab.SandSludgePools.GypsumContentSandSlurry, " +         //15

                     "datalab.SandSludgeMills.DateTrial, " +                       //16
                     "datalab.SandSludgeMills.TimeTrial, " +                       //17
                     "datalab.SandSludgeMills.DateTimeTrial, " +                   //18
                     "datalab.SandSludgeMills.NumPool, " +                         //19
                     "datalab.SandSludgeMills.Density, " +                         //20
                     "datalab.SandSludgeMills.ResidueOnSieve, " +                  //21
                     "datalab.SandSludgeMills.DensityReturnSludge, " +             //22

                     "isnull(datalab.IzvestFromSiloss.TimeTrial, " +               //23
                     "isnull(datalab.SandSludgePools.TimeTrial, datalab.SandSludgeMills.TimeTrial)) tt " +

                  " FROM datalab.IzvestFromSiloss " +
                  " FULL JOIN datalab.SandSludgePools on datalab.IzvestFromSiloss.DateTimeTrial = datalab.SandSludgePools.DateTimeTrial " +
                  " FULL JOIN datalab.SandSludgeMills on (datalab.IzvestFromSiloss.DateTimeTrial = datalab.SandSludgeMills.DateTimeTrial) " +
                                                    " OR (datalab.SandSludgePools.DateTimeTrial = datalab.SandSludgeMills.DateTimeTrial) " +
                  " WHERE (datalab.IzvestFromSiloss.DateTrial>='" + filtrStart + "' and datalab.IzvestFromSiloss.DateTrial<='" + filtrEnd + "') " +
                  " OR (datalab.SandSludgePools.DateTrial>='" + filtrStart + "' and datalab.SandSludgePools.DateTrial<='" + filtrEnd + "') " +
                  " OR (datalab.SandSludgeMills.DateTrial>='" + filtrStart + "' and datalab.SandSludgeMills.DateTrial<='" + filtrEnd + "') " +
                  " ORDER BY dt, tt ";
                //"   OR  (SandSludgePools.DateTrial>='@dateStart' and SandSludgePools.DateTrial<='@dateEnd') " +

                //from datalab.IzvestFromSiloss
                //     full join datalab.SandSludgePools on datalab.IzvestFromSiloss.DateTimeTrial = datalab.SandSludgePools.DateTimeTrial
                //	   full join datalab.SandSludgeMills on datalab.SandSludgePools.DateTimeTrial = datalab.SandSludgeMills.DateTimeTrial	   
                //	   order by DTT

                //"FROM dbo.tworkstop " +
                //                    "LEFT join dbo.tcomment on id_comment=tcomment.id " +
                //             "WHERE tworkstop.id_objects=@id_objects " +
                //             "ORDER BY wdate ";
                //string _sql = sql; // - для контроля и отладки
                using (SqlCommand commandCommentstop = new SqlCommand(sql, connectionCommentstop))
                {
                    //------------ПОДСТАНОВКА почему-то некорректно выполняется, ПРИШЛОСЬ ВЫШЕ ВКЛЕИТЬ ВРУЧНУЮ filtrStart,  filtrEnd----------- ;
                    //commandCommentstop.Parameters.AddWithValue("@dateStart", DateStart.ToShortDateString());
                    //commandCommentstop.Parameters.AddWithValue("@dateEnd", DateEnd.ToShortDateString());
                    //------------ПОДСТАНОВКА почему-то некорректно выполняется, ПРИШЛОСЬ ВЫШЕ ВКЛЕИТЬ ВРУЧНУЮ filtrStart,  filtrEnd----------- ;
                    using (SqlDataReader reader = commandCommentstop.ExecuteReader())
                    {
                        string lastDateTrial = "";
                        string vDateTrial    = "";

                        while (reader.Read())
                        {
                            //_countStr++; - // отладка
                            OperationControl Order = new OperationControl();
                            if (lastDateTrial == "" + reader.GetDateTime(0).ToString("d"))
                            {
                                //Пропускаем заполнение даты так как дата такая же
                                //для того чтобы не загромождать тавблицу просмотра повторами даты
                                vDateTrial = "";
                            }
                            else
                            {
                                vDateTrial    = "" + reader.GetDateTime(0).ToString("d");
                                lastDateTrial = vDateTrial;
                            }
                            Order.DateTrial     = vDateTrial;
                            Order.DateTimeTrial = reader.GetString(1);
                            Order.TimeTrial     = reader.GetString(23);
                            // Проверка если данные не null то читаем по индексу значение , если надо конвертируем и присваем в Ордер строки для сохранения
                            // в коллекцию  OperationControls.Add(Order);
                            if (!reader.IsDBNull(5))
                            {
                                Order.Enthalpiy = Convert.ToDecimal(reader.GetValue(5));
                            }
                            if (!reader.IsDBNull(6))
                            {
                                Order.Activity = Convert.ToDecimal(reader.GetValue(6));
                            }
                            if (!reader.IsDBNull(7))
                            {
                                Order.Time = reader.GetString(7);
                            }
                            if (!reader.IsDBNull(8))
                            {
                                Order.Temperature = Convert.ToDecimal(reader.GetValue(8));
                            }
                            if (!reader.IsDBNull(12))
                            {
                                if (reader.GetInt32(12) > 0) Order.NumPool = reader.GetInt32(12);
                            }
                            if (!reader.IsDBNull(13))
                            {
                                Order.Density = Convert.ToDecimal(reader.GetValue(13));
                            }
                            if (!reader.IsDBNull(14))
                            {
                                Order.ResidueOnSieve = Convert.ToDecimal(reader.GetValue(14));
                            }
                            if (!reader.IsDBNull(15))
                            {
                                Order.GypsumContentSandSlurry = Convert.ToDecimal(reader.GetValue(15));
                            }
                            if (!reader.IsDBNull(19))
                            {
                                if (reader.GetInt32(19) > 0) Order.NumPoolM = reader.GetInt32(19);
                            }
                            if (!reader.IsDBNull(20))
                            {
                                Order.DensityM = Convert.ToDecimal(reader.GetValue(20));
                            }
                            if (!reader.IsDBNull(21))
                            {
                                Order.ResidueOnSieveM = Convert.ToDecimal(reader.GetValue(21));
                            }
                            if (!reader.IsDBNull(22))
                            {
                                Order.DensityReturnSludge = Convert.ToDecimal(reader.GetValue(22));
                            }
                            _operationControls.Add(Order);

                            ////C# double <- SQL float            
                        }
                    }
                }
            }

            // ----- ДАННЫЙ ПОДХОД ПОКА НЕ ПОДДЕРЖИВАЕТ full joion в Entity Framework Core --------- ПОЭТОМУ ВЫПОЛНЕНО через SQL ВЫШЕ !!! ---------
            //if (_context.IzvestFromSilos != null)
            //{
            //    //var query = from IzvestFromSilos in _context.IzvestFromSilos
            //    //            join SandSludgeMill in _context.SandSludgeMills on IzvestFromSilos.DateTimeTrial equals SandSludgeMill.DateTimeTrial
            //    //            join SandSludgePool in _context.SandSludgePools on SandSludgeMill.DateTimeTrial equals SandSludgePool.DateTimeTrial
            //    //            where (IzvestFromSilos.DateTrial >= DateStart) && (IzvestFromSilos.DateTrial <= DateEnd)
            //    //            orderby IzvestFromSilos.DateTrial, IzvestFromSilos.TimeTrial
            //    var query = from ifs in _context.IzvestFromSilos
            //                join ssm in _context.SandSludgeMills on ifs.DateTimeTrial equals null  // on ifs.DateTimeTrial equals ssm.DateTimeTrial
            //                join ssp in _context.SandSludgePools on ssm.DateTimeTrial equals null // on ssm.DateTimeTrial equals ssp.DateTimeTrial
            //                where (ifs.DateTrial >= DateStart) && (ifs.DateTrial <= DateEnd)
            //                                orderby ifs.DateTimeTrial
            //                select new
            //                            {
            //                                DateTrial               = ifs.DateTrial,
            //                                TimeTrial               = ifs.TimeTrial,
            //                                DateTimeTrial           = ifs.DateTimeTrial,
            //                                Enthalphy               = ifs.Enthalpiy,
            //                                Activity                = ifs.Activity,
            //                                Time                    = ifs.Time,
            //                                Temperature             = ifs.Temperature,
            //                                NumPool                 = ssp.NumPool,
            //                                Density                 = ssp.Density,
            //                                ResidueOnSieve          = ssp.ResidueOnSieve,
            //                                GypsumContentSandSlurry = ssp.GypsumContentSandSlurry,
            //                                NumPoolM                = ssm.NumPool,
            //                                DensityM                = ssm.Density,
            //                                ResidueOnSieveM         = ssm.ResidueOnSieve,
            //                                DensityReturnSludge     = ssm.DensityReturnSludge
            //                            };
            //    string lastDateTrial = "";
            //    string vDateTrial    = "";
            //    foreach (var Order in query)
            //    {
            //        if (lastDateTrial == Convert.ToString(Order.DateTrial))
            //        {
            //            //Пропускаем заполнение даты так как дата такая же
            //            vDateTrial = "";
            //        }
            //        else
            //        {
            //            vDateTrial    = Convert.ToString(Order.DateTrial);
            //            lastDateTrial = vDateTrial;
            //        }
            //        OperationControls.Add(new OperationControl{
            //            DateTrial               = vDateTrial,
            //            TimeTrial               = Order.TimeTrial,
            //            DateTimeTrial           = Order.DateTimeTrial,
            //            Enthalpiy                = Order.Enthalphy, 
            //            Activity                = Order.Activity,
            //            Time                    = Order.Time,
            //            Temperature             = Order.Temperature,
            //            NumPool                 = Order.NumPool,
            //            Density                 = Order.Density,
            //            ResidueOnSieve          = Order.ResidueOnSieve,
            //            GypsumContentSandSlurry = Order.GypsumContentSandSlurry,
            //            NumPoolM                = Order.NumPoolM,
            //            DensityM                = Order.DensityM,
            //            ResidueOnSieveM         = Order.ResidueOnSieveM,
            //            DensityReturnSludge     = Order.DensityReturnSludge
            //        });
            //    }
            //}

            // ----- ДАННЫЙ ПОДХОД ПОКА НЕ ПОДДЕРЖИВАЕТ full joion в Entity Framework Core --------- ПОЭТОМУ ВЫПОЛНЕНО через SQL ВЫШЕ !!! ---------
            // ПРИМЕР используя Entity Framework Core :
            //    var users = from user in db.Users
            //                join company in db.Companies on user.CompanyId equals company.Id
            //                join country in db.Countries on company.CountryId equals country.Id
            //                select new
            //                {
            //                    Name = user.Name,
            //                    Company = company.Name,
            //                    Age = user.Age,
            //                    Country = country.Name
            //                };
            //foreach (var u in users)
            //    Console.WriteLine($"{u.Name} ({u.Company} - {u.Country}) - {u.Age}");

            //return _operationControls;
            OperationControls = _operationControls;
        }
        public async Task OnGetAsync()
        {
            //OperationControls = GetOperationControls();
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                curUser = currentUser;
                await GetOperationControls();
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

//        [HttpPost]
//
//        public async Task<IActionResult> OnPostConvertToExcelCOM(long Id)
//        {
//            string fileShablon = "D:\\APP.IIS\\gns-au.net\\Shablons\\OperationControlMaterials.xlsx";
//            //string fileShablon = "OperationControlMaterials.xlsx";
//
//            string DTBetween = DataFiltr.DateFiltrStart.Value.Date.ToShortDateString()
//                                + ".." + DataFiltr.DateFiltrEnd.Value.Date.ToShortDateString();
//
//            string filePath = "C:\\APP.IIS\\gns-au.net\\Shablons\\OperationControlMaterials_" + DTBetween + ".xlsx";
//
//            //var MessageString = "Ведется работа по реализации выгрузки данных в Excel ! OnPostConvertToExcell ";
//            //_messageString = MessageString;
//
//            await OnPostChangeGoFiltr(1);
//
//            OperationControls = GetOperationControls();
//
//            // Создаем экземпляр приложения Excel
//            var  excelApp = new Microsoft.Office.Interop.Excel.Application();
//
//            // Добавляем новую рабочую книгу
//            Excel.Workbook workbook = excelApp.Workbooks.Open(fileShablon);
//
//            try
//            {
//                Excel.Worksheet worksheet = workbook.Sheets["OperControl"];
//                int rowCur = 7;  // пропускаем в шаблоне строки заголовка формы до позиции 7
//
//                foreach (var OperationControl in OperationControls)
//                {
//                    rowCur++;
//                    worksheet.Cells[rowCur, 1] = OperationControl.DateTrial;
//                    worksheet.Cells[rowCur, 2] = OperationControl.TimeTrial;
//                    worksheet.Cells[rowCur, 3] = OperationControl.Enthalpiy;
//                    worksheet.Cells[rowCur, 4] = OperationControl.Activity;
//                    worksheet.Cells[rowCur, 5] = OperationControl.Time;
//                    worksheet.Cells[rowCur, 6] = OperationControl.Temperature;
//
//                    worksheet.Cells[rowCur, 7] = OperationControl.NumPool;
//                    worksheet.Cells[rowCur, 8] = OperationControl.Density;
//                    worksheet.Cells[rowCur, 9] = OperationControl.ResidueOnSieve;
//                    worksheet.Cells[rowCur, 12] = OperationControl.GypsumContentSandSlurry;
//
//                    worksheet.Cells[rowCur, 13] = OperationControl.NumPoolM;
//                    worksheet.Cells[rowCur, 14] = OperationControl.DensityM;
//                    worksheet.Cells[rowCur, 15] = OperationControl.ResidueOnSieveM;
//                    worksheet.Cells[rowCur, 18] = OperationControl.DensityReturnSludge;
//                }
//
//                // Сохраняем рабочую книгу
//                workbook.SaveAs(filePath);
//            }
//            catch (Exception ex)
//            {
//                //Console.WriteLine("Ошибка при экспорте данных в Excel: " + ex.Message);
//                var MessageString = "Ошибка при экспорте данных в Excel: " + ex.Message;
//                _messageString = MessageString;
//            }
//            finally
//            {
//                // Закрываем приложение Excel
//                excelApp.Quit();
//
//                // Освобождаем ресурсы COM
//                ReleaseObject(workbook);
//                ReleaseObject(excelApp);
//            }
//            //Вызываем открытие созданного файла соответствующим ему приложением (Excel)
//            //Process.Start("C:\\Program Files\\Microsoft Office\\Office16\\EXCEL.EXE");
//            //Process.Start("\"C:\\Program Files\\Microsoft Office\\Office16\\EXCEL.EXE\" " + filePath);
//            //Process.Start("\"EXCEL.EXE\"");//, filePath);
//            //Process.Start("excel.exe", @"/r ""S:\Папка с файлами\Документы Эксель\2107.xlsx""");
//          //Process.Start("excel.exe", @"/r S:\Папка\2107.xlsx");
//
//            //Process.Start("excel.exe", @"/r " + filePath + "\"");
//
//
//            return Page();
//        }
//        // Метод для освобождения ресурсов COM
//        private void ReleaseObject(object obj)
//        {
//            try
//            {
//                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
//                obj = null;
//            }
//            catch (Exception ex)
//            {
//                obj = null;
//                Console.WriteLine("Ошибка при освобождении объекта COM: " + ex.Message);
//            }
//            finally
//            {
//                GC.Collect();
//            }
//        }

        public async Task<IActionResult> OnPostConvertToExcelClosedXML(long Id)
        {
            await OnPostChangeGoFiltr();

            // Определяем loginUserName пользователя вошедшего в систему
            var loginUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(loginUserName);
            if (currentUser != null)
            {
                //curUser = currentUser;
                _dateFiltrStart = currentUser.DateFiltrStart.Value.ToShortDateString();
                _dateFiltrEnd   = currentUser.DateFiltrEnd.Value.ToShortDateString();

                // Сохраняем параметры фильтра текущего пользователя
                //var updateError = await _userManager.UpdateAsync(currentUser);
            }
            var MessageString = "Ведется работа по реализации выгрузки данных в Excel ! ConvertToExcelClosedXML ";
            _messageString = MessageString;

            await GetOperationControls();
            //OperationControls = GetOperationControls();

            //var _operationControls = CreateOperationControl();
            //var _operationControls = OperationControls;

            //var DoItFiltr = await OnPostChangeGoFiltr(Id);
            //if (DoItFiltr != null)
            //{
            //Ищем файл шаблон и по шаблону выгружаем OperationControls
            //Нужно создать предварительно перечень с указателями ссылками на файлы Excell

            //}                         
            //                                          ВНИМАНИЕ - данный путь верен для локальной отладки,
            //                                          в случае запуска на веб сервере IIS путь размещения файлов шаблонов берется с сервера независимо от клиента !!!
            //

            try
            {
                using (XLWorkbook workbook = new XLWorkbook("C:\\APP.IIS\\gns-au.net\\Shablons\\OperationControlMaterials.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook("D:\\APP.IIS\\gns-au.net\\Shablons\\OperationControlMaterials.xlsx"))
                //using (XLWorkbook workbook = new XLWorkbook())
                {
                    //Операц_контроль_материалов
                    var worksheet = workbook.Worksheet("OperControl");
                    if (worksheet == null)
                    {
                        worksheet = workbook.Worksheets.Add("OperControl");
                    }

                    //worksheet.Cell("A1").Value = "Дата";
                    //worksheet.Cell("B1").Value = "Время";
                    //worksheet.Row(1).Style.Font.Bold = true;

                    //worksheet.Cell(3, 1).Value = worksheet.Cell(3, 1).Value + "1";

                    //нумерация строк/столбцов начинается с индекса 1 (не 0)
                    //worksheet.Row(8).Style.Alignment.SetHorizontal(00);// = true;

                    //worksheet.Row(6).AddToNamed(string.Join("6", Convert.ToString(OperationControls.Count)));

                    int rowCur = 7;  // пропускаем в шаблоне строки заголовка формы до позиции 7 на основе визуального оформления шаблона
                    int maxCol = 19;
                    foreach (var OperationControl in OperationControls)
                    {
                        //rowCur++;
                        //кто НЕ понимает зачем индекс курсора строки с префиксным инкрементом заменяет отдельную с постфиксным инкрементом - ТОМУ ВООБЩЕ ТУТ НЕЧЕГО ДЕЛАТЬ :))
                        // Делаем вставку строки и заполняем её значениями
                        //worksheet.Row(++rowCur).InsertRowsAbove(1); // при вставке ячейки обрамленые рамкой
                        worksheet.Row(++rowCur).InsertRowsBelow(1);   // при вставке ячейки не обрамлены рамкой
                        worksheet.Cell(rowCur, 1).Value = OperationControl.DateTrial;
                        worksheet.Cell(rowCur, 2).Value = OperationControl.TimeTrial;
                        worksheet.Cell(rowCur, 3).Value = OperationControl.Enthalpiy;
                        worksheet.Cell(rowCur, 4).Value = OperationControl.Activity;
                        worksheet.Cell(rowCur, 5).Value = OperationControl.Time;
                        worksheet.Cell(rowCur, 6).Value = OperationControl.Temperature;

                        worksheet.Cell(rowCur, 7).Value = OperationControl.NumPool;
                        worksheet.Cell(rowCur, 8).Value = OperationControl.Density;
                        worksheet.Cell(rowCur, 9).Value = OperationControl.ResidueOnSieve;
                        worksheet.Cell(rowCur, 12).Value = OperationControl.GypsumContentSandSlurry;

                        worksheet.Cell(rowCur, 13).Value = OperationControl.NumPoolM;
                        worksheet.Cell(rowCur, 14).Value = OperationControl.DensityM;
                        worksheet.Cell(rowCur, 15).Value = OperationControl.ResidueOnSieveM;
                        worksheet.Cell(rowCur, 18).Value = OperationControl.DensityReturnSludge;

                        //------------------- Устанавливаем границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\
                        worksheet.Cell(rowCur, 1).Style.Border.SetLeftBorder(XLBorderStyleValues.Medium);

                        for (int i = 1; i < maxCol; i++)
                        {
                            if (OperationControl.DateTrial != "")       // Если дата не определена, то не выводим обрамление
                            {
                                worksheet.Cell(rowCur, i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                            }
                            if (i == 2 || i == 6 || i == 12 || i == 17) // Устанавливаем более толстые линиии для выделения разделов согласно шаблона
                            {
                                worksheet.Cell(rowCur, i).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                            }
                            else
                            {
                                worksheet.Cell(rowCur, i).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                            }
                        }
                        worksheet.Cell(rowCur, maxCol-1).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                    }
                    for (int i = 1; i < maxCol; i++)
                    {
                        worksheet.Cell(rowCur, i).Style.Border.BottomBorder = XLBorderStyleValues.Medium;
                    }
                    //---------------------------------- границы обрамления ячеек на основе визуального оформления шаблона --------------------------\\

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        stream.Flush();
                        // DTBetween - формирование в имени выгружаемого по шаблону файлу даты диапазона 
                        string DTBetween = _dateFiltrStart  + ".." + _dateFiltrEnd;
                        return new FileContentResult(stream.ToArray(),
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                        {
                            //FileDownloadName = $"brands_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                            FileDownloadName = $"OperationControlMaterials_{DTBetween}.xlsx"
                        };
                    }
                }
                return Page();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Ошибка при экспорте данных в Excel: " + ex.Message);
                //var MessageString = "Ошибка при экспорте данных в Excel: " + ex.Message;
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
