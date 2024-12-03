using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_eemp_cc", Schema = "isdata")]
    public class S_eemp_cc
    {
        //[ForeignKey("H_eemp")]
        public int id_eemp { get; set; }
        [Display(Name = "Counter_coefficient")]
        public int counter_coefficient { get; set; }

        [Key]
        [Display(Name = "Valid_from_dttm")]
        public string valid_from_dttm { get; set; }

        [Display(Name = "Valid_until_dttm")]
        public string valid_until_dttm { get; set; }
        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_eemp       ---------------------------------------------//
        public H_eemp? h_eemp { get; set; }

        public S_eemp_cc()
        {
            //valid_from_dttm = DateTime.Now;
            id_source = 1;
        }

    }
}
