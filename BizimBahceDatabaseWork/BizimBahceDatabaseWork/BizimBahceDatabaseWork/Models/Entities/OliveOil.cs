using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class OliveOil
    {
        [Key]
        public int OliveOilsID { get; set; }

        public int OliveOilTypeID { get; set; }

        public int OliveOilPropertyID { get; set; }

        public int OliveOilBenefitID { get; set; }

        public int OliveOilPriceID { get; set; }

        public OliveOilType OliveOilType { get; set; }

        public OliveOilProperty OliveOilProperty { get; set; }

        public OliveOilPrice OliveOilPrice { get; set; }

        public OliveOilBenefit OliveOilBenefit { get; set; }
    }
}
