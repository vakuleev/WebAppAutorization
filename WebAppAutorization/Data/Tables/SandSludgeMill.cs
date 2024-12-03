using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("SandSludgeMills", Schema = "datalab")]
    public class SandSludgeMill
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Проверьте на дубликат ! Возможно запись уже есть !")]
        public DateTime? DateTrial { get; set; }

        [Display(Name = "Время испытания")]
        [MaxLength(5)]
        [RegularExpression(@"[0-9]+:[0-9]{2,3}", ErrorMessage = "Некорректное время (чч:мм)")]
        [Required(ErrorMessage = "Проверьте на дубликат ! Возможно запись уже есть !")]
        public string? TimeTrial { get; set; }

        [Display(Name = "Дата время испытания")]
        public string? DateTimeTrial { get { return (DateTrial.Value.Date.ToShortDateString()) + " " + TimeTrial; } set { } }

        [Display(Name = "№ шламбассейна")]
        [Required(ErrorMessage = "Проверьте на дубликат ! Возможно запись уже есть !")]
        public int NumPool { get; set; }

        [Display(Name = "Плотность кг/м3 1690-1720")]
        [Range(typeof(decimal), "1000", "2720")]
        public decimal? Density { get; set; }

        [Display(Name = "Остаток на сите, % 90uk 18-21")]
        [Range(typeof(decimal), "0", "50")]
        public decimal? ResidueOnSieve { get; set; }

        [Display(Name = "Плотность обратного шлама, кг/м3")]
        public decimal? DensityReturnSludge  { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public SandSludgeMill()
        {
            CreateAt = DateTime.Now;
        }
        public void DoDateTimeTrial()
        {
            //Делаем из даты DateTrial и время TimeTrial измерения одно поле дата время измерения DateTimeTrial
            if (TimeTrial.Length < 5) TimeTrial = "0" + TimeTrial;
            DateTimeTrial = DateTrial.Value.Date.ToShortDateString() + " " + TimeTrial;
            //DateTrial     = Convert.ToDateTime(DateTimeTrial);
        }

    }
}
