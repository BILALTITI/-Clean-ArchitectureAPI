using MediatR;
using School_Project.Core.Bases;
using School_Project.Core.Mapping.queries.Response;
using School_Project.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Core.Mapping.queries.Models
{
    public class GetStudentListQueries : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
