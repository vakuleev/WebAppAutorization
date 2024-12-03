using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.Tables
{
    [Table("SandSludgePools", Schema = "datalab")]
    public class SandSludgePool
    {
        [Key] public long Id { get; set; }
        
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime? DateTrial { get; set; }
        
        [Display(Name = "Время испытания")]
        [MaxLength(5)]
        [RegularExpression(@"[0-9]+:[0-9]{2,3}", ErrorMessage = "Некорректное время (чч:мм)")]
        public string? TimeTrial { get; set; }

        [Display(Name = "Дата время испытания")]
        public string? DateTimeTrial { get { return (DateTrial.Value.Date.ToShortDateString()) + " " + TimeTrial; } set { } }

        [Display(Name = "№ шламбассейна")]
        public int NumPool { get; set; }
        
        [Display(Name = "Плотность кг/м3 1690-1720")]
        [Range(typeof(decimal), "1000", "2720")]
        public decimal? Density { get; set; }
        
        [Display(Name = "Остаток на сите, % 90uk 18-21")]
        [Range(typeof(decimal), "0", "50")]
        public decimal? ResidueOnSieve { get; set; }
        
        [Display(Name = "Содержание гипса в песчаном шламе, %")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? GypsumContentSandSlurry { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public SandSludgePool()
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
    
