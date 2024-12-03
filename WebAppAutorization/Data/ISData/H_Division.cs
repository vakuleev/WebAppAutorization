using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DocumentFormat.OpenXml.Spreadsheet;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Data.ISData
{
    [Table("H_Division", Schema = "isdata")]
    public class H_Division
    {
        [Key] public int id_division { get; set; }

        [Display(Name = "Хаб")]
        public string? prefix { get; set; }

        [Display(Name = "Подразделение")]
        public string? name_division { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public string? id_source { get; set; }

        [Display(Name = "Помечен для удаления")]
        public bool Delete { get; set; }

        // Навигационная связь с H_Factory          ------------------------------------------------------// Left
        public List<H_Factory>? H_Factorys { get; set; } 

        // Навигационная связь с H_object           ------------------------------------------------------// Right
        public List<H_object>? H_objects { get; set; }

        // Навигационная связь с I_Factory_Division ------------------------------------------------------// Left
        public List<I_Factory_Division>? I_Factory_Divisions { get; set; }

        // Навигационная связь с I_division_object ------------------------------------------------------// Right
        public List<I_division_object>? I_division_objects { get; set; }

        // Навигационная связь с S_Division_info   ------------------------------------------------------// down
        public List<S_Division_info>? S_Division_infos { get; set; }

        public H_Division()
        {
            load_dttm           = DateTime.Now;
            id_source           = "форма ввода вручную";
            H_Factorys          = new List<H_Factory>();
            H_objects           = new List<H_object>();
            I_Factory_Divisions = new List<I_Factory_Division>();
            I_division_objects  = new List<I_division_object>();
            S_Division_infos    = new List<S_Division_info>();
        }
    }
}
