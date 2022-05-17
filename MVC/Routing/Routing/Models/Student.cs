using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routing.Models
{
    public class Address
    {
        public string HomeNumber { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Class { get; set; }

        public Address Address { get; set; }
    }
}