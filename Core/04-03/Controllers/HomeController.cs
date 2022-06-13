﻿using _04_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _04_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ITOrganizations()
        {
            return View(new List<string>
            {
                "Microsoft www.microsoft.com","CTS  www.cognizant.com","Google","Amazon","TCS"
            });
        }

        public IActionResult GetEmployeeList()
        {
            var emp = new List<Employee> { 
                new Employee {ID=1, Name= "John", Salary = 10000,Permanent = true },
                new Employee {ID=2, Name= "Smith", Salary = 5000,Permanent = false },
                new Employee {ID=3, Name= "Mark", Salary = 5000,Permanent = false },
                new Employee {ID=4, Name= "Mary", Salary = 5000,Permanent = false },
            };

            return View(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
