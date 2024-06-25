using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Depid { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Employee ID: ");
            sb.Append(ID);
            sb.Append(" Firstname: ");
            sb.Append(Firstname);
            sb.Append(" Lastname: ");
            sb.Append(Lastname);
            sb.Append(" Salary: ");
            sb.Append(Salary);
            sb.Append(" HireDate: ");
            sb.Append(HireDate);
            return sb.ToString();
        }
    }
}
