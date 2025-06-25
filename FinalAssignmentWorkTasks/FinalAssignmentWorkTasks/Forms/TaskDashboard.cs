using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class TaskDashboard : Form
    {
        Employee _loggedInEmployee;
        Task _selectedTask;
        Task _task = new Task();
        private static List<Task> Tasks = new List<Task>();
        private List<Task> tasksForLoggedInEmployee = new List<Task>();
        private DataTable tasksDataTable = new DataTable();

        public TaskDashboard()
        {
            InitializeComponent();
            CreateTask createTaskForm = new CreateTask();
            if (createTaskForm != null)
            {
                Tasks = Company.GetTasks;
            }
            if (dataGridViewTasks.SelectedRows == null)
            {
                btnChangeSelectedTask.Enabled = false;
            }
        }

        public TaskDashboard(Employee employee) : this()
        {
            _loggedInEmployee = employee;
            if (_loggedInEmployee != null)
            {
                lblUserEmail.Text = $"Email: {_loggedInEmployee.Email}";
                lblUserFirstname.Text = $"First name: {_loggedInEmployee.FirstName}";
                lblUserLastname.Text = $"Last name: {_loggedInEmployee.LastName}";
                lblUserDepartment.Text = $"Department: {_loggedInEmployee.Department.ToString()}";
            }
            else
            {
                lblUserEmail.Text = "Email: Not logged in";
                lblUserFirstname.Text = "First name: Not logged in";
                lblUserLastname.Text = "Last name: Not logged in";
                lblUserDepartment.Text = "Department: Not logged in";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
        private void btnChangeSelectedTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                DataRow selectedRow = ((DataRowView)dataGridViewTasks.SelectedRows[0].DataBoundItem).Row;
                //_selectedTask = Task.CreateTaskFromDataRow(selectedRow);
                int taskId = Convert.ToInt32(selectedRow["TaskId"]);
                _selectedTask = Company.GetTasks.FirstOrDefault(task => task.TaskId == taskId);
                if (_selectedTask != null)
                {
                    this.Hide();
                    var temp = new CreateTask(_selectedTask, _loggedInEmployee);
                    temp.Show();
                }
            }
            else { MessageBox.Show("Please select a task"); }
        }
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                DataRow selectedRow = ((DataRowView)dataGridViewTasks.SelectedRows[0].DataBoundItem).Row;
                int taskId = Convert.ToInt32(selectedRow["TaskId"]);
                _selectedTask = Company.GetTasks.FirstOrDefault(task => task.TaskId == taskId);
                if (_selectedTask != null && _selectedTask.Status == Classes.TaskStatus.Open)
                {
                    string projectRoot = Path.Combine(Environment.CurrentDirectory, "../../../");
                    string directoryPath = Path.Combine(projectRoot, "Tasks");
                    string fileName = $"{_selectedTask.TaskName}_{taskId.ToString()}.xml";
                    string fullPath = Path.Combine(directoryPath, fileName);
                    Tasks.Remove(_selectedTask);
                    tasksDataTable.Rows.Remove(selectedRow);
                    File.Delete(fullPath);
                }
                else { MessageBox.Show($"Cannot delete class with status {_selectedTask.Status}\nRequired status for removal is Open."); }
            }
            else { MessageBox.Show("Please select a task"); }
        }

        private void TaskDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }
        /// <summary>
        /// Adds files to dataTable/GridView on loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskDashboard_Load(object sender, EventArgs e)
        {
            Tasks.Clear();
            Tasks.AddRange(_task.LoadTasksFromXmlFiles());

            if (_loggedInEmployee.Department != Department.Admin)
            {
                tasksForLoggedInEmployee = Tasks.Where(task => task.AssignedEmployees.Any(employee => employee.FullName == _loggedInEmployee.FullName)).ToList();
                tasksDataTable = ConvertToDataTable(tasksForLoggedInEmployee);                
            }
            else 
            {
                tasksDataTable = ConvertToDataTable(Tasks);
            }
            dataGridViewTasks.DataSource = tasksDataTable;
        }
       
        /// <summary>
        /// This is used to display the full Task when a cell in the Task row is selected,
        /// mostly since the list of departments and employees is not entirely visible when directly looking in the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView selectedDataRowView = dataGridViewTasks.Rows[e.RowIndex].DataBoundItem as DataRowView;

                if (selectedDataRowView != null)
                {
                    DataRow selectedDataRow = selectedDataRowView.Row;

                    int taskId = Convert.ToInt32(selectedDataRow["TaskId"]);
                    Task selectedTask = Tasks.FirstOrDefault(task => task.TaskId == taskId);

                    if (selectedTask != null)
                    {
                        string taskTitle = selectedTask.TaskName;
                        string taskDescription = selectedTask.TaskDescription;
                        string taskTimeDue = selectedTask.TimeDue.ToString();
                        string taskStatus = selectedTask.Status.ToString();

                        string taskAssignedEmployees = string.Join(", ", selectedTask.AssignedEmployees.Select(employee => employee.FullName));
                        string taskAssignedDepartments = string.Join(", ", selectedTask.AssignedDepartments);

                        MessageBox.Show($"Selected task:\nID: {taskId}\nTitle: {taskTitle}\nDescription: {taskDescription}\nTime due: {taskTimeDue}\nStatus: {taskStatus}\nAssigned employees: {taskAssignedEmployees}\nAssigned departments: {taskAssignedDepartments}");
                    }
                    else
                    {
                        MessageBox.Show($"Task not found.");
                    }
                }
                else
                {
                    MessageBox.Show($"There is an error with the task selection.\nPlease try again.");
                }
            }
        }
        /// <summary>
        /// This method is used to create a DataTable as a source for the DataGridView, 
        /// I'm using this since a DataGridView does not allow for filtering, and a DataTable does.
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        private DataTable ConvertToDataTable(List<Task> tasks)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("TaskId", typeof(int));
            dataTable.Columns.Add("TaskName", typeof(string));
            dataTable.Columns.Add("TaskDescription", typeof(string));
            dataTable.Columns.Add("TimeDue", typeof(DateTime));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Assigned employees", typeof(string));

            foreach (var task in tasks)
            {
                string statusString = string.Join (", ", task.Status.ToString());
                string assignedDepartments = string.Join(", ", task.AssignedDepartments.Select(dep => dep.ToString()));
                string assignedEmployees = string.Join(", ", task.AssignedEmployees.Select(emp => emp.ToString()));
                dataTable.Rows.Add(task.TaskId, task.TaskName, task.TaskDescription, task.TimeDue, statusString, assignedDepartments, assignedEmployees);
            }
            return dataTable;
        }
        /// <summary>
        /// Filtering mechanisms for Title, ID, Department, Status
        /// </summary>
        private void tbxTitle_TextChanged(object sender, EventArgs e)
        {
            string filterField = "TaskName";
            tasksDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbxTitle.Text);
        }
        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            string filterField = "TaskId";
            tasksDataTable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filterField, tbxId.Text);
        }
        private void tbxDepartment_TextChanged(object sender, EventArgs e)
        {
            string filterField = "Department";
            tasksDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbxDepartment.Text);
        }

        private void tbxStatus_TextChanged(object sender, EventArgs e)
        {
            string filterField = "Status";

            tasksDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbxStatus.Text.ToString());
        }
        
        
    }
}
