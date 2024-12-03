using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("InputControlSands", Schema = "datalab")]
    public class InputControlSand
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата поступления")]
        [DataType(DataType.Date)]
        public DateTime? DateReceipt { get; set; }

        [Display(Name = "Общее кол-во песка, поступившего с ЛПК, тн")]
        public decimal? TotalSandReceived { get; set; }

        [Display(Name = "Влажность песка, тн (Требование договора поставок: не более 7,0 %)")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? WaterSand { get; set; }

        [Display(Name = "Насыпная плотность во влажном состоянии т/м3")]
        public decimal? WetBulkDensity { get; set; }

        [Display(Name = "Содержание илистых глинистых веществ, % (Требование договора поставок: не более 3,0 %)")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? ClaySubstances { get; set; }

        [Display(Name = "Модуль крупности, % не более 2,0%")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? SizeModulus { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }
         
        public InputControlSand()
        {
            CreateAt = DateTime.Now;
        }

    }
}
