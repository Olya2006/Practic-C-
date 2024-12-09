using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsController()
        {
            _studentService = new StudentService();
        }

        [HttpGet]
        public IActionResult GetAllStudents() => Ok(_studentService.GetAllStudents());

        [HttpGet("{name}")]
        public IActionResult GetStudentByName(string name)
        {
            var student = _studentService.GetStudentByName(name);
            return student == null ? NotFound() : Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentByName), new { name = student.Name }, student);
        }

        [HttpPut("{name}")]
        public IActionResult UpdateStudent(string name, Student updatedStudent)
        {
            if (!_studentService.UpdateStudent(name, updatedStudent)) return NotFound();
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult DeleteStudent(string name)
        {
            if (!_studentService.DeleteStudent(name)) return NotFound();
            return NoContent();
        }
    }
}
