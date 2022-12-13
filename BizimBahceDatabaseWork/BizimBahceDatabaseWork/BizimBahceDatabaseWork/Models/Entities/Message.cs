using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        public string MsgOwner { get; set; }

        public string MsgMail { get; set; }

        public string MsgTitle { get; set; }

        public string MsgContent { get; set; }
    }
}
