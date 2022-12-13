using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class OliveOilType
    {
        [Key]
        public int OliveOilTypeID  { get; set; } 

        public string OliveOilDescription { get; set; }

        public List<OliveOil> OliveOils { get; set; }
    }
}
