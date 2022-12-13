using System.ComponentModel.DataAnnotations;

namespace BizimBahceDatabaseWork.Models.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }

        public string SocialMediaInstagram { get; set; }

        public string SocialMediaFace { get; set; }
    }
}
