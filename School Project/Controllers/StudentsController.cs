using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_Project.Data.Entity;

namespace School_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly Department _Department ;
        public StudentsController(Department department) { 
        
            this._Department = department ;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _Department.Students.ToList();
            return Ok(students);
        }

    }
}
