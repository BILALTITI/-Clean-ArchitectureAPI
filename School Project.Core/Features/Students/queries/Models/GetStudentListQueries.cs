using MediatR;
using School_Project.Core.Bases;
using School_Project.Core.Features.student.queries.Results;
using School_Project.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Core.Features.student.queries.Models
{
    public class GetStudentListQueries : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
