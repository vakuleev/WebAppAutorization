using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("OperationControls", Schema = "datalab")]
    public class OperationControl
    {
        [Key] public long Id { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public string? DateTrial { get; set; }

        [Display(Name = "Время испытания")]
        [MaxLength(5)]
        public string? TimeTrial { get; set; }

        [Display(Name = "Дата время испытания")]
        public string? DateTimeTrial { get; set; }

        [Display(Name = "Энтальпия, кДж/кг")]
        public decimal? Enthalpiy { get; set; }

        [Display(Name = "Активность, %")]
        public decimal? Activity { get; set; }

        [Display(Name = "Время, мин")]
        [MaxLength(5)]
        public string? Time { get; set; }

        [Display(Name = "Температура, C")]
        public decimal? Temperature { get; set; }

        [Display(Name = "№ шламбассейна")]
        public int? NumPool { get; set; }

        [Display(Name = "Плотность кг/м3 1690-1720")]
        public decimal? Density { get; set; }

        [Display(Name = "Остаток на сите, % 90uk 18-21")]
        public decimal? ResidueOnSieve { get; set; }

        [Display(Name = "Содержание гипса в песчаном шламе, %")]
        public decimal? GypsumContentSandSlurry { get; set; }

        [Display(Name = "№ шламбассейна")]
        public int? NumPoolM { get; set; }

        [Display(Name = "Плотность кг/м3 1690-1720")]
        public decimal? DensityM { get; set; }

        [Display(Name = "Остаток на сите, % 90uk 18-21")]
        public decimal? ResidueOnSieveM { get; set; }

        [Display(Name = "Плотность обратного шлама, кг/м3")]
        public decimal? DensityReturnSludge { get; set; }

        //public static implicit operator OperationControl(object v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
