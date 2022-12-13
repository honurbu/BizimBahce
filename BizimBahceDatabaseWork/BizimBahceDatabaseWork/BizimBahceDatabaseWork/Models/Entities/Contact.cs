using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        public string ContactAddress { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ContactMail { get; set; }
    }
}
