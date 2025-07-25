using AutoMapper;
using School_Project.Core.Features.student.Commands.Models;
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
        public void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommand, Student>()
                      .ForMember(dest => dest.DID, opt => opt.MapFrom(src => src.DepartmentId)); // Map DepartmentId → DID
              
    }
}
}
