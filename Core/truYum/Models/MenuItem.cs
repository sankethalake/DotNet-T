using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace truYum.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double price { get; set; }

        public bool Active { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Launch")]
        public DateTime DateOfLaunch { get; set; }

        [ForeignKey("Id")]
        public Category Category { get; set; }

        [Display(Name ="Free Delivery")]
        public bool FreeDelivery { get; set; }

        
    }
}
