using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("ResultsLimeMills", Schema = "datalab")]
    //Результаты испытаний молотой извести с мельницы
    public class ResultsLimeMill
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата поступления извести на помол")]
        [DataType(DataType.Date)]
        public DateTime? DateTrial { get; set; }
        [Display(Name = "Время испытания")]
        [MaxLength(5)]
        [RegularExpression(@"[0-9]+:[0-9]{2,3}", ErrorMessage = "Некорректное время (чч:мм)")]
        public string? TimeTrial { get; set; }
        [Display(Name = "Поставщик извести (Искитимская, Матвевка)")]
        [MaxLength(100)]
        public string? Agent { get; set; }
        [Display(Name = "Дата поступления извести на завод")]
        [DataType(DataType.Date)]
        public DateTime? DateLimeOnManufakt { get; set; }
        //Результат испытаний извести
        [Display(Name = "Проход через сита 200мкм, %, не менее 98,5")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? Sito200 { get; set; }
        [Display(Name = "Проход через сита 80мкм, %, не менее 85")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? Sito80 { get; set; }
        [Display(Name = "Активность, %, Искитим 75-76")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? ActiveLime { get; set; }
        [Display(Name = "Энтальпия, кДж/кг (По необходимости)")]
        public decimal? Entalpya { get; set; }
        [Display(Name = "Содержание песка, %")]
        public decimal? SandProc { get; set; }
        //Подача сырья в мельницу на момент отбора пробы
        [Display(Name = "Подача извести, кг/мин")]
        public decimal? LimeMn { get; set; }
        [Display(Name = "Подача песка, кг/мин")]
        public decimal? SandMn { get; set; }
        //Коректирующие деействия
        [Display(Name = "Извести, кг/мин")]
        public decimal? LimeMnK { get; set; }
        [Display(Name = "Песка, кг/мин")]
        public decimal? SandMnK { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public ResultsLimeMill()
        {
            CreateAt = DateTime.Now;
        }
        public void DoTimeTrial()
        {
            //Делаем поле TimeTrial пригоднымм для сортировки
            if (TimeTrial.Length < 5) TimeTrial = "0" + TimeTrial;
        }
    }
}
