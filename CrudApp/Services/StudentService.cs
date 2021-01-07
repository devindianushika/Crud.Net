using CrudApp.Interfaces;
using Domaindb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Services
{
    public class StudentService : IStudent
    {
        private readonly ICommonRepository<Student>_commonRepository;
            public StudentService(ICommonRepository<Student>commonRepository)
        {
            _commonRepository = commonRepository;
        }


        public void CreateNewStudent(Student student) {
           // var student = new Student();
            _commonRepository.Create(student);
        }
        public IEnumerable<Student>GetAllStudents()
        {
          var studentinfo = _commonRepository.GetAll();
            return studentinfo;
        }

        public void UpdateStudent(Student student)
        {
            _commonRepository.Update(student);
        }

        public void GetStudentByID()
        {

        }

        public void DeleteStudent()
        {

        }
    }
}
