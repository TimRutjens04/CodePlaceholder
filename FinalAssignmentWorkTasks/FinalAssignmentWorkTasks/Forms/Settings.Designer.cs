namespace FinalAssignmentWorkTasks.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            btnMenu = new Button();
            lblFirstName = new Label();
            groupBox1 = new GroupBox();
            tbxPasswordShow = new TextBox();
            cbxShowPassword = new CheckBox();
            label10 = new Label();
            lblStreetNumber = new Label();
            lblZipcode = new Label();
            lblCity = new Label();
            lblStreetName = new Label();
            lblGender = new Label();
            lblEmail = new Label();
            lblLastName = new Label();
            groupBox2 = new GroupBox();
            cbxChangePasswordShow = new CheckBox();
            btnSaveChanges = new Button();
            tbxChangeFirstname = new TextBox();
            tbxChangeLastname = new TextBox();
            tbxChangeEmail = new TextBox();
            tbxChangeStreetname = new TextBox();
            tbxChangeStreetnumber = new TextBox();
            tbxChangeZipcode = new TextBox();
            tbxChangeCity = new TextBox();
            rbGenderOther = new RadioButton();
            label2 = new Label();
            rbGenderFemale = new RadioButton();
            rbGenderMale = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            tbxChangePassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(12, 539);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(159, 48);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnSettings_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(6, 49);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(119, 34);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxPasswordShow);
            groupBox1.Controls.Add(cbxShowPassword);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblStreetNumber);
            groupBox1.Controls.Add(lblZipcode);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(lblStreetName);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 475);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current employee information";
            // 
            // tbxPasswordShow
            // 
            tbxPasswordShow.Location = new Point(205, 426);
            tbxPasswordShow.Name = "tbxPasswordShow";
            tbxPasswordShow.ReadOnly = true;
            tbxPasswordShow.Size = new Size(452, 41);
            tbxPasswordShow.TabIndex = 15;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.Location = new Point(121, 427);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(91, 38);
            cbxShowPassword.TabIndex = 14;
            cbxShowPassword.Text = "Show";
            cbxShowPassword.UseVisualStyleBackColor = true;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 426);
            label10.Name = "label10";
            label10.Size = new Size(109, 34);
            label10.TabIndex = 13;
            label10.Text = "Password:";
            // 
            // lblStreetNumber
            // 
            lblStreetNumber.AutoSize = true;
            lblStreetNumber.Location = new Point(6, 294);
            lblStreetNumber.Name = "lblStreetNumber";
            lblStreetNumber.Size = new Size(153, 34);
            lblStreetNumber.TabIndex = 11;
            lblStreetNumber.Text = "Street number:";
            // 
            // lblZipcode
            // 
            lblZipcode.AutoSize = true;
            lblZipcode.Location = new Point(6, 337);
            lblZipcode.Name = "lblZipcode";
            lblZipcode.Size = new Size(96, 34);
            lblZipcode.TabIndex = 10;
            lblZipcode.Text = "Zip code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(6, 382);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(54, 34);
            lblCity.TabIndex = 9;
            lblCity.Text = "City:";
            // 
            // lblStreetName
            // 
            lblStreetName.AutoSize = true;
            lblStreetName.Location = new Point(6, 248);
            lblStreetName.Name = "lblStreetName";
            lblStreetName.Size = new Size(134, 34);
            lblStreetName.TabIndex = 8;
            lblStreetName.Text = "Street name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(6, 200);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(84, 34);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 34);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 98);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(115, 34);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxChangePasswordShow);
            groupBox2.Controls.Add(btnSaveChanges);
            groupBox2.Controls.Add(tbxChangeFirstname);
            groupBox2.Controls.Add(tbxChangeLastname);
            groupBox2.Controls.Add(tbxChangeEmail);
            groupBox2.Controls.Add(tbxChangeStreetname);
            groupBox2.Controls.Add(tbxChangeStreetnumber);
            groupBox2.Controls.Add(tbxChangeZipcode);
            groupBox2.Controls.Add(tbxChangeCity);
            groupBox2.Controls.Add(rbGenderOther);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rbGenderFemale);
            groupBox2.Controls.Add(rbGenderMale);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbxChangePassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(719, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(712, 583);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Changes ";
            // 
            // cbxChangePasswordShow
            // 
            cbxChangePasswordShow.AutoSize = true;
            cbxChangePasswordShow.Location = new Point(117, 426);
            cbxChangePasswordShow.Name = "cbxChangePasswordShow";
            cbxChangePasswordShow.Size = new Size(91, 38);
            cbxChangePasswordShow.TabIndex = 11;
            cbxChangePasswordShow.Text = "Show";
            cbxChangePasswordShow.UseVisualStyleBackColor = true;
            cbxChangePasswordShow.CheckedChanged += cbxChangePasswordShow_CheckedChanged;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = SystemColors.ControlText;
            btnSaveChanges.Location = new Point(101, 527);
            btnSaveChanges.Margin = new Padding(4, 5, 4, 5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(457, 48);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tbxChangeFirstname
            // 
            tbxChangeFirstname.Location = new Point(131, 46);
            tbxChangeFirstname.Name = "tbxChangeFirstname";
            tbxChangeFirstname.Size = new Size(564, 41);
            tbxChangeFirstname.TabIndex = 1;
            // 
            // tbxChangeLastname
            // 
            tbxChangeLastname.Location = new Point(131, 95);
            tbxChangeLastname.Name = "tbxChangeLastname";
            tbxChangeLastname.Size = new Size(564, 41);
            tbxChangeLastname.TabIndex = 2;
            // 
            // tbxChangeEmail
            // 
            tbxChangeEmail.Location = new Point(100, 146);
            tbxChangeEmail.Name = "tbxChangeEmail";
            tbxChangeEmail.Size = new Size(595, 41);
            tbxChangeEmail.TabIndex = 3;
            // 
            // tbxChangeStreetname
            // 
            tbxChangeStreetname.Location = new Point(141, 248);
            tbxChangeStreetname.Name = "tbxChangeStreetname";
            tbxChangeStreetname.Size = new Size(554, 41);
            tbxChangeStreetname.TabIndex = 7;
            // 
            // tbxChangeStreetnumber
            // 
            tbxChangeStreetnumber.Location = new Point(155, 294);
            tbxChangeStreetnumber.Name = "tbxChangeStreetnumber";
            tbxChangeStreetnumber.Size = new Size(540, 41);
            tbxChangeStreetnumber.TabIndex = 8;
            // 
            // tbxChangeZipcode
            // 
            tbxChangeZipcode.Location = new Point(117, 337);
            tbxChangeZipcode.Name = "tbxChangeZipcode";
            tbxChangeZipcode.Size = new Size(578, 41);
            tbxChangeZipcode.TabIndex = 9;
            // 
            // tbxChangeCity
            // 
            tbxChangeCity.Location = new Point(88, 379);
            tbxChangeCity.Name = "tbxChangeCity";
            tbxChangeCity.Size = new Size(607, 41);
            tbxChangeCity.TabIndex = 10;
            // 
            // rbGenderOther
            // 
            rbGenderOther.AutoSize = true;
            rbGenderOther.Location = new Point(298, 200);
            rbGenderOther.Name = "rbGenderOther";
            rbGenderOther.Size = new Size(92, 38);
            rbGenderOther.TabIndex = 6;
            rbGenderOther.TabStop = true;
            rbGenderOther.Text = "Other";
            rbGenderOther.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 294);
            label2.Name = "label2";
            label2.Size = new Size(153, 34);
            label2.TabIndex = 26;
            label2.Text = "Street number:";
            // 
            // rbGenderFemale
            // 
            rbGenderFemale.AutoSize = true;
            rbGenderFemale.Location = new Point(185, 200);
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.Size = new Size(107, 38);
            rbGenderFemale.TabIndex = 5;
            rbGenderFemale.TabStop = true;
            rbGenderFemale.Text = "Female";
            rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            rbGenderMale.AutoSize = true;
            rbGenderMale.Location = new Point(100, 200);
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.Size = new Size(84, 38);
            rbGenderMale.TabIndex = 4;
            rbGenderMale.TabStop = true;
            rbGenderMale.Text = "Male";
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 49);
            label9.Name = "label9";
            label9.Size = new Size(119, 34);
            label9.TabIndex = 19;
            label9.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 98);
            label8.Name = "label8";
            label8.Size = new Size(115, 34);
            label8.TabIndex = 20;
            label8.Text = "Last name:";
            // 
            // tbxChangePassword
            // 
            tbxChangePassword.HideSelection = false;
            tbxChangePassword.Location = new Point(214, 424);
            tbxChangePassword.Name = "tbxChangePassword";
            tbxChangePassword.Size = new Size(481, 41);
            tbxChangePassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 149);
            label7.Name = "label7";
            label7.Size = new Size(72, 34);
            label7.TabIndex = 21;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 200);
            label6.Name = "label6";
            label6.Size = new Size(84, 34);
            label6.TabIndex = 22;
            label6.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 426);
            label1.Name = "label1";
            label1.Size = new Size(109, 34);
            label1.TabIndex = 27;
            label1.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 248);
            label5.Name = "label5";
            label5.Size = new Size(134, 34);
            label5.TabIndex = 23;
            label5.Text = "Street name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 382);
            label4.Name = "label4";
            label4.Size = new Size(54, 34);
            label4.TabIndex = 24;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 337);
            label3.Name = "label3";
            label3.Size = new Size(96, 34);
            label3.TabIndex = 25;
            label3.Text = "Zip code:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1443, 607);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMenu);
            Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 7, 4, 7);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += Settings_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Label lblFirstName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblStreetNumber;
        private Label lblZipcode;
        private Label lblCity;
        private Label lblStreetName;
        private Label lblGender;
        private Label lblEmail;
        private Label lblLastName;
        private Label label10;
        private CheckBox cbxShowPassword;
        private RadioButton rbGenderOther;
        private RadioButton rbGenderFemale;
        private RadioButton rbGenderMale;
        private TextBox tbxPasswordShow;
        private TextBox tbxChangeFirstname;
        private TextBox tbxChangeLastname;
        private TextBox tbxChangeEmail;
        private TextBox tbxChangeStreetname;
        private TextBox tbxChangeStreetnumber;
        private TextBox tbxChangeZipcode;
        private TextBox tbxChangeCity;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox tbxChangePassword;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSaveChanges;
        private CheckBox cbxChangePasswordShow;
    }
}