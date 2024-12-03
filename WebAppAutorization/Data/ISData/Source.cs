using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_object", Schema = "isdata")]
    public class Source
    {
        [Key] public int id { get; set; }
        [Display(Name = "Название источника")]
        [MaxLength(20)]
        public string name_source { get; set; }

        [Display(Name = "Описание")]
        [MaxLength(100)]
        public string description { get; set; }

        [Display(Name = "Тип БД")]
        [MaxLength(10)]
        public string type_bd { get; set; }

        [Display(Name = "IP адрес")]
        [MaxLength(15)]
        public string ip_addr { get; set; }

        [Display(Name = "Порт БД")]
        public int port_bd { get; set; }

        [Display(Name = "Имя таблицы")]
        [MaxLength(40)]
        public string name_table { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime load_dttm { get; set; }
    }
}
