using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Features.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit(int pid, string pname)
        {
            ViewBag.PId = pid;
            ViewBag.PName = pname;
            return View("Index");
        }
    }
}