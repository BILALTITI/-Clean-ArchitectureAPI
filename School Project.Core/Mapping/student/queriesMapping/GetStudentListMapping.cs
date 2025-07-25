using School_Project.Core.Features.student.queries.Results;
using School_Project.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Core.Mapping.student
{
public partial class studentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListResponse>().ForMember(dest => dest.departmentName, opt => opt.MapFrom(Src => Src.Department.DName));


        }
    }
}
