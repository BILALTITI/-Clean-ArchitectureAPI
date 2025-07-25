using AutoMapper;
using MediatR;
using School_Project.Core.Bases;
using School_Project.Core.Features.student.queries.Models;
using School_Project.Core.Features.student.queries.Results;
using School_Project.Service.Abstracts;

namespace School_Project.Core.Features.student.queries.Handllers
{
    public class StudentQueryHandller
        : ResponseHandler, IRequestHandler<GetStudentListQueries, Response<List<GetStudentListResponse>>>,
        IRequestHandler<GetStudentByIdQuery, Response<GetsingleStudentResponse>> 
    {
        #region Fields

        private readonly IstudentSrvice _studentService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public StudentQueryHandller(IstudentSrvice studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        #endregion

        #region Handle Function

        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQueries request, CancellationToken cancellationToken)
        {
            var studentList = await _studentService.GetStudentsListAsync();
            var mappedStudents = _mapper.Map<List<GetStudentListResponse>>(studentList);
            return Success(mappedStudents);
        }

        public async Task<Response<GetsingleStudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var Student =await  _studentService.GetStudentsByIDAsync(request.Id);
            if (Student== null)
            {
                return NotFound<GetsingleStudentResponse>($"  Student With Id {request.Id} Not Found ");
            }
            var Result = _mapper.Map<GetsingleStudentResponse>(Student);
            return Success(Result);
        }

        #endregion
    }
}
