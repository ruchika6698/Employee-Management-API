///-----------------------------------------------------------------
///   Class:       EmployeeModel
///   Description: Poco class for all employee details
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCommanLayer
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Employee Name Is Required")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Username Is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }
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
