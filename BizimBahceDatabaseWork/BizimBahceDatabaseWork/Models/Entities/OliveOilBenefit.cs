using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class OliveOilBenefit
    {
        [Key]
        public int OliveOilBenefitID { get; set; }

        public string OliveOilBenefitDescription { get; set; }

        public List<OliveOil> OliveOils { get; set; }

    }
}
