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
        public async Task<bool> AddEmployeeData(Addentry data)
        {
            try
            {
                var Result = await _EmployeeRepository.AddEmployeeData(data);
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
        public EmployeeID DeleteEmployee(int ID)
        {
            try
            {
                return _EmployeeRepository.DeleteEmployee(ID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for Update Excisting entry
        /// </summary>
        /// <param name="ID">Primary key</param>
        /// <param name="data">Update data</param>
        /// <returns></returns>
        public int UpdateEmployeeDetails(int ID,UpdateModel data)
        {
            try
            {
                var result = _EmployeeRepository.UpdateEmployeeDetails(ID, data);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        ///  API for get specific emplyee details
        /// </summary>
        /// <param name="ID"> get specific Entry</param>
        /// <returns></returns>
        public Gatedetails Getspecificemployee(int ID)
        {
            try
            {
                return _EmployeeRepository.Getspecificemployee(ID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for get all emplyee details
        /// </summary>
        public IEnumerable<Gatedetails> GetAllemployee()
        {
            try
            {
                return _EmployeeRepository.GetAllemployee();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
