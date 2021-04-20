using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Api.Controllers
{
    #region StudentController
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students = new List<Student>()
            {
                new Student{StudentId =1, Fname = "Bibek", Lname="Shrees", UserName="Bibek", Password ="shrees"},
                new Student{StudentId =2, Fname = "Raju", Lname="Sharma", UserName="Raju", Password ="123456"},
                new Student{StudentId =3, Fname = "Hari", Lname="Gupta", UserName="Hari", Password ="123456"},
                new Student{StudentId =4, Fname = "Shyam", Lname="Sharma", UserName="Shyam", Password ="123456"},
                new Student{StudentId =5, Fname = "Kapil", Lname="Gupta", UserName="Kapil", Password ="123456"}
            };

        // GET: api/AllStudents

        // GET: api/Student
        [HttpGet]
        [Authorize]
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        [Authorize]
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student s = null;
            students.ForEach(delegate (Student student)
            {
                if (student.StudentId == id)
                {
                    s = student;
                }
            });
            return s;
        }
    }
}
#endregion