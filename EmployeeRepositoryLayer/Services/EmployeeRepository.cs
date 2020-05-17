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
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
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
                  string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
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
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
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
        ///  database connection for Delete data
        /// </summary>
        /// <param name="Data">Delete data</param>
        /// <returns></returns>
        public async Task<int> DeleteEmployee(EmployeeID Data)
        {

            try
            {
                SqlConnection connection = DatabaseConnection();
                SqlCommand command = StoreProcedureConnection("spDeleteEmployeeRcord", connection);
                command.Parameters.AddWithValue("@ID", Data.ID);
                connection.Open();
                int Response = await command.ExecuteNonQueryAsync();
                connection.Close();
                if (Response != 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        ///   database connection for Update Excisting entry
        /// </summary>
        /// <param name="data">Add new Entry</param>
        /// <returns></returns>
        public async Task<int> UpdateEmployee(UpdateModel data)
        {
            try
            {
                SqlConnection connection = DatabaseConnection();
                string Password = EncryptedPassword.EncodePasswordToBase64(data.Password);
                SqlCommand command = StoreProcedureConnection("spUpdateemployee", connection);
                command.Parameters.AddWithValue("@ID", data.ID);
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
                if (Response == 0)
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
        /// <summary>
        ///  database connection get specific emplyee details
        /// </summary>
        /// <param name="data">Add new Entry</param>
        /// <returns></returns>
        public dynamic Getspecificemployee(UpdateModel data)
        {
            try
            {
                UpdateModel employee = new UpdateModel();
                SqlConnection connection = DatabaseConnection();
                SqlCommand command = StoreProcedureConnection("spSpecificEmployeeRcord", connection);
                command.Parameters.AddWithValue("@ID", data.ID);
                connection.Open();
                SqlDataReader Response = command.ExecuteReader();
                while (Response.Read())
                {
                    employee.ID = Convert.ToInt32(Response["ID"]);
                    employee.EmployeeName = Response["EmployeeName"].ToString();
                    employee.Username = Response["Username"].ToString();
                    employee.Password = Response["Password"].ToString();
                    employee.Gender = Response["Gender"].ToString();
                    employee.City = Response["City"].ToString();
                    employee.EmailID = Response["EmailID"].ToString();
                    employee.Designation = Response["Designation"].ToString();
                    employee.WorkingExperience = Convert.ToInt32(Response["WorkingExperience"]);
                }
                return employee;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        ///  database connection for get all emplyee details
        /// </summary>
        public IEnumerable<UpdateModel> GetAllemployee()
        {
            try
            {
                List<UpdateModel> listemployee = new List<UpdateModel>();
                SqlConnection connection = DatabaseConnection();
                SqlCommand command = StoreProcedureConnection("spAllEmployeeDetail", connection);
                connection.Open();
                SqlDataReader Response = command.ExecuteReader();
                while (Response.Read())
                {
                    UpdateModel employee = new UpdateModel();
                    employee.ID = Convert.ToInt32(Response["ID"]);
                    employee.EmployeeName = Response["EmployeeName"].ToString();
                    employee.Username = Response["Username"].ToString();
                    employee.Password = Response["Password"].ToString();
                    employee.Gender = Response["Gender"].ToString();
                    employee.City = Response["City"].ToString();
                    employee.EmailID = Response["EmailID"].ToString();
                    employee.Designation = Response["Designation"].ToString();
                    employee.WorkingExperience = Convert.ToInt32(Response["WorkingExperience"]);
                    listemployee.Add(employee);
                }
                connection.Close();
                return listemployee;
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
