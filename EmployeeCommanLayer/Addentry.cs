using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeCommanLayer
{
    public class Addentry
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Employee Name Is Required")]
        [RegularExpression("^[A-Z][a-zA-Z]{3,15}[ ][A-Z][a-zA-Z]{3,15}$", ErrorMessage = "Employee Name is not valid")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Username Is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Gender Is Required")]
        public string Gender { get; set; }
        public string City { get; set; }
        [Required(ErrorMessage = "EmailID Is Required")]
        [RegularExpression("^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$", ErrorMessage = "E-mail is not valid")]
        public string EmailID { get; set; }
        public string Designation { get; set; }
        public int WorkingExperience { get; set; }
    }
}
