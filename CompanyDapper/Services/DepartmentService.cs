using CompanyDapper.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper.Services
{
    class DepartmentService
    {
        public static void PrintAll()
        {
            foreach(Department department in new DepartmentDataAccess().GetAll())
            {
                Console.WriteLine(department.Name);
            }
        }

        public static void PrintById(int id)
        {
            Console.WriteLine(new DepartmentDataAccess().GetById(id));
        }

        public static void CreateHardCoded(int id, string name)
        {
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();
            Department department = new Department()
            {
                ID = id,
                Name = name
            };
            departmentDataAccess.Create(department);
        }

        public static void UpdateHardCoded(int id, string name)
        {
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();
            Department departmentToUpdate = new Department()
            {
                ID = id,
                Name = name
            };
            departmentDataAccess.Update(departmentToUpdate);
        }

        public static void Delete(int id)
        {
            DepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();
            
            departmentDataAccess.Delete(id);
        }
    }
}
