///-----------------------------------------------------------------
///   Class:       IEmployeeRepository
///   Description: Repository Layer Interface for employee
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using EmployeeCommanLayer;
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
        UpdateModel Getspecificemployee(int ID);
    }
}
