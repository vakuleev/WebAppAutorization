using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppAutorization.Data.Tables
{
    [Table("Agents", Schema = "data")]

    public class Agent
    {
        [Key] public long Id { get; set; }
        //[Display(Name = "ID Owner")]
        //public int id_nameUser { get; set; }
        [Display(Name = "Предприятие")]
        //[MinLength(5)]
        [MaxLength(100)]
        public string? Name { get; set; }
    }
}
