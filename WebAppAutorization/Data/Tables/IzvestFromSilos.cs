using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Metadata;

namespace WebAppAutorization.Data.Tables
{
    [Table("IzvestFromSiloss", Schema = "datalab")]

    public class IzvestFromSilos
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
        public string? DateTimeTrial { get { return (DateTrial.Value.Date.ToShortDateString()) + " " + TimeTrial; }  set { } }
        //public DateTime? DateTimeTrial { get { return (DateTrial.Value.Date + Convert.ToDateTime(TimeTrial)); } set { } } //+ " " + TimeTrial

        [Display(Name = "Энтальпия, кДж/кг")]
        public decimal? Enthalpiy { get; set; }

        [Display(Name = "Активность, %")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? Activity { get; set; }

        [Display(Name = "Время, мин")]
        [MaxLength(5)]
        [RegularExpression(@"[0-9]+:[0-9]{2,3}", ErrorMessage = "Некорректное время (мм:сс)")]
        public string? Time { get; set; }

        [Display(Name = "Температура, C")]
        [Range(typeof(decimal), "0", "100")]
        public decimal? Temperature { get; set; }

        [Display(Name = "Создано")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateAt { get; set; }// = DateTime.Now;

        [Display(Name = "Пользователь Id")]
        [MaxLength(450)]
        public string? userId { get; set; }

        public IzvestFromSilos()
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
