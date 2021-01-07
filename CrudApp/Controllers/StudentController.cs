using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApp.Interfaces;
using Domaindb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApp.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase

    {
        private IStudent _istudent;
        public StudentController(IStudent istudent)
        {
            _istudent = istudent;
        }

        [HttpPost]
                public IActionResult CreateStudents(Student student)
        {
            _istudent.CreateNewStudent(student);
            return Ok("Your data is saved successfully");            
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var studentinfo = _istudent.GetAllStudents();
            return Ok(studentinfo);
        }

        [HttpPut]
        public IActionResult UpdateStudents(Student student)
        {
            _istudent.UpdateStudent(student);
            return Ok(student);
        }
    }
}
