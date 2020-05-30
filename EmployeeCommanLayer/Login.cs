///-----------------------------------------------------------------
///   Class:       Login
///   Description: Poco class for all Login employee details
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeCommanLayer
{
    public class Login
    {
        [Required(ErrorMessage = "Username Is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [RegularExpression("^.{8,30}$", ErrorMessage = "Password Length should be between 8 to 15")]
        public string Password { get; set; }
        public string Designation { get; set; }
    }
}
