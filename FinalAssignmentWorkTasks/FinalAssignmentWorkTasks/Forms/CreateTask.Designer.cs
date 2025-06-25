namespace FinalAssignmentWorkTasks.Forms
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTask));
            btnMenu = new Button();
            btnCreateTask = new Button();
            tbxTaskName = new TextBox();
            tbxTaskDescription = new TextBox();
            gbxTaskInfo = new GroupBox();
            label5 = new Label();
            tbxEmployeeFilter = new TextBox();
            comStatus = new ComboBox();
            lblStatus = new Label();
            clbxAssignedEmployees = new CheckedListBox();
            cbxRD = new CheckBox();
            cbxSupport = new CheckBox();
            cbxSales = new CheckBox();
            cbxMarketing = new CheckBox();
            cbxHR = new CheckBox();
            lblDepartment = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthCalendarDueTime = new MonthCalendar();
            btnAddToDatabase = new Button();
            gbxTaskInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(17, 837);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(159, 78);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCreateTask
            // 
            btnCreateTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTask.ForeColor = SystemColors.ControlText;
            btnCreateTask.Location = new Point(30, 780);
            btnCreateTask.Margin = new Padding(4, 5, 4, 5);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Size = new Size(1103, 90);
            btnCreateTask.TabIndex = 4;
            btnCreateTask.Text = "Create task";
            btnCreateTask.UseVisualStyleBackColor = true;
            btnCreateTask.Click += btnCreateTask_Click;
            // 
            // tbxTaskName
            // 
            tbxTaskName.Location = new Point(211, 70);
            tbxTaskName.Margin = new Padding(4, 5, 4, 5);
            tbxTaskName.Name = "tbxTaskName";
            tbxTaskName.Size = new Size(354, 36);
            tbxTaskName.TabIndex = 5;
            tbxTaskName.TextChanged += tbxTaskName_TextChanged;
            // 
            // tbxTaskDescription
            // 
            tbxTaskDescription.Location = new Point(211, 127);
            tbxTaskDescription.Margin = new Padding(4, 5, 4, 5);
            tbxTaskDescription.Multiline = true;
            tbxTaskDescription.Name = "tbxTaskDescription";
            tbxTaskDescription.ScrollBars = ScrollBars.Vertical;
            tbxTaskDescription.Size = new Size(354, 241);
            tbxTaskDescription.TabIndex = 6;
            tbxTaskDescription.TextChanged += tbxTaskDescription_TextChanged;
            // 
            // gbxTaskInfo
            // 
            gbxTaskInfo.Controls.Add(label5);
            gbxTaskInfo.Controls.Add(tbxEmployeeFilter);
            gbxTaskInfo.Controls.Add(comStatus);
            gbxTaskInfo.Controls.Add(lblStatus);
            gbxTaskInfo.Controls.Add(clbxAssignedEmployees);
            gbxTaskInfo.Controls.Add(cbxRD);
            gbxTaskInfo.Controls.Add(cbxSupport);
            gbxTaskInfo.Controls.Add(cbxSales);
            gbxTaskInfo.Controls.Add(cbxMarketing);
            gbxTaskInfo.Controls.Add(cbxHR);
            gbxTaskInfo.Controls.Add(lblDepartment);
            gbxTaskInfo.Controls.Add(label4);
            gbxTaskInfo.Controls.Add(label3);
            gbxTaskInfo.Controls.Add(label2);
            gbxTaskInfo.Controls.Add(label1);
            gbxTaskInfo.Controls.Add(monthCalendarDueTime);
            gbxTaskInfo.Controls.Add(btnCreateTask);
            gbxTaskInfo.Controls.Add(tbxTaskName);
            gbxTaskInfo.Controls.Add(tbxTaskDescription);
            gbxTaskInfo.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxTaskInfo.Location = new Point(227, 20);
            gbxTaskInfo.Margin = new Padding(4, 5, 4, 5);
            gbxTaskInfo.Name = "gbxTaskInfo";
            gbxTaskInfo.Padding = new Padding(4, 5, 4, 5);
            gbxTaskInfo.Size = new Size(1161, 895);
            gbxTaskInfo.TabIndex = 8;
            gbxTaskInfo.TabStop = false;
            gbxTaskInfo.Text = "Task info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 704);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 29);
            label5.TabIndex = 24;
            label5.Text = "Search for employee:";
            // 
            // tbxEmployeeFilter
            // 
            tbxEmployeeFilter.Location = new Point(777, 701);
            tbxEmployeeFilter.Margin = new Padding(4, 5, 4, 5);
            tbxEmployeeFilter.Name = "tbxEmployeeFilter";
            tbxEmployeeFilter.Size = new Size(348, 36);
            tbxEmployeeFilter.TabIndex = 23;
            tbxEmployeeFilter.TextChanged += tbxEmployeeFilter_TextChanged;
            // 
            // comStatus
            // 
            comStatus.FormattingEnabled = true;
            comStatus.Items.AddRange(new object[] { "Open", "In_Progress", "Completed", "Blocked", "Cancelled" });
            comStatus.Location = new Point(211, 700);
            comStatus.Margin = new Padding(4, 5, 4, 5);
            comStatus.Name = "comStatus";
            comStatus.Size = new Size(354, 37);
            comStatus.TabIndex = 22;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(81, 700);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 29);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "Status:";
            // 
            // clbxAssignedEmployees
            // 
            clbxAssignedEmployees.CheckOnClick = true;
            clbxAssignedEmployees.FormattingEnabled = true;
            clbxAssignedEmployees.HorizontalScrollbar = true;
            clbxAssignedEmployees.Location = new Point(777, 285);
            clbxAssignedEmployees.Margin = new Padding(4, 5, 4, 5);
            clbxAssignedEmployees.Name = "clbxAssignedEmployees";
            clbxAssignedEmployees.ScrollAlwaysVisible = true;
            clbxAssignedEmployees.Size = new Size(348, 400);
            clbxAssignedEmployees.TabIndex = 20;
            // 
            // cbxRD
            // 
            cbxRD.AutoSize = true;
            cbxRD.Location = new Point(709, 227);
            cbxRD.Margin = new Padding(4, 5, 4, 5);
            cbxRD.Name = "cbxRD";
            cbxRD.Size = new Size(256, 33);
            cbxRD.TabIndex = 19;
            cbxRD.Text = "Research and Development";
            cbxRD.UseVisualStyleBackColor = true;
            // 
            // cbxSupport
            // 
            cbxSupport.AutoSize = true;
            cbxSupport.Location = new Point(913, 182);
            cbxSupport.Margin = new Padding(4, 5, 4, 5);
            cbxSupport.Name = "cbxSupport";
            cbxSupport.Size = new Size(102, 33);
            cbxSupport.TabIndex = 18;
            cbxSupport.Text = "Support";
            cbxSupport.UseVisualStyleBackColor = true;
            // 
            // cbxSales
            // 
            cbxSales.AutoSize = true;
            cbxSales.Location = new Point(709, 178);
            cbxSales.Margin = new Padding(4, 5, 4, 5);
            cbxSales.Name = "cbxSales";
            cbxSales.Size = new Size(83, 33);
            cbxSales.TabIndex = 17;
            cbxSales.Text = "Sales";
            cbxSales.UseVisualStyleBackColor = true;
            // 
            // cbxMarketing
            // 
            cbxMarketing.AutoSize = true;
            cbxMarketing.Location = new Point(914, 133);
            cbxMarketing.Margin = new Padding(4, 5, 4, 5);
            cbxMarketing.Name = "cbxMarketing";
            cbxMarketing.Size = new Size(120, 33);
            cbxMarketing.TabIndex = 16;
            cbxMarketing.Text = "Marketing";
            cbxMarketing.UseVisualStyleBackColor = true;
            // 
            // cbxHR
            // 
            cbxHR.AutoSize = true;
            cbxHR.Location = new Point(709, 130);
            cbxHR.Margin = new Padding(4, 5, 4, 5);
            cbxHR.Name = "cbxHR";
            cbxHR.Size = new Size(60, 33);
            cbxHR.TabIndex = 15;
            cbxHR.Text = "HR";
            cbxHR.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(823, 70);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(110, 29);
            lblDepartment.TabIndex = 14;
            lblDepartment.Text = "Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 497);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 13;
            label4.Text = "Due date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 285);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 29);
            label3.TabIndex = 12;
            label3.Text = "Assigned employees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 228);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 11;
            label2.Text = "Task description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 10;
            label1.Text = "Task name:";
            // 
            // monthCalendarDueTime
            // 
            monthCalendarDueTime.Location = new Point(211, 390);
            monthCalendarDueTime.Margin = new Padding(13, 15, 13, 15);
            monthCalendarDueTime.Name = "monthCalendarDueTime";
            monthCalendarDueTime.ShowToday = false;
            monthCalendarDueTime.ShowWeekNumbers = true;
            monthCalendarDueTime.TabIndex = 9;
            // 
            // btnAddToDatabase
            // 
            btnAddToDatabase.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddToDatabase.ForeColor = SystemColors.ControlText;
            btnAddToDatabase.Location = new Point(17, 739);
            btnAddToDatabase.Margin = new Padding(4, 5, 4, 5);
            btnAddToDatabase.Name = "btnAddToDatabase";
            btnAddToDatabase.Size = new Size(159, 78);
            btnAddToDatabase.TabIndex = 9;
            btnAddToDatabase.Text = "Add to DB";
            btnAddToDatabase.UseVisualStyleBackColor = true;
            btnAddToDatabase.Click += btnAddToDatabase_Click;
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1406, 935);
            Controls.Add(btnAddToDatabase);
            Controls.Add(gbxTaskInfo);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateTask";
            FormClosed += CreateTask_FormClosed;
            Load += CreateTask_Load;
            gbxTaskInfo.ResumeLayout(false);
            gbxTaskInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnCreateTask;
        private TextBox tbxTaskName;
        private TextBox tbxTaskDescription;
        private GroupBox gbxTaskInfo;
        private Label label1;
        private MonthCalendar monthCalendarDueTime;
        private Label lblDepartment;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox cbxRD;
        private CheckBox cbxSupport;
        private CheckBox cbxSales;
        private CheckBox cbxMarketing;
        private CheckBox cbxHR;
        private CheckedListBox clbxAssignedEmployees;
        private ComboBox comStatus;
        private Label lblStatus;
        private Label label5;
        private TextBox tbxEmployeeFilter;
        private Button btnAddToDatabase;
    }
}