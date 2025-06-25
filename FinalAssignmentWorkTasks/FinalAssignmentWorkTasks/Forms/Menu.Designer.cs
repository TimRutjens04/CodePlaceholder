namespace FinalAssignmentWorkTasks.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btnLogOut = new Button();
            btnDashboard = new Button();
            btnNewTask = new Button();
            btnSettings = new Button();
            gbxLoggedInUser = new GroupBox();
            lblUserFirstname = new Label();
            lblUserDepartment = new Label();
            lblUserLastname = new Label();
            lblUserEmail = new Label();
            btnAdminSettings = new Button();
            gbxLoggedInUser.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(596, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 87);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ControlText;
            btnLogOut.Location = new Point(596, 557);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(159, 78);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ControlText;
            btnDashboard.Location = new Point(596, 198);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(159, 78);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnNewTask
            // 
            btnNewTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewTask.ForeColor = SystemColors.ControlText;
            btnNewTask.Location = new Point(596, 317);
            btnNewTask.Margin = new Padding(4, 5, 4, 5);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(159, 78);
            btnNewTask.TabIndex = 3;
            btnNewTask.Text = "New task";
            btnNewTask.UseVisualStyleBackColor = true;
            btnNewTask.Click += btnNewTask_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ControlText;
            btnSettings.Location = new Point(596, 437);
            btnSettings.Margin = new Padding(4, 5, 4, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(159, 78);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // gbxLoggedInUser
            // 
            gbxLoggedInUser.BackColor = Color.White;
            gbxLoggedInUser.Controls.Add(lblUserFirstname);
            gbxLoggedInUser.Controls.Add(lblUserDepartment);
            gbxLoggedInUser.Controls.Add(lblUserLastname);
            gbxLoggedInUser.Controls.Add(lblUserEmail);
            gbxLoggedInUser.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbxLoggedInUser.Location = new Point(993, 20);
            gbxLoggedInUser.Margin = new Padding(4, 5, 4, 5);
            gbxLoggedInUser.Name = "gbxLoggedInUser";
            gbxLoggedInUser.Padding = new Padding(4, 5, 4, 5);
            gbxLoggedInUser.Size = new Size(396, 275);
            gbxLoggedInUser.TabIndex = 6;
            gbxLoggedInUser.TabStop = false;
            gbxLoggedInUser.Text = "User info:";
            // 
            // lblUserFirstname
            // 
            lblUserFirstname.AutoSize = true;
            lblUserFirstname.Location = new Point(9, 108);
            lblUserFirstname.Margin = new Padding(4, 0, 4, 0);
            lblUserFirstname.Name = "lblUserFirstname";
            lblUserFirstname.Size = new Size(97, 28);
            lblUserFirstname.TabIndex = 3;
            lblUserFirstname.Text = "First name:";
            // 
            // lblUserDepartment
            // 
            lblUserDepartment.AutoSize = true;
            lblUserDepartment.Location = new Point(9, 213);
            lblUserDepartment.Margin = new Padding(4, 0, 4, 0);
            lblUserDepartment.Name = "lblUserDepartment";
            lblUserDepartment.Size = new Size(105, 28);
            lblUserDepartment.TabIndex = 2;
            lblUserDepartment.Text = "Department:";
            // 
            // lblUserLastname
            // 
            lblUserLastname.AutoSize = true;
            lblUserLastname.Location = new Point(9, 160);
            lblUserLastname.Margin = new Padding(4, 0, 4, 0);
            lblUserLastname.Name = "lblUserLastname";
            lblUserLastname.Size = new Size(94, 28);
            lblUserLastname.TabIndex = 1;
            lblUserLastname.Text = "Last name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(9, 55);
            lblUserEmail.Margin = new Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(58, 28);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email:";
            // 
            // btnAdminSettings
            // 
            btnAdminSettings.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminSettings.ForeColor = SystemColors.ControlText;
            btnAdminSettings.Location = new Point(1084, 305);
            btnAdminSettings.Margin = new Padding(4, 5, 4, 5);
            btnAdminSettings.Name = "btnAdminSettings";
            btnAdminSettings.RightToLeft = RightToLeft.No;
            btnAdminSettings.Size = new Size(214, 78);
            btnAdminSettings.TabIndex = 7;
            btnAdminSettings.Text = "Admin Settings";
            btnAdminSettings.UseVisualStyleBackColor = true;
            btnAdminSettings.Click += btnAdminSettings_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1406, 935);
            Controls.Add(btnAdminSettings);
            Controls.Add(gbxLoggedInUser);
            Controls.Add(btnSettings);
            Controls.Add(btnNewTask);
            Controls.Add(btnDashboard);
            Controls.Add(btnLogOut);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            gbxLoggedInUser.ResumeLayout(false);
            gbxLoggedInUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogOut;
        private Button btnDashboard;
        private Button btnNewTask;
        private Button btnSettings;
        private GroupBox gbxLoggedInUser;
        private Label lblUserFirstname;
        private Label lblUserDepartment;
        private Label lblUserLastname;
        private Label lblUserEmail;
        private Button btnAdminSettings;
    }
}