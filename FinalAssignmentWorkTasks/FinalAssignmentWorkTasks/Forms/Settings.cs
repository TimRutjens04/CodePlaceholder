using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignmentWorkTasks.Forms
{
    /// <summary>
    /// Will eventually allow all kinds of customization, think of dark mode and password changes
    /// </summary>
    public partial class Settings : Form
    {
        Employee _loggedInEmployee = new Employee();
        public Settings()
        {
            InitializeComponent();
            InitializeLabels();
        }
        public Settings(Employee employee) : this()
        {
            InitializeComponent();
            InitializeLabels();
            _loggedInEmployee = employee;
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
        /// <summary>
        /// This method sets the labels according to the currently logged in employees information
        /// </summary>
        public void InitializeLabels()
        {
            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
            List<Employee> allEmployees = _loggedInEmployee.LoadUserFromCsvForSettings(relativePath);
            if (allEmployees == null)
            {
                MessageBox.Show("Error parsing data from CSV");
                return;
            }

            Employee loggedInEmployee = allEmployees.FirstOrDefault(emp => emp.Id == SavedUser.Instance.savedEmployee.Id);
            if (loggedInEmployee == null)
            {
                MessageBox.Show("Error finding logged in user");
                return;
            }

            lblFirstName.Text = $"First name: {loggedInEmployee.FirstName}";
            lblLastName.Text = $"Last name: {loggedInEmployee.LastName}";
            lblEmail.Text = $"Email: {loggedInEmployee.Email}";
            lblGender.Text = $"Gender: {loggedInEmployee.Gender}";
            lblStreetName.Text = $"Street name: {loggedInEmployee.StreetName}";
            lblStreetNumber.Text = $"Street number: {loggedInEmployee.StreetNumber}";
            lblZipcode.Text = $"Zip code: {loggedInEmployee.Zipcode}";
            lblCity.Text = $"City: {loggedInEmployee.City}";
        }

        /// <summary>
        /// This method writes the changes to the CSV file, and keeps the "old" values if nothing is entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string changedFirstname = tbxChangeFirstname.Text;
            string changedLastname = tbxChangeLastname.Text;
            string changedEmail = tbxChangeEmail.Text;
            string changedGender = "";
            if (rbGenderMale.Checked) { changedGender = "Male"; }
            else if (rbGenderFemale.Checked) { changedGender = "Female"; }
            else if (rbGenderOther.Checked) { changedGender = "Other"; }
            string changedStreetname = tbxChangeStreetname.Text;
            string changedStreetnumber = tbxChangeStreetnumber.Text;
            string changedZipcode = tbxChangeZipcode.Text;
            string changedCity = tbxChangeCity.Text;

            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
            List<Employee> allEmployees = _loggedInEmployee.LoadUserFromCsvForSettings(relativePath);
            Employee loggedInEmployee = allEmployees.FirstOrDefault(emp => emp.Id == SavedUser.Instance.savedEmployee.Id);

            if (loggedInEmployee != null)
            {
                if (string.IsNullOrEmpty(tbxChangeFirstname.Text)) { changedFirstname = loggedInEmployee.FirstName; }
                else { loggedInEmployee.FirstName = changedFirstname; }

                if (string.IsNullOrEmpty(tbxChangeLastname.Text)) { changedLastname = loggedInEmployee.LastName; }
                else { loggedInEmployee.LastName= changedLastname; }

                if (string.IsNullOrEmpty(tbxChangeEmail.Text)) { changedEmail = loggedInEmployee.Email; }
                else { loggedInEmployee.Email= changedEmail; }

                if (!rbGenderMale.Checked && !rbGenderFemale.Checked && !rbGenderOther.Checked) { changedGender = loggedInEmployee.Gender; }
                else { loggedInEmployee.Gender = changedGender; }

                if (string.IsNullOrEmpty(tbxChangeStreetname.Text)) { changedStreetname = loggedInEmployee.FirstName; }
                else { loggedInEmployee.StreetName =  changedStreetname; }

                if (string.IsNullOrEmpty(tbxChangeStreetnumber.Text)) { changedStreetnumber = loggedInEmployee.StreetNumber; }
                else { loggedInEmployee.StreetNumber = changedStreetnumber; }

                if (string.IsNullOrEmpty(tbxChangeZipcode.Text)) { changedZipcode = loggedInEmployee.Zipcode; }
                else { loggedInEmployee.Zipcode = changedZipcode; }

                if (string.IsNullOrEmpty(tbxChangeCity.Text)) { changedCity = loggedInEmployee.City; }
                else { loggedInEmployee.City = changedCity; }

                _loggedInEmployee.SaveUserToCsvForSettings(allEmployees, relativePath);
                MessageBox.Show("Changes saved successfully." + relativePath.ToString());
            }
            else
            {
                MessageBox.Show("Error: Logged-in user not found in the loaded data.");
            }


        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked == true) 
            { 
                tbxPasswordShow.UseSystemPasswordChar = false; 
            }
            else { tbxChangePassword.UseSystemPasswordChar = true; }
        }

        private void cbxChangePasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxChangePasswordShow.Checked == true) 
            {
                tbxChangePassword.UseSystemPasswordChar = false;
            }
            else { tbxChangePassword.UseSystemPasswordChar = true; }
        }
    }
}
