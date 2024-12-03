using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.Tables
{    
    [Table("InputControlIzvests", Schema = "datalab")]
    //Входной контроль извести
    public class InputControlIzvest
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата поступления")]
        [DataType(DataType.Date)]
        public DateTime? DateReceipt { get; set; }

        [Display(Name = "Не погасившиеся зерна, %, требование договора поставки №372 не более 25%")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? UnquencheGrains { get; set; }

        [Display(Name = "Активность, %, требование договора поставки №372 не менее 76%")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? Activity { get; set; }

        [Display(Name = "Пережог, %, требование договора поставки №372 не более 2,0%")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? WetBulkDensity { get; set; }

        [Display(Name = "Время гашения, мин., требование договора поставки №372 от 4 до 6 мин.")]
        [Range(typeof(decimal), "0", "10")]
        public decimal? ExtinguishingTime { get; set; }

        [Display(Name = "Температура гашения, С")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? ExtinguishingTemperature { get; set; }

        [Display(Name = "Равномерность изменения объема тн")]
        public decimal? UniformityVolumeChange { get; set; }


        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public InputControlIzvest()
        {
            CreateAt = DateTime.Now;
        }
    }
 }
