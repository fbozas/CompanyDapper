using CompanyDapper.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper.DataAccess
{
    class EmployeeDataAccess
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-UHUV6UP\SQLEXPRESS01;Initial Catalog=CompanyDapper;Integrated Security=True";

        public List<Employee> GetAll()
        {
            List<Employee> employees = null;
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    employees = new List<Employee>();

                    employees.AddRange(dbcon.Query<Employee>("SELECT * FROM Employees"));
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not get employees list");
                employees = null;
            }
            return employees;
        }
    }
}
