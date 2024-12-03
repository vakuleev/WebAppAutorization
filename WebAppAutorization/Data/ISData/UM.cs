using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.ISData
{
    [Table("UM", Schema = "isdata")]
    public class UM
    {
        [Key] public int id { get; set; }
        [Display(Name = "Описание")]
        public string? abbreviated_name { get; set; }
        [Display(Name = "Описание")]
        public string? description { get; set; }
    }
}
