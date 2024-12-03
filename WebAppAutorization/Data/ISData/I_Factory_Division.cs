using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Data.ISData
{
    [Table("I_Factory_Division", Schema = "isdata")]
    public class I_Factory_Division
    {
        //Примари ключ будет выполнен через Fluent API в gnsDBContext
        //[Key] public int id_fact_div{ get; set; }

        //Внешний ключ на H_Factory
        [Display(Name = "Внешний ключ на H_Factory")]
        public int id_factory { get; set; }

        //Внешний ключ на H_Division
        [Display(Name = "Внешний ключ на H_Division")]
        public int id_division { get; set; }

        [Display(Name = "Дата загрузки")]
        public DateTime? load_dttm { get; set; }

        [Display(Name = "Метод внесения (источник)")]
        public int id_source { get; set; }

        //Ссылка на главную таблицу H_Factory   ---------------------------------------------//
        public H_Factory? h_factory { get; set; }
        //Ссылка на главную таблицу H_Division  ---------------------------------------------//
        public H_Division? h_division { get; set; }

        public I_Factory_Division()
        {
            load_dttm = DateTime.Now;
            id_source = 1;
        }

    }
}
