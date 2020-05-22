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
        Task<int> EmployeeLogin(Login data);
        //Interface method for Add Employee data
        Task<bool> AddEmployeeData(Addentry data);
        //Interface method for delete Employee detail
        EmployeeID DeleteEmployee(int ID);
        //Interface method for update Employee detail
        int UpdateEmployeeDetails(int ID, UpdateModel data);

        //Interface method for get Employee detail by id
        Gatedetails Getspecificemployee(int ID);
        //Interface method for get all Employee detail
        IEnumerable<Gatedetails> GetAllemployee();
    }
}
