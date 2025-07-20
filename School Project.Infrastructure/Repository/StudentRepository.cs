using Microsoft.EntityFrameworkCore;
using School_Project.Data.Entity;
using School_Project.Infrastructure.Abstract;
using School_Project.Infrastructure.Data;
using School_Project.Infrastructure.InfrastructureBases;

namespace School_Project.Infrastructure.Repository
{
    public class StudentRepository :GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region Fileds
        private readonly DbSet<Student>_StudentRepository;

        #endregion
        #region COnstructure

        public StudentRepository(ApplicationDBContext dBContext):base (dBContext)  
        {
            _StudentRepository = dBContext.Set<Student>();
          }
        #endregion

        #region  Handlle Function 

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _StudentRepository.Include(X=>X.Department).ToListAsync();

        }
        #endregion
    }
}
