﻿///-----------------------------------------------------------------
///   Class:       EmployeeController
///   Description: Employee API for register,login,update,delete,add,get,get by id
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBusinessLayer.Interface;
using EmployeeCommanLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EmpployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IConfiguration _config;
        IEmployeeBusinessLayer BusinessLayer;

        public EmployeeController(IEmployeeBusinessLayer BusinessDependencyInjection, IConfiguration config)
        {
            BusinessLayer = BusinessDependencyInjection;
            _config = config;
        }

        /// <summary>
        ///  API for Registrion
        /// </summary>
        /// <param name="Info"> store the Complete Employee information</param>
        /// <returns></returns>
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> EmployeeRegister([FromBody] EmployeeModel Info)
        {
            try
            {
                bool data = await BusinessLayer.EmployeeRegister(Info);
                //if data is not equal to null then Registration sucessful
                if (!data.Equals(null))
                {
                    var status = "True";
                    var Message = "Registration Successfull";
                    return this.Ok(new { status, Message, Info });
                }
                else                                     //Registration Fail
                {
                    var status = "False";
                    var Message = "Registration Failed";
                    return this.BadRequest(new { status, Message, Info });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { error = e.Message });
            }
        }
        /// <summary>
        ///  API for Login
        /// </summary>
        /// <param name="Info"> Login API</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> EmployeeLogin([FromBody] Login Info)
        {
            try
            {
                var Result = await BusinessLayer.EmployeeLogin(Info);
                //if Result is not equal to null then Login sucessful
                if (!Result.Equals(null))
                {
                    var status = "True";
                    var Message = "Login Successful";
                    return Ok(new { status, Message, Info });
                }
                else                                        //Username or Password Incorrect
                {
                    var status = "False";
                    var Message = "Invaid Username Or Passoword";
                    return BadRequest(new { status, Message, Info });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}