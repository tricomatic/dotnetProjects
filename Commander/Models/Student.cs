using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LName { get; set; }
        [Required]
        [MaxLength(20)]
        public string EUID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Major { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public Parent Parent { get; set; }
        //public byte[] ProfilePic { get; set; }
        //public string ProfilePicLink { get; set; }
    }
}
// Try uploading picture to database and filesystem