using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public string CommentTitle { get; set; }

        public string CommentSubject { get; set; }

        public bool IsActive { get; set; }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
    }
}
