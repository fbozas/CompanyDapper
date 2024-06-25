using CompanyDapper.Entities;
using CompanyDapper.ViewModels;
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
    class DepartmentDataAccess
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-UHUV6UP\SQLEXPRESS01;Initial Catalog=CompanyDapper;Integrated Security=True";

        public List<Department> GetAll()
        {
            List<Department> departments = null;
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    departments = new List<Department>();

                    departments.AddRange(dbcon.Query<Department>("SELECT * FROM Departments"));
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not get departments list");
                departments = null;
            }
            return departments;
        }


        public Department GetById(int depid)
        {
            Department department = null;
            string sqldepartment = "SELECT * FROM Departments WHERE id = @id;";
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    department = dbcon.QuerySingleOrDefault<Department>(sqldepartment, new { id = depid });
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not get department");
                department = null;
            }
            return department;
        }

        public void Create(Department department)
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    var affectedRows = dbcon.Execute("INSERT INTO Departments values(@id, @name)",
                    new
                    {
                        id = department.ID,
                        name = department.Name
                    });

                    Console.WriteLine($"{affectedRows} Affected Rows");
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not create department");
                department = null;
            }
        }

        public void Update(Department department)
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    var affectedRows = dbcon.Execute("UPDATE Departments SET name = @name WHERE id = @id",
                    new
                    {
                        id = department.ID,
                        name = department.Name
                    });

                    Console.WriteLine($"{affectedRows} Affected Rows");
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not update department");
            }
        }

        public void Delete(int depid)
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(_connectionString))
                {
                    dbcon.Open();

                    var affectedRows = dbcon.Execute("DELETE Departments WHERE id = @id", new { id = depid });

                    Console.WriteLine($"{affectedRows} Affected Rows");
                }
            }
            catch (DbException)
            {
                Console.WriteLine("Could not delete department");
            }
        }
    }
}
