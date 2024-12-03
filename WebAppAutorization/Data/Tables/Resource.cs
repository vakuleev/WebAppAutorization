using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("Resources", Schema = "data")]
    public class Resource
    {
        [Display(Name = "Id Res")]
        [Key] public int Id { get; set; }

        [Display(Name = "Ресурс")]
        //[MinLength(5)]
        [MaxLength(32)]
        public string ResName { get; set; }
    }
}
