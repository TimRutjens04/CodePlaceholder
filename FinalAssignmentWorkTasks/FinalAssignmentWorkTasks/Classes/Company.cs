using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    public class Company
    {
        public static List<Employee> CompanyEmployees = new List<Employee>();
        public static List<Task> CompanyTasks = new List<Task>();
        public Company() { }
        public static List<Task> GetTasks // can also just add { get; } behind CompanyTasks but too lazy for that now
        {
            get { return Company.CompanyTasks; }
        }
    }
}
