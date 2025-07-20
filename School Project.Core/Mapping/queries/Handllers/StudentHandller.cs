using AutoMapper;
using MediatR;
using School_Project.Core.Bases;
using School_Project.Core.Mapping.queries.Models;
using School_Project.Core.Mapping.queries.Response;
using School_Project.Service.Abstracts;

namespace School_Project.Core.Mapping.queries.Handlers
{
    public class StudentHandler
        : ResponseHandler, IRequestHandler<GetStudentListQueries, Response<List<GetStudentListResponse>>>
    {
        #region Fields

        private readonly IstudentSrvice _studentService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public StudentHandler(IstudentSrvice studentService, IMapper mapper)
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

        #endregion
    }
}
