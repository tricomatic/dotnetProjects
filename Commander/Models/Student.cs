namespace Commander.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string EUID { get; set; }
        public string Major { get; set; }
        //public byte[] ProfilePic { get; set; }
        //public string ProfilePicLink { get; set; }
    }
}
// Try uploading picture to database and filesystem