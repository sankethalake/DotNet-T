using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace truYum.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public MenuItem MenuItem { get; set; }
    }
}
