using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("H_eemp", Schema = "isdata")]
    public class H_eemp
    {
        [Key] public int id_eemp { get; set; }

        [Display(Name = "Хаб")]
        public string prefix { get; set; }

        [Display(Name = "Наименование измерителя")]
        public string name_point { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public string? id_source { get; set; }

        [Display(Name = "id_parent")]
        public int? id_parent { get; set; }

        [Display(Name = "Виртуальный счетчик")]
        public bool? virtual_counter { get; set; }

        [Display(Name = "Помечен для удаления")]
        public bool Delete { get; set; }

        // Навигационная связь с H_object                ------------------------------------------------------// Слева
        public List<H_object>? H_objects { get; set; }

        // Навигационная связь с H_Factory               ------------------------------------------------------// Справа
        public List<H_Factory>? H_Factorys { get; set; }

        // Навигационная связь с I_object_eemp           ------------------------------------------------------// Слева
        public List<I_object_eemp>? I_object_eemps { get; set; }

        // Навигационная связь с I_Factory_eemp          ------------------------------------------------------// Справа
        public List<I_Factory_eemp>? I_Factory_eemps { get; set; }

        // Навигационная связь с S_eemp_info             ------------------------------------------------------// down
        public List<S_eemp_info>? S_eemp_infos { get; set; }

        // Навигационная связь с S_eemp_info             ------------------------------------------------------// down
        public List<S_eemp_cc>? S_eemp_ccs { get; set; }

        public H_eemp()
        {
            load_dttm       = DateTime.Now;
            id_source       = "форма ввода вручную";
            H_objects       = new List<H_object>();
            H_Factorys      = new List<H_Factory>();
            I_object_eemps  = new List<I_object_eemp>();
            I_Factory_eemps = new List<I_Factory_eemp>();
            S_eemp_infos    = new List<S_eemp_info>();
            S_eemp_ccs      = new List<S_eemp_cc>();
        }
    }
}
