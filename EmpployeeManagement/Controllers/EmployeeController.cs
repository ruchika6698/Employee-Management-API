﻿///-----------------------------------------------------------------
///   Class:       EmployeeController
///   Description: Employee API for register,login,update,delete,add,get,get by id
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using EmployeeBusinessLayer.Interface;
using EmployeeCommanLayer;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

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
                    var status = "Success";
                    var Message = "Registration Successfull";
                    return this.Ok(new { status, Message, Info });
                }
                else                                     //Registration Fail
                {
                    var status = "Unsuccess";
                    var Message = "Registration Failed";
                    return this.BadRequest(new { status, Message, data = Info });
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
                int Result = await BusinessLayer.EmployeeLogin(Info);
                var symmetricSecuritykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

                var signingCreds = new SigningCredentials(symmetricSecuritykey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, Info.Designation.ToString()),
                    new Claim("Username", Info.Username.ToString()),
                    new Claim("Password", Info.Password.ToString())
                };
                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(120),
                    signingCredentials: signingCreds);
                //if Result is not equal to null then Login sucessful
                if (Result != 0)
                {
                    var status = "Success";
                    var Message = "Login Successful";
                    var Token = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(new { status, Message,Token});
                }
                else                                        //Username or Password Incorrect
                {
                    var status = "Unsuccess";
                    var Message = "Invaid Username Or Password";
                    return BadRequest(new { status, Message, Result = Info });
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
        /// <param name="Info">Add new Entry</param>
        /// <returns></returns>
        [HttpPost]
        [Route("addnewentry")]
        public async Task<IActionResult> AddEmployeeData([FromBody]Addentry Info)
        {
            try
            {
                bool result = await BusinessLayer.AddEmployeeData(Info);
                //if entry is not equal to null then Login sucessful
                if (!result.Equals(null))
                {
                    var status = "Success";
                    var Message = "New Entry Added Sucessfully";
                    return this.Ok(new { status, Message, data=Info });
                }
                else                                              //Entry is not added
                {
                    var status = "Unsuccess";
                    var Message = "New Entry is not Added";
                    return this.BadRequest(new { status, Message, data=Info });
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
        /// <param name="ID">Delete data</param>
        /// <returns></returns>
        [HttpDelete("{ID}")]
        public IActionResult DeleteEmployee(int ID)
        {
            try
            {
                var result = BusinessLayer.DeleteEmployee(ID);
                //if result is not equal to zero then details Deleted sucessfully
                if (!result.Equals(null))
                {
                    var Status = "Success";
                    var Message = "Employee Data deleted Sucessfully";
                    return this.Ok(new { Status, Message, Data=ID });
                }
                else                                           //Data is not deleted 
                {
                    var Status = "Unsuccess";
                    var Message = "Employee Data is not deleted Sucessfully";
                    return this.BadRequest(new { Status, Message, Data=ID});
                }
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
        /// <param name="Info">Update data</param>
        /// <returns></returns>
        [HttpPut("{ID}")]
        public ActionResult UpdateEmployeeDetail([FromRoute]int ID, [FromBody]UpdateModel Info)
        {
            try
            {
                var response = BusinessLayer.UpdateEmployeeDetails(ID,Info);
                if (!response.Equals(null))
                {
                    var Status = "Success";
                    var Message = "Employee Data Updated Sucessfully";
                    return this.Ok(new { Status, Message, data= Info });
                }
                else
                {
                    var status = "Unsuccess";
                    var Message = "Employee Data not Updated";
                    return this.BadRequest(new { status, Message, data= Info });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        // <summary>
        ///  API for get specific emplyee details
        /// </summary>
        /// <param name="ID">Update data</param>
        /// <returns></returns>
        [HttpGet("{ID}")]
        public IActionResult Getspecificemployee(int ID)
        {
            try
            {
                var result = BusinessLayer.Getspecificemployee(ID);
                //if result is not equal to zero then details found
                if (!result.Equals(null))
                {
                    var Status = "Success";
                    var Message = "Employee Data found ";
                    return this.Ok(new { Status, Message, Data = result });
                }
                else                                           //Data is not found
                {
                    var Status = "Unsuccess";
                    var Message = "Employee Data is not found";
                    return this.BadRequest(new { Status, Message, Data = result });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///  API for get all emplyee details
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Gatedetails>> GetAllemployee()
        {
            try
            {
                var result = BusinessLayer.GetAllemployee();
                //if result is not equal to zero then details found
                if (!result.Equals(null))
                {
                    var Status = "Success";
                    var Message = "Employee Data found ";
                    return this.Ok(new { Status, Message, Data = result });
                }
                else                                           //Data is not found
                {
                    var Status = "Unsuccess";
                    var Message = "Employee Data is not found";
                    return this.BadRequest(new { Status, Message, Data = result });
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}