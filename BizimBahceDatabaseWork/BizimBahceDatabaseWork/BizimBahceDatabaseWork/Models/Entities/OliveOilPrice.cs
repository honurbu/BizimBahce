using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class OliveOilPrice
    {
        [Key]
        public int OliveOilPriceID { get; set; }

        public float OliveOilPriceLiter { get; set; }

        public List<OliveOil> OliveOils { get; set; }

    }
}
