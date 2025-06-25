namespace FinalAssignmentWorkTasks.Forms
{
    partial class TaskDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDashboard));
            btnMenu = new Button();
            dataGridViewTasks = new DataGridView();
            groupBox1 = new GroupBox();
            tbxStatus = new TextBox();
            tbxDepartment = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbxId = new TextBox();
            tbxTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblUserDepartment = new Label();
            lblUserLastname = new Label();
            lblUserFirstname = new Label();
            lblUserEmail = new Label();
            btnChangeSelectedTask = new Button();
            btnRemoveTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(17, 20);
            dataGridViewTasks.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.Size = new Size(1039, 807);
            dataGridViewTasks.TabIndex = 3;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tbxStatus);
            groupBox1.Controls.Add(tbxDepartment);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(tbxTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1064, 101);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(324, 316);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // tbxStatus
            // 
            tbxStatus.BackColor = SystemColors.Info;
            tbxStatus.Location = new Point(71, 212);
            tbxStatus.Name = "tbxStatus";
            tbxStatus.Size = new Size(238, 34);
            tbxStatus.TabIndex = 21;
            tbxStatus.TextChanged += tbxStatus_TextChanged;
            // 
            // tbxDepartment
            // 
            tbxDepartment.BackColor = SystemColors.Info;
            tbxDepartment.Location = new Point(114, 146);
            tbxDepartment.Name = "tbxDepartment";
            tbxDepartment.Size = new Size(195, 34);
            tbxDepartment.TabIndex = 20;
            tbxDepartment.TextChanged += tbxDepartment_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 212);
            label3.Name = "label3";
            label3.Size = new Size(63, 27);
            label3.TabIndex = 19;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 149);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 18;
            label4.Text = "Department:";
            // 
            // tbxId
            // 
            tbxId.BackColor = SystemColors.Info;
            tbxId.Location = new Point(56, 95);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(253, 34);
            tbxId.TabIndex = 17;
            tbxId.TextChanged += tbxId_TextChanged;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = SystemColors.Info;
            tbxTitle.Location = new Point(56, 35);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(253, 34);
            tbxTitle.TabIndex = 16;
            tbxTitle.TextChanged += tbxTitle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 98);
            label2.Name = "label2";
            label2.Size = new Size(33, 27);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 27);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblUserDepartment);
            groupBox2.Controls.Add(lblUserLastname);
            groupBox2.Controls.Add(lblUserFirstname);
            groupBox2.Controls.Add(lblUserEmail);
            groupBox2.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1064, 479);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(324, 267);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User info";
            // 
            // lblUserDepartment
            // 
            lblUserDepartment.AutoSize = true;
            lblUserDepartment.Location = new Point(9, 200);
            lblUserDepartment.Margin = new Padding(4, 0, 4, 0);
            lblUserDepartment.Name = "lblUserDepartment";
            lblUserDepartment.Size = new Size(105, 28);
            lblUserDepartment.TabIndex = 3;
            lblUserDepartment.Text = "Department:";
            // 
            // lblUserLastname
            // 
            lblUserLastname.AutoSize = true;
            lblUserLastname.Location = new Point(9, 148);
            lblUserLastname.Margin = new Padding(4, 0, 4, 0);
            lblUserLastname.Name = "lblUserLastname";
            lblUserLastname.Size = new Size(94, 28);
            lblUserLastname.TabIndex = 2;
            lblUserLastname.Text = "Last name:";
            // 
            // lblUserFirstname
            // 
            lblUserFirstname.AutoSize = true;
            lblUserFirstname.Location = new Point(9, 93);
            lblUserFirstname.Margin = new Padding(4, 0, 4, 0);
            lblUserFirstname.Name = "lblUserFirstname";
            lblUserFirstname.Size = new Size(97, 28);
            lblUserFirstname.TabIndex = 1;
            lblUserFirstname.Text = "First name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(9, 43);
            lblUserEmail.Margin = new Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(58, 28);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email:";
            // 
            // btnChangeSelectedTask
            // 
            btnChangeSelectedTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeSelectedTask.ForeColor = SystemColors.ControlText;
            btnChangeSelectedTask.Location = new Point(184, 837);
            btnChangeSelectedTask.Margin = new Padding(4, 5, 4, 5);
            btnChangeSelectedTask.Name = "btnChangeSelectedTask";
            btnChangeSelectedTask.Size = new Size(239, 78);
            btnChangeSelectedTask.TabIndex = 6;
            btnChangeSelectedTask.Text = "Edit selected task";
            btnChangeSelectedTask.UseVisualStyleBackColor = true;
            btnChangeSelectedTask.Click += btnChangeSelectedTask_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveTask.ForeColor = SystemColors.ControlText;
            btnRemoveTask.Location = new Point(431, 837);
            btnRemoveTask.Margin = new Padding(4, 5, 4, 5);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(293, 78);
            btnRemoveTask.TabIndex = 7;
            btnRemoveTask.Text = "Remove selected task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // TaskDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1406, 935);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnChangeSelectedTask);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "TaskDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskDashboard";
            FormClosed += TaskDashboard_FormClosed;
            Load += TaskDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private DataGridView dataGridViewTasks;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblUserDepartment;
        private Label lblUserLastname;
        private Label lblUserFirstname;
        private Label lblUserEmail;
        private Label label2;
        private Label label1;
        private TextBox tbxId;
        private TextBox tbxTitle;
        private Button btnChangeSelectedTask;
        private Button btnRemoveTask;
        private TextBox tbxStatus;
        private TextBox tbxDepartment;
        private Label label3;
        private Label label4;
    }
}