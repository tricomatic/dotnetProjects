using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Parent
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LName { get; set; }
        public List<Student> Students { get; set; }
    }
}