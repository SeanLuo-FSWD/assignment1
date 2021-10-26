using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace assignment1.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number")]
        [MaxLength(15)]
        public string MobileNumber { get; set; }

        [Display(Name = "Email Address")]
        [MaxLength(200)]
        public string EmailAddress { get; set; }

        [Display(Name = "City of residence")]
        [MaxLength(25)]
        public string City { get; set; }

        [MaxLength(25)]
        public string Specialization { get; set; }

        public Student()
        {
        }
    }
}
