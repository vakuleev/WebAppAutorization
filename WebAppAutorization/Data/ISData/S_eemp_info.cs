using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_eemp_info", Schema = "isdata")]
    public class S_eemp_info
    {
        //[ForeignKey("H_eemp")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]    
        public int id_eemp { get; set; }
        [Display(Name = "Model")]
        public string model { get; set; }
        [Display(Name = "Factory_number")]
        public string factory_number { get; set; }
        [Display(Name = "date_next_verif")]
        public DateTime date_next_verif { get; set; }
        [Display(Name = "Адрес")]
        public string adress { get; set; }
        [Display(Name = "Описание")]
        public string description { get; set; }

        [Key]
        [Display(Name = "Дата загрузки")]
        public string load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_eemp       ---------------------------------------------//
        public H_eemp? h_eemp { get; set; }

        public S_eemp_info()
        {
            load_dttm = Convert.ToString(DateTime.Now);
            id_source = 1;
        }
    }
}
