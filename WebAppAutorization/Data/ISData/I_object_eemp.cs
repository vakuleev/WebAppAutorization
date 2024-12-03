using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("I_object_eemp", Schema = "isdata")]
    public class I_object_eemp
    {
        //[Key] public int id_obj_eemp { get; set; }
        [Display(Name = "object_id")]
        public int id_object { get; set; }

        [Display(Name = "id_eemp")]
        public int id_eemp { get; set; }
        
        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }
        
        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_object     ---------------------------------------------//
        public H_object? h_object { get; set; }

        //Ссылка на главную таблицу H_eemp       ---------------------------------------------//
        public H_eemp? h_eemp { get; set; }

        public I_object_eemp()
        {
            load_dttm = DateTime.Now;
            id_source = 1;
        }
    }
}
