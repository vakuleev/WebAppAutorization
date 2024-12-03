using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static WebAppAutorization.Data.Tables.Product;

namespace WebAppAutorization.Data.Tables
{
    [Table("Sheetfs", Schema = "data")]
    //[Precision(10, 2)]
    //[Range(0, 9999999)]
    //[DataType(DataType.Currency)]
    //[Column(TypeName = "decimal(16, 10)")]
    //[DataType(DataType.Custom)]
    //[DisplayColumnAttribute("Номер", " ")]
    public class Sheetf                   //: Product
    {
        //Cогласно модели принятой в EntityFramework 
        //Первичный ключ для модели :"[className]+Id" = SheetfId
        // "Sheetf" + "Id" = SheetfId
        //Использование Id без classname упрощает внесение некоторых изменений в модель данных
        //Иногда при формировании связей между таблицами подход "[className]+Id" = OrderId мешает и не проходит Add-Migration !!!
        //Либо явно указав перед именем поля являющегося идентификатом ключа
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Либо тоже самое с помощью Fluent API
        //modelBuilder.Entity<Project>().HasKey(p => p.SheetfId);
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Id Sheetf")]
        [Key] public long Id { get; set; }

        [Display(Name = "Продавец")]
        [MaxLength(100)]
        public string? Prodavec { get; set; }
        [Display(Name = "Покупатель")]
        [MaxLength(100)]
        public string? Pokupat { get; set; }
        [Display(Name = "АКТ № ")]
        [MaxLength(50)]
        public string? NumAct { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime? DateAct { get; set; }

        //-------------------------------- P R O D U C T --------------------------------//
        /*
        //[BindProperty]
        /*/// ------------------------------------- Берем из справочника Product
        [Display(Name = "Наименование товара")]
        //[MinLength(5)]
        [MaxLength(250)]
        public string? ProductName { get; set; }
        //*/// ------------------------------------- Берем из справочника Product
        [Display(Name = "Ед.изм.")]
        [MaxLength(50)]
        public string? ProductEdIzm { get; set; }
        [Display(Name = "Кол-во")]
        public double ProductCount { get; set; }

        [Display(Name = "Цена(Тариф)")]
        //[Column(TypeName = "decimal(18, 10)")]
        public double ProductTarif { get; set; }

        //[NotMapped]
        [Display(Name = "Стоимость")]
        public virtual decimal? ProductStoim
        { get; set; }
        //{ get { return Convert.ToDecimal(ProductCount * ProductTarif); } private set { } }

        [Display(Name = "Налог, %")]
        public decimal ProductNalog { get; set; }

        //[NotMapped]
        [Display(Name = "Сумма налога")]
        public virtual decimal? SumNalog
        { get; set; }
        //{ get { return Convert.ToDecimal(ProductNalog * ProductStoim / 100); } private set { } }

        //[NotMapped]
        //[Display(Name = "Стоимость товара (услуг) с налогом")]
        [Display(Name = "Стоим-ть тов.")]
        public virtual decimal? SumProductNalog
        { get; set; }
        //{ get { return SumNalog + ProductStoim; } private set { } }
        //*/
        //-------------------------------- P R O D U C T ------------------------------------//

        [Display(Name = "Одобрено")]
        public bool Approved { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        //[DataType(DataType.DateTime), DefaultValue("GETDATE()")]
        //builder.Ent
        //ity<Sheetf>().Property(z => z.CreateAt).HasDefaultValueSql("GETDATE()");
        // ReadOnlyCol =>
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        // Навигационная связь с Order ------------------------------------------------------//
        public ICollection<Order>? Orders { get; set; }
        // Навигационная связь с Order ------------------------------------------------------//

        //Ссылка на главную таблицу Company----------------------------------------------//
        public Company? Company { get; set; }
        //[ForeignKey("IXcompanyId")]
        [Display(Name = "Компания Id")]
        public long? companyId { get; set; }

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        //[Display(Name = "Тип: D - документ, S - шаблон")]
        [Display(Name = "Тип: D - документ, S - шаблон")]
        [MaxLength(1)]
        //[Range(typeof(string), "D", "S")]
        //[RegularExpression(@"[0-9]+:[0-9]{2,3}", ErrorMessage = "Некорректное время (чч:мм)")]
        //[RegularExpression(@"[S] {1,0}", ErrorMessage = "Некорректно только D или S")]
        public string DocType { get; set; }

        [Display(Name = "Помечен для удаления")]
        public bool Delete { get; set; }

        [Display(Name = "Код рес")]
        public int ResType { get; set; } //  1 - вода , 2 - газ, 3 - электроэнергия, 4 - превышения лимита

        [Display(Name = "Ресурс")]
        //[MinLength(5)]
        [MaxLength(32)]
        public string? ResName { get; set; }

        [Display(Name = "Превышен лимит")]
        public bool OverLimit { get; set; } 

        // Конструктор --------------------------------------------------------------------//
        public Sheetf()
        {
            DateAct  = DateTime.Now;
            //CreateAt = DateTime.Now;
            //if (CreateAt == null) CreateAt = DateTime.Now;
            //ProductName  = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт ло 10МВт ставка за энергию";
            //ProductEdIzm = "кВт.ч";
            //ProductCount = 0;
            //ProductTarif = 0;
            //ProductStoim = 0;
            ProductNalog = 20.0M;
            DocType      = "D";
            Delete       = false;
            ResType      = 3;
            OverLimit    = false;
        }
    }

}
