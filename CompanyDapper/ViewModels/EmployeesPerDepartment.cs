using CompanyDapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper.ViewModels
{
    public class EmployeesPerDepartment
    {
        public Department Department { get; set; }
        public List<Employee> Employees;

        public EmployeesPerDepartment()
        {
            Employees = new List<Employee>();
        }
    }
}
