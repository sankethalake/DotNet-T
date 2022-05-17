using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FluentApiDemp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string MidName{ get; set; }
        public string LastName { get; set; }

    }

    public class StudentDetailsContext : DbContext
    {
        public StudentDetailsContext() : base("my")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey<int>(s => s.Id);
            modelBuilder.Entity<Student>().Property(s => s.FirstName).HasMaxLength(20);
            modelBuilder.Entity<Student>().Property(s => s.FirstName).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.MidName).IsOptional();
            modelBuilder.Entity<Student>().Property(s => s.LastName).IsOptional();
        }
        public DbSet<Student> StudentDetails { get; set; }
    }
}