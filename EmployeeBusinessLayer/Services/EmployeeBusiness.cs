///-----------------------------------------------------------------
///   Class:       IEmployeeBusinessLayer
///   Description: Business Layer Services for employee
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using EmployeeBusinessLayer.Interface;
using EmployeeCommanLayer;
using EmployeeRepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeBusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusinessLayer
    {
        private IEmployeeRepository _EmployeeRepository;
        public EmployeeBusiness(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
        /// <summary>
        ///  API for Registrion
        /// </summary>
        /// <param name="data"> store the Complete Employee information</param>
        /// <returns></returns>
        public async Task<bool> EmployeeRegister(EmployeeModel data)
        {
            try
            {
                var Result = await _EmployeeRepository.EmployeeRegister(data);
                //if result is not equal null then return true
                if (!Result.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        ///  API for Login
        /// </summary>
        /// <param name="data"> Login API</param>
        /// <returns></returns>
        public async Task<bool> EmployeeLogin(Login data)
        {
            try
            {
                var Result = await _EmployeeRepository.EmployeeLogin(data);
                //if result is not equal null then return true
                if (!Result.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        ///  API for Add new entry
        /// </summary>
        /// <param name="data">Add new Entry</param>
        /// <returns></returns>
        public async Task<bool> AddEmployeeData(EmployeeModel data)
        {
            try
            {
                var Result = await _EmployeeRepository.EmployeeRegister(data);
                //if result is not equal null then return true
                if (!Result.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for Delete data
        /// </summary>
        /// <param name="Data">Delete data</param>
        /// <returns></returns>
        public async Task<int> DeleteEmployee(EmployeeID Data)
        {
            try
            {
                int Result = await _EmployeeRepository.DeleteEmployee(Data);
                if (Result == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
