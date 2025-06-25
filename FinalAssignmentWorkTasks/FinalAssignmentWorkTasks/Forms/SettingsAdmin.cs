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
    /// Will eventually allow for the admin to change/add/remove users from the list of users and thus make changes to the CSV file.
    /// </summary>
    public partial class SettingsAdmin : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        public SettingsAdmin()
        {
            InitializeComponent();
        }
        public SettingsAdmin(Employee employee) : this()
        {
            _loggedInEmployee = employee;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        private void SettingsAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This will be a future update where the Admins will be able to add/remove users and see all users and their information.");
        }
    }
}
