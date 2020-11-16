using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockStudentRepo : IStudentRepo
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>
            {
                new Student{Id = 0, FName = "Yafet", LName = "Kubrom", EUID = "yak0001", Major = "Computer Science"},
                new Student{Id = 1, FName = "Saron", LName = "Kubrom", EUID = "sak0001", Major = "Accounting"},
                new Student{Id = 2, FName = "Yoel", LName = "Kubrom", EUID = "yak0002", Major = "Sport Manager"}
            };
            return students;
        }

        public Student GetStudentById(int id)
        {
            return new Student{Id = 0, FName = "Yafet", LName = "Kubrom", EUID = "yak0101", Major = "Computer Science"};
        }
    }
}

// first name and last name should have capital beginning