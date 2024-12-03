using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("I_Division_eemp", Schema = "isdata")]

    public class I_Division_eemp
    {
        //[Key] public int id_div_eemp { get; set; }
        [Display(Name = "division_id")]
        public int id_division { get; set; }
        [Display(Name = "id_eemp")]
        public int id_eemp { get; set; }
        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }
        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }
        public I_Division_eemp()
        {
            load_dttm = DateTime.Now;
            id_source = 1;
        }

    }
}
