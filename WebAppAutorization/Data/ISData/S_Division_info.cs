using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAppAutorization.Data.ISData
{
    [Table("S_Division_info", Schema = "isdata")]
    //[Keyless]
    public class S_Division_info
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]       //[ForeignKey("H_Division")]

        public int id_division { get; set; }

        [Display(Name = "Описание")]
        public string? description { get; set; }

        [Key]
        [Display(Name = "Дата загрузки")]
        //[Timestamp] 
        public string load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_Division   ---------------------------------------------//
        public H_Division? h_division { get; set; }

        public S_Division_info()
        {
            load_dttm = Convert.ToString(DateTime.Now);
            id_source = 1;
        }

    }
}
