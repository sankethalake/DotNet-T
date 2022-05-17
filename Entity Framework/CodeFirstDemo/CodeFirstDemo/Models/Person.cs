using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }

    public class PersonDetailsContext : DbContext
    {
        public PersonDetailsContext() : base("my")
        {

        }
        public DbSet<Person> PersonDetails { get; set; }
    }
}