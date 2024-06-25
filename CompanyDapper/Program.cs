using CompanyDapper.DataAccess;
using CompanyDapper.Entities;
using CompanyDapper.Services;
using CompanyDapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //DepartmentService.PrintAll();

            //DepartmentService.PrintById(17);
            //DepartmentService.CreateHardCoded(17, "ufufu");

            //DepartmentService.UpdateHardCoded(17, "ufufu17");


            DepartmentService.Delete(17);

        }
    }
}
