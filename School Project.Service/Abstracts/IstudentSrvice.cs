using School_Project.Data.Entity;

namespace School_Project.Service.Abstracts
{
    public interface IstudentSrvice
    {
        public Task<List<Student>> GetStudentsListAsync();
        public Task<Student> GetStudentsByIDAsync(int id);
        public Task<string> AddAsync(Student student);
        public Task<string> EditAsync(Student student);
        public Task<bool> IsNameExsist(string Name);
        public Task<bool> IsNameExsistExcludeSelf(string Name, int Id);
    }
}
