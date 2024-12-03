using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;
using WebAppAutorization.Data.Tables;

namespace WebAppAutorization.Data.Identity
{
//    [Table("ApplicationUsers", Schema = "data")]
    public class User : IdentityUser
    {
        [Display(Name = "Выбранная компания Id")]
        public long? CurrentCompanyId { get; set; }
        [NotMapped]
        [Display(Name = "Активная клавиша")]
        public virtual string? AdminKeyActive { get; set; }
        [Display(Name = "ID приложения")]
        public long? ApplicationId { get; set; }
        [Display(Name = "Имя")]
        public string? FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string? FamilyName { get; set; }
        [Display(Name = "Отчество")]
        public string? LastName { get; set; }
        // Конфигурация в приложении
        // Удаление не происходит, помечается поле Delete = true; для возможности восстановления
        [Display(Name = "Поддерживать восстановления документа")]
        public bool SoftDelete { get; set; }
        [Display(Name = "Показывать удаленные")]
        public bool ViewDelete { get; set; }

        // ----------       Фильтр для запросов пользователя       ----------------//
        [Display(Name = "Дата начала")]
        [DataType(DataType.Date)]
        public DateTime? DateFiltrStart { get; set; }

        [Display(Name = "Дата конца")]
        [DataType(DataType.Date)]
        public DateTime? DateFiltrEnd { get; set; }

        [Display(Name = "Выбранный ресурс")]
        [MaxLength(32)]
        public string? ResName { get; set; }

        [Display(Name = "Все ресурсы")]
        public bool ViewAllRes { get; set; }

        // Навигационная связь с Company и CompanyUser ------------------------------------------------------//
        public List<Company>? Companies { get; set; } //= new();
        public List<CompanyUser>? CompanyUsers { get; set; } //= new();
        public User()
        {
            SoftDelete       = true;
            ViewDelete       = false;
            Companies        = new List<Company>();
            CompanyUsers     = new List<CompanyUser>();
            AdminKeyActive   = "";
            CurrentCompanyId = 0;
            DateFiltrStart   = DateTime.Now;
            DateFiltrEnd     = DateTime.Now;
            ViewAllRes       = false;
        }

        //Shablons -> Create -> IActionResult OnGet() -> LogInUser = loginUser;
        //public static implicit operator User(Task<User?> v)
        //{
        //    throw new NotImplementedException();
        //}

        // Навигационная связь с Company и CompanyUser ------------------------------------------------------//
    }
}
