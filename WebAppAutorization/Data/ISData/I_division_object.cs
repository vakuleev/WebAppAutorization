using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("I_division_object", Schema = "isdata")]
    public class I_division_object
    {
        //[Key] public int id_div_obj { get; set; }

        [Display(Name = "Division_id")]
        public int id_division { get; set; }
        [Display(Name = "Object_id")]
        public int id_object { get; set; }
        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }
        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //[Display(Name = "Div_obj_id")]
        //Ссылка на главную таблицу H_Division   ---------------------------------------------//
        public H_Division? h_division { get; set; }

        //Ссылка на главную таблицу H_object   ---------------------------------------------//
        public H_object? h_object { get; set; }

        public I_division_object()
        {
            load_dttm = DateTime.Now;
            id_source = 1;
        }
    }
}
