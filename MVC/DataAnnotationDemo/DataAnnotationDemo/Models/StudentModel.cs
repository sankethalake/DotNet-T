using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class StudentModel
    {
        //public string Name { get; set; }
        //public int Age{ get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 10)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email  is required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(40)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age  is required")]
        [Range(1, 120, ErrorMessage = "Enter valid Age")]
        public int Age { get; set; }
    }
}