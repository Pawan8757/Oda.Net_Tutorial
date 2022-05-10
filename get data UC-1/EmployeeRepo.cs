using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Demo
{
    public class EmployeeRepo
    {
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service_130;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection connection = null;

        public void GetAllEmployees()
        {
            try
            {
                using (connection = new SqlConnection(ConnectionString))
                {
                    EmployeeModel emp = new EmployeeModel();
                    string query = "select * from employee_payroll";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            emp.EmployeeID = Convert.ToInt32(reader["ID"] == DBNull.Value ? default : reader["ID"]);
                            emp.PhoneNumber = Convert.ToInt32(reader["PhoneNumber"] == DBNull.Value ? default : reader["PhoneNumber"]);
                            emp.BasicPay = Convert.ToDouble(reader["BasicPay"] == DBNull.Value ? default : reader["BasicPay"]);
                            emp.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                            emp.EmployeeName = reader["EmployeeName"] == DBNull.Value ? default : reader["EmployeeName"].ToString();
                            emp.Department = reader["Department"] == DBNull.Value ? default : reader["Department"].ToString();
                            emp.Gender = reader["Gender"] == DBNull.Value ? default : reader["Gender"].ToString();
                            emp.TaxablePay = Convert.ToDouble(reader["TaxablePay"] == DBNull.Value ? default : reader["TaxablePay"]);
                            emp.NetPay = Convert.ToDouble(reader["NetPay"] == DBNull.Value ? default : reader["NetPay"]);
                            emp.IncomeTax = Convert.ToDouble(reader["IncomeTax"] == DBNull.Value ? default : reader["IncomeTax"]);
                            emp.Deduction = Convert.ToDouble(reader["Deduction"] == DBNull.Value ? default : reader["Deduction"]);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", emp.EmployeeID, emp.PhoneNumber, emp.BasicPay, emp.Address, emp.EmployeeName, emp.Department, emp.Gender, emp.TaxablePay, emp.NetPay, emp.IncomeTax, emp.Deduction);
                            Console.WriteLine("\n");

                            Console.WriteLine("{0},{1},{2},{3},{6}", emp.EmployeeID, emp.EmployeeName, emp.Address, emp.Gender, emp.Department);
                            Console.WriteLine("\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
