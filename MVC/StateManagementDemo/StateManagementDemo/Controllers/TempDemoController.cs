using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class TempDemoController : Controller
    {
        // GET: TempDemo
        public ActionResult Index()
        {
            Person pobj = new Person { PId = 400, Address = "Kolhapur", Name = "ankit" };
            TempData["data"] = pobj;
            return RedirectToAction("Index", "Result");
        }
    }
}