using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_Project.Core.Mapping.queries.Models;

namespace School_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public StudentController(IMediator mediatR)
        {
            _mediatR = mediatR ?? throw new ArgumentNullException(nameof(mediatR));
        }
        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetStudentList()
        {
            var studentsResponse =await _mediatR.Send(new GetStudentListQueries());
            return Ok(studentsResponse);
        }
    }
}
