///-----------------------------------------------------------------
///   Class:       UpdateModel
///   Description: Poco class for all update employee details
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeCommanLayer
{
    public class UpdateModel
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string EmailID { get; set; }
        public string Designation { get; set; }
        public int WorkingExperience { get; set; }
    }
}
