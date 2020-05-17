﻿using EmployeeCommanLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepositoryLayer.Interface
{
    public interface IEmployeeRepository
    {
        //Interface method for Employee Registration
        Task<bool> EmployeeRegister(EmployeeModel data);
        //Interface method for Employee Login
        Task<bool> EmployeeLogin(Login data);
        //Interface method for Add Employee data
        Task<bool> AddEmployeeData(EmployeeModel data);
        //Interface method for delete Employee detail
        Task<int> DeleteEmployee(EmployeeID Data);
        //Interface method for update Employee detail
        Task<int> UpdateEmployee(UpdateModel data);
        //Interface method for get Employee detail by id
        dynamic Getspecificemployee(UpdateModel data);
        //Interface method for get all Employee detail
        IEnumerable<UpdateModel> GetAllemployee();
    }
}
