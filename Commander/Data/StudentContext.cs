using Commander.Models;
using Microsoft.EntityFrameworkCore;


namespace Commander.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> opt) : base(opt)
        {
            
        }


        public DbSet<Student> Students {get; set;}
        public DbSet<Parent> Parents {get; set;}
    }
}