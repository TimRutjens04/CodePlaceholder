using FinalAssignmentWorkTasks.Classes;
using FinalAssignmentWorkTasks.Forms;

namespace FinalAssignmentWorkTasks
{
    public partial class Login : Form
    {
        private Employee _employee;
        public Login()
        {
            InitializeComponent();
            _employee = new Employee();
        }
        /// <summary>
        /// Attempts to login the user and checks their credentials against the provided MOCK_EMPLOYEE_DATA.csv file
        /// Also sets the savedUser instance if login is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            Department department;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            SavedUser user = SavedUser.Instance;

            if (SavedUser.Employees.Count == 0)
            {
                string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
                SavedUser.Employees = _employee.LoadUserFromCsv(relativePath);
            }

            if (user.EmployeeLogin(username, password, out department))
            {
                Employee savedEmployee = _employee.GetUserFromCredentials(SavedUser.Employees, username, password);

                user.SetSavedEmployee(savedEmployee);

                //MessageBox.Show(username);
                this.Hide();
                var temp = new Menu(savedEmployee);
                temp.Show();
            }
            else
            {
                MessageBox.Show($"Error logging in {username}, {password}, {department}");
            }
        }
        /// <summary>
        /// Stops the application on closing login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}