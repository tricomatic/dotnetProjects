using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly StudentContext _context;

        public SqlStudentRepo(StudentContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Parent GetParentByStudentId(int id)
        {
            return _context.Parents.FirstOrDefault(p => p.Id == id);
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(p => p.Id == id);
        }
    }
}