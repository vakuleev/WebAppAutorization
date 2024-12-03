using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_Factory_info", Schema = "isdata")]
    public class S_Factory_info
    {
        //[ForeignKey("H_Factory")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_factory { get; set; } 
        [Display(Name = "Описание")]
        public string? description { get; set; }
        [Display(Name = "Адрес")]
        public string? adress { get; set; }

        [Key]
        [Display(Name = "Дата загрузки")]
        //[Timestamp] 
        //[ConcurrencyCheck]
        public string load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        [Display(Name = "Корректировка")]
        public bool Status { get; set; }

        //Ссылка на главную таблицу H_Factory   ---------------------------------------------//
        public H_Factory? h_factory { get; set; }

        public S_Factory_info()
        {
            //load_dttm = DateTime.Now;
            id_source = 1;
        }
    }
}
