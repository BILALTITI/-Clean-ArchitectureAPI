using MediatR;
using School_Project.Core.Bases;

namespace School_Project.Core.Features.student.Commands.Models
{
    public class AddStudentCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        public int DepartmentId { get; set; }
    }

}
