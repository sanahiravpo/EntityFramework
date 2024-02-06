using EntityFramework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmen _department;
        public DepartmentController(IDepartmen department)
        {
            _department = department;
        }
        [HttpPost]
        public IActionResult AddDepartment([FromBody]DepartmentDTO department) {


            _department.AddDepartment( department);
            return Ok(department);

        }
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return Ok(_department.GetAllDepartments());
        }
        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {

            return Ok(_department.GetDepartmentById(id));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            _department.DeleteDepartment(id);
            return NoContent();
        }


        [HttpPut]
        public IActionResult UpdateDepartment(int id, [FromBody] DepartmentDTO updatedepartment)
        {
           
            _department.UpdateDepartment(id,updatedepartment);
            return NoContent();
        }
    }
}
