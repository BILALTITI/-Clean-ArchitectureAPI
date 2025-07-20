using School_Project.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Service.Abstracts
{
    public interface   IstudentSrvice
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
