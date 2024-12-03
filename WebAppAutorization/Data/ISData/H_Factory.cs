using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Data.ISData
{
    [Table("H_Factory", Schema = "isdata")]
    public class H_Factory
    {
        [Key] public int id_factory { get; set; }
 
        [Display(Name = "Наименование завода")]
        public string? name_factory { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public string? id_source { get; set; }

        [Display(Name = "Помечен для удаления")]
        public bool Delete { get; set; }

        // Навигационная связь с H_eemp             ------------------------------------------------------// Слева
        public List<H_eemp>? H_eemps { get; set; } //= new();

        // Навигационная связь с H_Division         ------------------------------------------------------// Справа
        public List<H_Division>? H_Divisions { get; set; } //= new();

        // Навигационная связь с I_Factory_eemp     ------------------------------------------------------// Слева
        public List<I_Factory_eemp>? I_Factory_eemps { get; set; } //= new();

        // Навигационная связь с I_Factory_Division ------------------------------------------------------// Справа
        public List<I_Factory_Division>? I_Factory_Divisions { get; set; } //= new();

        // Навигационная связь с S_Factory_info     ------------------------------------------------------// down
        public List<S_Factory_info>? S_Factory_infos { get; set; }

        public H_Factory()
        {
            load_dttm           = DateTime.Now;
            id_source           = "форма ввода вручную";
            H_eemps             = new List<H_eemp>();
            H_Divisions         = new List<H_Division>();
            I_Factory_eemps     = new List<I_Factory_eemp>();
            I_Factory_Divisions = new List<I_Factory_Division>();
            S_Factory_infos     = new List<S_Factory_info>();
        }
    }
}
