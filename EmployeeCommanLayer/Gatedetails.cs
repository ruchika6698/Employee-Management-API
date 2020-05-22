///-----------------------------------------------------------------
///   Class:       UpdateModel
///   Description: Poco class for Get all employee details
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeCommanLayer
{
    public class Gatedetails
    {
        public int ID { get; set; }
        [RegularExpression("^[A-Z][a-zA-Z]{3,15}[ ][A-Z][a-zA-Z]{3,15}$", ErrorMessage = "Employee Name is not valid")]
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        [Required(ErrorMessage = "EmailID Is Required")]
        [RegularExpression("^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$", ErrorMessage = "E-mail is not valid")]
        public string EmailID { get; set; }
        public string Designation { get; set; }
        public int WorkingExperience { get; set; }
    }
}
