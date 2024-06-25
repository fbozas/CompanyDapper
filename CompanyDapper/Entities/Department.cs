using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The Department ID : ");
            sb.Append(ID);
            sb.Append(" Name: ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}
