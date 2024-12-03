using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("H_object", Schema = "isdata")]
    public class H_object
    {
        [Key] public int id_object { get; set; }

        [Display(Name = "Хаб")]
        public string prefix { get; set; }

        [Display(Name = "Имя объекта")]
        public string name_object { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }
        
        [Display(Name = "Метод внесения (источник)")]
        public string? id_source { get; set; }

        [Display(Name = "Помечен для удаления")]
        public bool Delete { get; set; }

        // Навигационная связь с H_Division          ------------------------------------------------------// Left
        public List<H_Division>? H_Divisions { get; set; } 

        // Навигационная связь с H_eemp              ------------------------------------------------------// Right
        public List<H_eemp>? H_eemps { get; set; }

        // Навигационная связь с I_division_object   ------------------------------------------------------// Left
        public List<I_division_object>? I_division_objects { get; set; }

        // Навигационная связь с I_object_eemp       ------------------------------------------------------// Right
        public List<I_object_eemp>? I_object_eemps { get; set; }

        // Навигационная связь с S_object_info       ------------------------------------------------------// down
        public List<S_object_info>? S_object_infos { get; set; }

        public H_object()
        {
            load_dttm          = DateTime.Now;
            id_source          = "форма ввода вручную";
            H_Divisions        = new List<H_Division>();
            H_eemps            = new List<H_eemp>();
            I_division_objects = new List<I_division_object>();
            I_object_eemps     = new List<I_object_eemp>();
            S_object_infos     = new List<S_object_info>();
        }
    }
}
