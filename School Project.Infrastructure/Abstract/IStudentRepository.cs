using School_Project.Data.Entity;
using School_Project.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Infrastructure.Abstract
{
    public interface IStudentRepository:IGenericRepositoryAsync<Student>
    {
        public Task <List<Student>>GetStudentsAsync ();
    }
}
