using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repository;
        public StudentsController(IStudentRepo repository)
        {
            _repository = repository;
        }

        //Get api/students
        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAllStudents()
        {
            var students = _repository.GetAllStudents();
            return Ok(students);
        }

        //Get api/students/5
        [HttpGet("{id}")]
        public ActionResult <Student> GetStudentById(int id)
        {
            var student = _repository.GetStudentById(id);
            return Ok(student);
        }
    }
}

// look into binding sources on microsoft docs