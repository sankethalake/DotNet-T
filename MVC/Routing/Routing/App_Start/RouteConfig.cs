using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "student",
            //    url: "students",
            //    defaults: new { controller = "Student", action = "GetAllStudents"}
            //);

            //routes.MapRoute(
            //    name: "allStudents",
            //    url: "students/{id}",
            //    defaults: new { controller = "Student", action = "GetStudent" }
            //);

            //routes.MapRoute(
            //    name: "studentAddress",
            //    url: "students/{id}/Address",
            //    defaults: new { controller = "Student", action = "GetStudentAddress" }
            //);

            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
