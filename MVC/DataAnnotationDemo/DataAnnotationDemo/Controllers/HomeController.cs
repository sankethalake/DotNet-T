using DataAnnotationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult StudentDetails(StudentModel sm)
        //{
        //    if (string.IsNullOrEmpty(sm.Name)) ModelState.AddModelError("Name", "Name is Required");
        //    if (sm.Age == 0 || sm.Age > 120) ModelState.AddModelError("age", "Valid age is required");

        //    if (!ModelState.IsValid)
        //    {
        //        ViewBag.Name = "no data";
        //        ViewBag.Age = "no data";
        //        return View("Index");
                
        //    }
        //    ViewBag.Name = sm.Name;
        //    ViewBag.Age = sm.Age;
        //    return View("Index");

        //}

        [HttpPost]
        public ActionResult StudentDetails(StudentModel sm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Id = "No data";
                ViewBag.Name = "No data";
                ViewBag.Email = "No data";
                ViewBag.Age = "No data";
                return View("Index");
            }
            ViewBag.Id = sm.Id;
            ViewBag.Name = sm.Name;
            ViewBag.Email = sm.Email;
            ViewBag.Age = sm.Age;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}