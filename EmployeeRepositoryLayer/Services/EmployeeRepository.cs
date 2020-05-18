///-----------------------------------------------------------------
///   Class:       EmployeeRepository
///   Description:Employee Repository and database connectivity using ado.net
///   Author:      Ruchika                   Date: 18/5/2020
///-----------------------------------------------------------------
using EmployeeCommanLayer;
using EmployeeRepositoryLayer.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmployeeRepositoryLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration configuration;

        public EmployeeRepository(IConfiguration configur)
        {
            configuration = configur;
        }
        /// <summary>
        ///  database connection for Registrion
        /// </summary>
        /// <param name="data"> store the Complete Employee information</param>
        /// <returns></returns>
        public async Task<bool> EmployeeRegister(EmployeeModel data)
        {
           try
           {
                SqlConnection connection = DatabaseConnection();
                //password encrption
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
                //for store procedure and connection to database
                SqlCommand command = StoreProcedureConnection("spRegisterEmployeeManagement", connection);
                command.Parameters.AddWithValue("@EmployeeName", data.EmployeeName);
                command.Parameters.AddWithValue("@Username", data.Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Gender", data.Gender);
                command.Parameters.AddWithValue("@City", data.City);
                command.Parameters.AddWithValue("@EmailID", data.EmailID);
                command.Parameters.AddWithValue("@Designation", data.Designation);
                command.Parameters.AddWithValue("@WorkingExperience", data.WorkingExperience);
                connection.Open();
                int Response = await command.ExecuteNonQueryAsync();
                connection.Close();
                if (Response != 0)
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
        ///   database connection for Login
        /// </summary>
        /// <param name="data"> Login API</param>
        /// <returns></returns>
        public async Task<bool> EmployeeLogin(Login data)
        {
            try
            {
                SqlConnection connection = DatabaseConnection();
                //password encrption
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
                //for store procedure and connection to database
                SqlCommand command = StoreProcedureConnection("spEmployee_login", connection);
                command.Parameters.AddWithValue("@Username", data.Username);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                int Response = await command.ExecuteNonQueryAsync();
                connection.Close();
                if (Response != 0)
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
        ///  database connection for Add new entry
        /// </summary>
        /// <param name="data">Add new Entry</param>
        /// <returns></returns>
        public async Task<bool> AddEmployeeData(EmployeeModel data)
        {
            try
            {
                SqlConnection connection = DatabaseConnection();
                //password Encryption
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
                //for store procedure and connection to database 
                SqlCommand command = StoreProcedureConnection("spAddnewEntry", connection);
                command.Parameters.AddWithValue("@EmployeeName", data.EmployeeName);
                command.Parameters.AddWithValue("@Username", data.Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Gender", data.Gender);
                command.Parameters.AddWithValue("@City", data.City);
                command.Parameters.AddWithValue("@EmailID", data.EmailID);
                command.Parameters.AddWithValue("@Designation", data.Designation);
                command.Parameters.AddWithValue("@WorkingExperience", data.WorkingExperience);
                connection.Open();
                int Response = await command.ExecuteNonQueryAsync();
                connection.Close();
                if (Response != 0)
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
        ///  database connection with connection string
        /// </summary>
        private SqlConnection DatabaseConnection()
        {
            //connection string
            string connectionString = configuration.GetSection("ConnectionStrings").GetSection("EmployeeData").Value;
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// sqlcommand for storeprocedure
        /// </summary>
        /// <param name="Procedurename">Store Procedure</param>
        /// <param name="connection">sql connection</param>
        /// <returns></returns>
        public SqlCommand StoreProcedureConnection(string Procedurename, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(Procedurename, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                return command;
            }
        }
    }
}
