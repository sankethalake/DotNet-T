using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            Dept dobj = new Dept { DeptNo = 100, DName = "Marketing", loc = "Mumbai"};
            return View(dobj);
        }

        public ActionResult GetRecords()
        {
            List<Dept> lobj = new List<Dept>
            {
                new Dept { DeptNo = 100, DName = "Marketing", loc = "Mumbai" },
                new Dept { DeptNo = 101, DName = "research", loc = "Pune" },
                new Dept { DeptNo = 102, DName = "admin", loc = "HYD" },
                new Dept { DeptNo = 103, DName = "sales", loc = "BAn" },
            };
            
            return View(lobj);
        }
    }
}