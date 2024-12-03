using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Data.Tables
{
    [Table("Companies", Schema = "data")]

    public class Company
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Предприятие")]
        //[MinLength(5)]
        [MaxLength(100)]
        public string? Name { get; set; }

        // Навигационная связь с User  и  CompanyUser ------------------------------------------------------//
        public List<User>?          Users { get; set; } //= new();
        public List<CompanyUser>?   CompanyUsers { get; set; } //= new();
        // Навигационная связь с User  и  CompanyUser ------------------------------------------------------//

        // Навигационная связь с Sheetf  и  CompanySheetf --------------------------------------------------//
        public List<Sheetf>?        Sheetfs { get; set; } //= new();
        //public List<CompanySheetf>? CompanySheetfs { get; set; } //= new();
        // Навигационная связь с Sheetf  и  CompanySheetf --------------------------------------------------//

        // Навигационная связь с Shablon  и  CompanyShablon --------------------------------------------------//
        //public List<Shablon>?        Shablons { get; set; } //= new();
        //public List<CompanyShablon>? CompanyShablons { get; set; } //= new();
        // Навигационная связь с Shablon  и  CompanyShablon --------------------------------------------------//
        public Company()
        {
            Users           = new List<User>();
            CompanyUsers    = new List<CompanyUser>();
            Sheetfs         = new List<Sheetf>();
            //Shablons        = new List<Shablon>();

            //CompanySheetfs  = new List<CompanySheetf>();
            //CompanyShablons = new List<CompanyShablon>();
        }
        // Навигационная связь с User  и  UsersCompany ------------------------------------------------------//

        //METANIT Связь многие ко многим
        //public ICollection<User> Users { get; set; }
        //public Company()
        //{
        //    Users = new List<User>();
        //}

        public static implicit operator Company(bool v)
        {
            throw new NotImplementedException();
        }

    }
}
