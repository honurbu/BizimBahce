using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class OliveOilProperty
    {
        [Key]
        public int OliveOilPropertyID { get; set; }

        public string OliveOilDescription { get; set; }

        public float OliveOilAsidic { get; set; }

        public float OliveOilLiter { get; set; }

        public List<OliveOil> OliveOils { get; set; }

    }
}
