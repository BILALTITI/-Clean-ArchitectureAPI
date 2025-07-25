using School_Project.Core.Features.Students.Commands.Models;
using School_Project.Data.Entity;

namespace School_Project.Core.Mapping.student
{
    public partial class studentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
                      .ForMember(dest => dest.DID, opt => opt.MapFrom(src => src.departmentId))
             ;//         .ForMember(dest => dest.DID, opt => opt.MapFrom(src => src.s));

        }
    }
}
