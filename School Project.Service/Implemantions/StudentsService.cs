using Microsoft.EntityFrameworkCore;
using School_Project.Data.Entity;
using School_Project.Infrastructure.Abstract;
using School_Project.Service.Abstracts;

namespace School_Project.Service.Implemantions
{
    public class StudentsService : IstudentSrvice
    {
        #region Fileds
        private readonly IStudentRepository _studentRepository;
        #endregion
        #region Constructure

        public StudentsService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<string> AddAsync(Student student)
        {
            // Check if student name already exists
            var exists = _studentRepository.GetTableNoTracking()
                 .Where(x => x.Name.Equals(student.Name)).FirstOrDefault();

            if (exists != null)
                return "This Student Name Is Exist , Please Chose Another Valid Name";

            // Add student
            await _studentRepository.AddAsync(student);
            return "Succes";
        }

        public async Task<string> EditAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
            return "Succes";


        }

        public async Task<Student> GetStudentsByIDAsync(int id)
        {

            //var student =await   _studentRepository.GetByIdAsync(id);
            var student = _studentRepository.GetTableNoTracking().Include(D => D.Department).Where(Id => Id.StudID.Equals(id)).FirstOrDefault();

            return student;
        }

        public async Task<bool> IsNameExsist(string Name)
        {
            var student = _studentRepository.GetTableNoTracking()
                .Where(x => x.Name.Equals(Name)).FirstOrDefault();

            if (student == null) return false;
            return true;
        }
        public async Task<bool> IsNameExsistExcludeSelf(string name, int id)
        {
            var student = await _studentRepository.GetTableNoTracking()
                .Where(x => x.Name == name && x.StudID != id)
                .FirstOrDefaultAsync();

            return student != null;
        }

        #endregion

        #region Handlle Functions
        async Task<List<Student>> IstudentSrvice.GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsAsync();


        }
        #endregion
    }
}
