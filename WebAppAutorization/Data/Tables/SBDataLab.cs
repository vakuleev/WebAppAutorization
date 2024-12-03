using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAutorization.Data.Tables
{
    [Table("SBDataLabs", Schema = "data")]
    public class SBDataLab
    {
        [Key] public long Id { get; set; }

        //----------------------------------------------  Страница 1  ----------------------------------------------//

        [Display(Name = "Создал ID")]
        public int id_nameUser1 { get; set; }
        [Display(Name = "Тонины песчаного шлама, %")]
        //[MinLength(5)]
        //[MaxLength(100)]
        public decimal? toniSandSlime { get; set; }
        [Display(Name = "Н.Г. цемента, %")]
        public decimal? NGCementProc { get; set; }

        [Display(Name = "Тонины цемента, %")]
        public decimal? toniCementProc { get; set; }
        [Display(Name = "Время начала схватывания цемента")]
        public DateTime? timeStartForceCement { get; set; }
        [Display(Name = "Время окончания схватывания цемента")]
        public DateTime? timeEndForceCement { get; set; }

        [Display(Name = "Создано I ")]
        [DataType(DataType.DateTime), DefaultValue("GETDATE()")]
        public DateTime CreateAt1 { get; set; }

        //----------------------------------------------  Страница 1  ----------------------------------------------//



        //----------------------------------------------  Страница 2  ----------------------------------------------//

        [Display(Name = "Создал ID")]
        public int id_nameUser2 { get; set; }

        [Display(Name = "Плотность шлама в ШБ")]
        public decimal? plotnSlimeInSB { get; set; }
        [Display(Name = "Процент содержания гипса в ШБ")]
        public decimal? procentGipsInSB { get; set; }

        [Display(Name = "Создано II ")]
        public DateTime CreateAt2 { get; set; }

        //----------------------------------------------  Страница 2  ----------------------------------------------//
        public SBDataLab() 
        {
            CreateAt1 = DateTime.Now;
            CreateAt2 = DateTime.Now;
        }

    }
}
