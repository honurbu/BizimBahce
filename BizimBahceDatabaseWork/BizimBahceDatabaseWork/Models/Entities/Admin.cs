using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        public string Username { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public string About { get; set; }
    }
}
