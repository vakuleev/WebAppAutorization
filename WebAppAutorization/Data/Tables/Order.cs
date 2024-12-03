using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.Tables
{
    [Table("Orders", Schema = "data")]
    public class Order
    {
        //Cогласно модели принятой в EntityFramework 
        //Первичный ключ для модели :"[className]+Id" = OrderId
        //Использование Id без classname упрощает внесение некоторых изменений в модель данных
        //Иногда при формировании связей между таблицами подход "[className]+Id" = OrderId мешает и не проходит Add-Migration !!!
        [Display(Name = "Id Order")]
        [Key] public long Id { get; set; }

        ///*
        //-------------------------------- P R O D U C T --------------------------------//
        //[BindProperty]
        [Display(Name = "Наименование товара")]
        //[MinLength(5)]
        [MaxLength(250)]
        public string? ProductName { get; set; }
        [Display(Name = "Ед.изм.")]
        [MaxLength(50)]
        public string? ProductEdIzm { get; set; }
        [Display(Name = "Кол-во")]
        //[Column(TypeName = "decimal(18, 10)")]
        public double ProductCount { get; set; }
        [Display(Name = "Цена(Тариф)")]
        //[Column(TypeName = "decimal(18, 10)")]
        public double ProductTarif { get; set; }

        [Display(Name = "Стоимость")]
        [Column(TypeName = "decimal(18, 2)")]
        public virtual decimal ProductStoim
        { get { return Math.Round(Convert.ToDecimal(ProductCount * ProductTarif), 2, MidpointRounding.AwayFromZero) ; } private set { } }

        [Display(Name = "Налог %")]
        public decimal ProductNalog { get; set; }

        [Display(Name = "Сумма налога")]
        [Column(TypeName = "decimal(18, 2)")]
        public virtual decimal SumNalog
        //{ get { return Math.Round(ProductNalog * ProductStoim / 100, 2, MidpointRounding.AwayFromZero); } private set { } }

        { get { return Math.Round(0.01M * ProductNalog * ProductStoim, 2, MidpointRounding.AwayFromZero); } private set { } }

        [Display(Name = "Стоим-ть тов.")]
        [Column(TypeName = "decimal(18, 2)")]
        public virtual decimal? SumProductNalog
        { get { return SumNalog + ProductStoim; } private set { } }
        //-------------------------------- P R O D U C T --------------------------------//
        //*/
        //либо
        //Entity<T>().Has[Multiplicity](Property).With[Multiplicity](Property)

        //Ссылка на главную таблицу Sheetf----------------------------------------------//
        public Sheetf? Sheetf { get; set; }

        //Внешний ключ на Sheetf
        [Display(Name = "Идентификатор Sheetf")]
        [Required]
        public long sheetfId { get; set; } // Внешний ключ SheetfId

        [Display(Name = "Тип")]
        [MaxLength(1)]
        public string DocType { get; set; }
        [Display(Name = "Удаление")]
        public bool Delete { get; set; }

        [Display(Name = "Код рес")]
        public int ResType { get; set; } //  1 - вода , 2 - газ, 3 - электроэнергия

        [Display(Name = "Ресурс")]
        //[MinLength(5)]
        [MaxLength(32)]
        public string? ResName { get; set; }

        [Display(Name = "Превышен лимит")]
        public bool OverLimit { get; set; }

        [Display(Name = "Калорийность (газ)")]
        public int? Calories { get; set; }
 
        public Order()
        {
            ProductNalog = 20.0M;
            DocType      = "D";
            Delete       = false;
            ResType      = 3;
            OverLimit    = false;
        }
    }
}
