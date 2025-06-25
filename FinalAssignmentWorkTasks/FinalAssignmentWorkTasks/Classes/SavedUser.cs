using FinalAssignmentWorkTasks.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks.Forms
{
    public class SavedUser
    {
        /// <summary>
        /// This class is supposed to have a single instance during the runtime of the application, except when logout occurs.
        /// </summary>
        private static SavedUser instance;
        public static List<Employee> Employees = new List<Employee>();
        

        public static SavedUser Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new SavedUser();
                }
                return instance;
            }
        }
        public SavedUser() { }
        public SavedUser(string csvData) { }
        public Employee savedEmployee { get; private set; }
        public void SetSavedEmployee(Employee employee) 
        {
            savedEmployee = employee;
        }
        /// <summary>
        /// This method attempts to login based on user input and checks against the list of employees from the given MOCK_EMPLOYEE_DATA.csv file
        /// Returns a boolean as success/fail value and sets the users Department 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userpassword"></param>
        /// <param name="userDepartment"></param>
        /// <returns></returns>
        public bool EmployeeLogin(string username, string userpassword, out Department userDepartment)
        {
            userDepartment = Department.Unassigned;
            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");

            //List<Employee> employees = Employee.LoadUserFromCsv(relativePath);

            foreach (Employee employee in Employees)
            {
                if (employee.Email == username && employee.Id == userpassword)
                {
                    userDepartment = employee.Department;
                    return true;
                }
            }
            return false;
        }

    }
}
