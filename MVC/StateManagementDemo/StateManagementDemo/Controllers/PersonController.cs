using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        //public ActionResult Index()
        //{
        //    Person pojb = new Person { PId = 101, Address = "Pune", Name = "Sanket" };
        //    ViewData["person"] = pojb;
        //    ViewData["Header"] = "Person Profile Info";
        //    return View();
        //}
        public ActionResult Index()
        {
            List<string> Courses = new List<string>();
            Courses.Add("JAVA");
            Courses.Add("C");
            Courses.Add("C++");
            Courses.Add("Spring");
            Courses.Add("J2EE");
            ViewData["Courses"] = Courses;
            return View();
        }

        public ActionResult ViewProfile()
        {
            Person pojb = new Person { PId = 105, Address = "Mumbai", Name = "Anant" };
            ViewBag.Person = pojb;
            ViewBag.Header = "Employee Profile";
            return View();

        }
    }
}