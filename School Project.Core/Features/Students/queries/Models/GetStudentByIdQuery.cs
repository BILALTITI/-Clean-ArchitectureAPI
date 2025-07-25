using MediatR;
using School_Project.Core.Bases;
using School_Project.Core.Features.student.queries.Results;
using School_Project.Data.Entity;
using School_Project.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Core.Features.student.queries.Models
{
    public class GetStudentByIdQuery:IRequest<Response<GetsingleStudentResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id=id;
        }
    }
}
