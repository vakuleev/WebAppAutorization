using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_object_info", Schema = "isdata")]
    public class S_object_info
    {
        //[ForeignKey("H_object")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }
        [Display(Name = "Описание")]
        public string description { get; set; }

        [Key]
        [Display(Name = "Дата загрузки")]
        public string load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_object     ---------------------------------------------//
        public H_object? h_object { get; set; }

        public S_object_info()
        {
            load_dttm = Convert.ToString(DateTime.Now);
            id_source = 1;
        }
    }
}
