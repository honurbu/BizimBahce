using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        
        public string Mission { get; set; }

        public string Vision { get; set; }
    }
}
