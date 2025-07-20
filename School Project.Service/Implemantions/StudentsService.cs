using School_Project.Data.Entity;
using School_Project.Infrastructure.Abstract;
using School_Project.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

        #region Handlle Functions
        async Task<List<Student>> IstudentSrvice.GetStudentsListAsync()
        { 
 return await _studentRepository.GetStudentsAsync();

                
                }
        #endregion
    }
}
