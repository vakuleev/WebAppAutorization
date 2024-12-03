using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Data.Tables
{
    //[Table("CompanyUsers", Schema = "data")]
    public class CompanyUser
    {
        //Внешний ключ на Company
        [Display(Name = "Компания ID")]
        public long? companyId { get; set; }

        //Внешний ключ на User
        [Display(Name = "Пользователь ID")]
        [MaxLength(450)]
        public string? userId { get; set; }

        //Ссылка на главную таблицу User    ---------------------------------------------//
        public User? user { get; set; }
        //Ссылка на главную таблицу Company ---------------------------------------------//
        public Company? company { get; set; }
    }
}
