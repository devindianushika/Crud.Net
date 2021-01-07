using Domaindb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Interfaces
{
   public interface IStudent
    {
        public void CreateNewStudent(Student student);
        public IEnumerable<Student> GetAllStudents();

        public void UpdateStudent(Student student);

        public void GetStudentByID();

        public void DeleteStudent();

    }
}
