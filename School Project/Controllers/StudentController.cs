using Microsoft.AspNetCore.Mvc;
using School_Project.Base;
using School_Project.Core.Features.student.Commands.Models;
using School_Project.Core.Features.student.queries.Models;
using School_Project.Core.Features.Students.Commands.Models;
namespace School_Project.Controllers
{
    [ApiController]
    public class StudentController : AppControllerBase
    {


        [HttpGet(School_Project.Data.AppMetaData.Router.StudentRouting.List)]
        public async Task<IActionResult> GetStudentList()
        {
            var studentsResponse = await Mediator.Send(new GetStudentListQueries());
            return Ok(studentsResponse);
        }
        [HttpGet(School_Project.Data.AppMetaData.Router.StudentRouting.GetById)]
        public async Task<IActionResult> GetStudenByID([FromRoute] int id)
        {
            var studentsResponse = await Mediator.Send(new GetStudentByIdQuery(id));
            return NewResult(studentsResponse);
        }
        [HttpPost(School_Project.Data.AppMetaData.Router.StudentRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddStudentCommand command)
        {
            var response = await Mediator.Send(command); // line 33
            return NewResult(response);
        }
        [HttpPut(School_Project.Data.AppMetaData.Router.StudentRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditStudentCommand command)
        {
            var response = await Mediator.Send(command); // line 33
            return NewResult(response);
        }

    }
}
