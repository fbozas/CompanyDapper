using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDapper.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Enddate { get; set; }
        public double Progress { get; set; }
        public double Budget { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Project ID: ");
            sb.Append(ID);
            sb.Append(" Title: ");
            sb.Append(Title);
            sb.Append(" StartDate: ");
            sb.Append(StartDate);
            sb.Append(" Enddate: ");
            sb.Append(Enddate);
            sb.Append(" Progress: ");
            sb.Append(Progress);
            sb.Append(" Budget: ");
            sb.Append(Budget);
            return sb.ToString();
        }
    }
}
