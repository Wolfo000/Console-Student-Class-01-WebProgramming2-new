using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.Interfaces;

namespace Console_Student_Class_01
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService (IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task DisplayStudentListAsync()
        {
            var students = await _studentRepository.GetAllAsync();
        }

    }
}
