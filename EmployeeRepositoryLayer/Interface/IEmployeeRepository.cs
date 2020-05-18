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
    }
}
