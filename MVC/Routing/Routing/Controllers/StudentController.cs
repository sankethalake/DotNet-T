using Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [Route("")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }

        [Route("{id}")]
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [Route("{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address);
            return View(studentAddress);
        }


        public List<Student> Students()
        {
            return new List<Student>()
            {
                new Student{Address = new Address { Address1 = "Student1 Address", City = "Mumbai", HomeNumber = "Student1"}, 
                    Name = "Sanket" , Class = "First", Id = 101},
                new Student{Address = new Address { Address1 = "Student2 Address", City = "Pune", HomeNumber = "Student2"},
                    Name = "Yash" , Class = "Second", Id = 102},
                new Student{Address = new Address { Address1 = "Student3 Address", City = "Mumbai", HomeNumber = "Student3"},
                    Name = "Anant" , Class = "Third", Id = 103},
                new Student{Address = new Address { Address1 = "Student4 Address", City = "Mumbai", HomeNumber = "Student4"},
                    Name = "JAy" , Class = "First", Id = 104}
            };
        }
    }
}