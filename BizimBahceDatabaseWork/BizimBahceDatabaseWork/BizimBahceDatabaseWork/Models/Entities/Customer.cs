using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string CustomerProvince { get; set; }

        public List<Comment> Comments { get; set; }

        public string CustomerMail { get; set; }

    }
}
