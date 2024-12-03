using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("Products", Schema = "data")]
    //[PrimaryKey("Name")]
    public class Product
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Наименование товара")]
        //[MinLength(5)]
        [MaxLength(250)]
        public string? Name { get; set; }

        [Display(Name = "Ед.изм.")]
        [MaxLength(50)]
        public string? EdIzm { get; set; }


        //             Н Е А К Т У А Л Ь Н О  : 2023-05-16 20:12

        /*/ Навигационная связь с Sheetf
        public ICollection<Sheetf>? Sheetfs { get; set; }
        //*///
    }
}
