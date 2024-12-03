using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("ResultsPortlandCements", Schema = "datalab")]
    //Результат испытаний портландцемента
    public class ResultsPortlandCement
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата испытания пробы")]
        [DataType(DataType.Date)]
        public DateTime? DateTrial { get; set; }
        [Display(Name = "Предприятие изготовитель")]
        [MaxLength(100)]
        public string? Agent { get; set; }
        [Display(Name = "Остаток на сите 90uk, %")]
        public decimal? Sito90 { get; set; }
        //Наименование определяемых характеристик цемента
        [Display(Name = "Коэффициент водоотделения, %, не более 30")]
        [Range(typeof(decimal), "0", "50")]
        public decimal? CoeffWaterSepar { get; set; }
        [Display(Name = "Удельная поверхность, см2/г, 3400-3700")]
        [Range(typeof(decimal), "1400", "4700")]
        public decimal? SpecificSurface { get; set; }
        [Display(Name = "Нормальная густота цементного теста,%, 24-26")]
        [Range(typeof(decimal), "0", "50")]
        public decimal? NormDensityCementPaste { get; set; }
        //Сроки схватывания
        [Display(Name = "Начало схватывания, 1ч50мин-2ч20мин")]
        [MaxLength(4)]
        [RegularExpression(@"[0-9]+:[0-9]{1,3}", ErrorMessage = "Некорректное время (ч:мм)")]
        //[Range(typeof(string), "0:00", "8:59")]
        public string? BeginCementSet { get; set; }
        
        [Display(Name = "Конец схватывания, 2ч50мин-4ч00мин")]
        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        // Display currency data field in the format $1,345.50.
        //[DisplayFormat(DataFormatString = "{0:C}")]
        //public object StandardCost;
        // Display date data field in the short format 11/12/08.
        // Also, apply format in edit mode.
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [MaxLength(4)]
        [RegularExpression(@"[0-9]+:[0-9]{1,3}", ErrorMessage = "Некорректное время (ч:мм)")]
        //[Range(typeof(string), "0:00", "8:59")]
        public string? EndCementSet { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public ResultsPortlandCement()
        {
            CreateAt = DateTime.Now;
        }
    }
}
