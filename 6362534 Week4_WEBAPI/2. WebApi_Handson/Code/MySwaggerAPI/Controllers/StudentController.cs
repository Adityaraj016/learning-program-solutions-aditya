using Microsoft.AspNetCore.Mvc;
using MySwaggerAPI.Models;

namespace MySwaggerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Course = "BCA" },
            new Student { Id = 2, Name = "Bob", Course = "MCA" }
        };

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<Student> AddStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }
    }
}
