namespace FinalAssignmentWorkTasks
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            tbxUsername = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            tbxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(490, 63);
            label1.Name = "label1";
            label1.Size = new Size(171, 87);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = SystemColors.Info;
            tbxUsername.BorderStyle = BorderStyle.None;
            tbxUsername.Cursor = Cursors.IBeam;
            tbxUsername.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUsername.Location = new Point(512, 252);
            tbxUsername.Margin = new Padding(3, 5, 3, 5);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(229, 35);
            tbxUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(489, 526);
            btnLogin.Margin = new Padding(3, 5, 3, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 83);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(347, 239);
            label3.Name = "label3";
            label3.Size = new Size(159, 48);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(347, 336);
            label2.Name = "label2";
            label2.Size = new Size(153, 48);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = SystemColors.Info;
            tbxPassword.Cursor = Cursors.IBeam;
            tbxPassword.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(512, 342);
            tbxPassword.Margin = new Padding(3, 5, 3, 5);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(228, 42);
            tbxPassword.TabIndex = 2;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1120, 854);
            Controls.Add(tbxPassword);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(tbxUsername);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "Login";
            Padding = new Padding(1, 2, 1, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox tbxUsername;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox tbxPassword;
    }
}