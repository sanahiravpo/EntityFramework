using EntityFramework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_student.GetAllStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(_student.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDTO student)
        {

            _student.AddStudent(student);
            return Ok();



        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _student.DeleteStudent(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatestudent)
        {

            _student.UpdateStudent(id, updatestudent);
            return NoContent();
        }
       
    }
}
