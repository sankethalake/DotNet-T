﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementDemo.Controllers
{
    public class AccountController : Controller
    {        
            // GET: Account
            [HttpGet]
            public ActionResult Index()
            {
                return View();
            }



            [HttpPost]
            public ActionResult Login(string username, string password)
            {
                if (username.Equals("acc1") && password.Equals("123"))
                {
                    Session["username"] = username;
                    return View("Success");
                }
                else
                {
                    ViewBag.error = "Invalid Account";
                    return View("Index");
                }
            }



            [HttpGet]
            public ActionResult Logout()
            {
                Session.Remove("username");
                return RedirectToAction("Index");
            }
        
    }
}