using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School_Project.Core.Bases;
using School_Project.Core.Features.student.Commands.Models;
using School_Project.Core.Features.Students.Commands.Models;
using School_Project.Data.Entity;
using School_Project.Service.Abstracts;

namespace School_Project.Core.Features.student.Commands.Handllers
{
    public class StudentCommandHandller : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>, IRequestHandler<EditStudentCommand, Response<string>>
    {
        #region Fileds

        private readonly IstudentSrvice _studentSrvice;
        private readonly IMapper _Mapper;
        #endregion

        #region Constructer

        public StudentCommandHandller(IstudentSrvice studentSrvice, IMapper mapper)
        {
            _studentSrvice = studentSrvice; // ✅ Correct assignment
            _Mapper = mapper;
        }

        #endregion
        #region function Handller
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var studentMapper = _Mapper.Map<Student>(request);
                var result = await _studentSrvice.AddAsync(studentMapper);


                if (result == "Succes")
                    return Created<string>("Added successfully");

                return BadRequest<string>($"{result}");
            }
            catch (DbUpdateException ex)
            {
                return BadRequest<string>($"DB Update Error: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest<string>($"Unhandled Error: {ex.Message}");
            }
        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            // Check if ID exists
            var student = await _studentSrvice.GetStudentsByIDAsync(request.Id);

            if (student == null)
                return NotFound<string>("Student Not Found");

            // Map only updated fields into existing student
            _Mapper.Map(request, student);

            var result = await _studentSrvice.EditAsync(student);

            if (result == "Succes")
                return SuccessEdit<string>($"Edit successfully with Id {student.StudID}");
            else
                return BadRequest<string>("Unknown error");
        }



        #endregion
    }
}
