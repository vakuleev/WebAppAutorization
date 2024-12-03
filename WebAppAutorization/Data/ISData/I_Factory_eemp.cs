using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("I_Factory_eemp", Schema = "isdata")]
    public class I_Factory_eemp
    {
        //[Key] public int id_factory_eemp { get; set; }
        [Display(Name = "id_eemp")]
        public int id_eemp { get; set; }

        [Display(Name = "id_factory")]
        public int id_factory { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_eemp     ---------------------------------------------//
        public H_eemp? h_eemp { get; set; }
        //Ссылка на главную таблицу H_Factory  ---------------------------------------------//
        public H_Factory? h_factory { get; set; }

        public I_Factory_eemp()
        {
            load_dttm = DateTime.Now;
            id_source = 1;
        }

    }
}
