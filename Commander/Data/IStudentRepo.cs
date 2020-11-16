// for the future, make it work with LDUP
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        
    }
}