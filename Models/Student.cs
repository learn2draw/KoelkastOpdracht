using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fridge.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Student number")]
        public int Number { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(12, 100, ErrorMessage = "You can not be immortal.")]
        public int Age { get; set; }
    }
}