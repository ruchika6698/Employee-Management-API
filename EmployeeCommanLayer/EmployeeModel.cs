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
        [EmailAddress]
        public string EmailID { get; set; }
        public string Designation { get; set; }
        public int WorkingExperience { get; set; }
    }
}
