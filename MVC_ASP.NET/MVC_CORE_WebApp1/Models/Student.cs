using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CORE_WebApp1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Rollno cant be left blank")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Name cant be left blank")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name should be between 2 and 20 characters")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age should be between 18 and 60")]
        public int Age { get; set; }

        public string Address { get; set; }
    }
}
