using AutoMapper;

namespace School_Project.Core.Mapping.student
{
    public partial class studentProfile : Profile
    {

        public studentProfile()
        {
            GetStudentListMapping();
            GetStudenByIDMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();

        }
    }
}
