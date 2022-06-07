using ExceptionExtensionDemo.Models;
using ExceptionExtensionDemo.MyFilter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionExtensionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id=null)
        {
            if (id == 1) throw new System.IO.FileNotFoundException("file not found exception thrown in index.cshtml");
            else if (id == 2) return StatusCode(200);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [TypeFilter(typeof(CustomExceptionFilter))]
        public IActionResult Failing()
        {
            throw new Exception("Testing Custom Exception Filter");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
