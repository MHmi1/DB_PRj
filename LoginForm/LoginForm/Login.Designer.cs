namespace LoginRegForm
{
    partial class Login
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRegisterLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.AppCheckBox = new System.Windows.Forms.CheckBox();
            this.AgentCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(44, 76);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(62, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Email:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(44, 147);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(177, 75);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "email@gmail.com";
            this.txtusername.Size = new System.Drawing.Size(326, 26);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(177, 146);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(326, 26);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRegister.Location = new System.Drawing.Point(31, 343);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(164, 43);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register Now";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLogin.Location = new System.Drawing.Point(31, 230);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(164, 52);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ShowPass.Location = new System.Drawing.Point(177, 181);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(123, 23);
            this.ShowPass.TabIndex = 6;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(1, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 46);
            this.panel1.TabIndex = 8;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnClose.Location = new System.Drawing.Point(506, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 37);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRegisterLabel
            // 
            this.BtnRegisterLabel.AutoSize = true;
            this.BtnRegisterLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnRegisterLabel.Location = new System.Drawing.Point(31, 321);
            this.BtnRegisterLabel.Name = "BtnRegisterLabel";
            this.BtnRegisterLabel.Size = new System.Drawing.Size(275, 19);
            this.BtnRegisterLabel.TabIndex = 9;
            this.BtnRegisterLabel.Text = "Haven\'t Registered Yet? Click Button Below!";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoleLabel.Location = new System.Drawing.Point(44, 21);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(134, 20);
            this.RoleLabel.TabIndex = 10;
            this.RoleLabel.Text = "Please Select One:";
            // 
            // AppCheckBox
            // 
            this.AppCheckBox.AutoSize = true;
            this.AppCheckBox.Location = new System.Drawing.Point(221, 21);
            this.AppCheckBox.Name = "AppCheckBox";
            this.AppCheckBox.Size = new System.Drawing.Size(85, 23);
            this.AppCheckBox.TabIndex = 11;
            this.AppCheckBox.Text = "Applicant";
            this.AppCheckBox.UseVisualStyleBackColor = true;
            this.AppCheckBox.CheckedChanged += new System.EventHandler(this.AppCheckBox_CheckedChanged);
            // 
            // AgentCheckBox
            // 
            this.AgentCheckBox.AutoSize = true;
            this.AgentCheckBox.Location = new System.Drawing.Point(346, 21);
            this.AgentCheckBox.Name = "AgentCheckBox";
            this.AgentCheckBox.Size = new System.Drawing.Size(121, 23);
            this.AgentCheckBox.TabIndex = 12;
            this.AgentCheckBox.Text = "Business Agent";
            this.AgentCheckBox.UseVisualStyleBackColor = true;
            this.AgentCheckBox.CheckedChanged += new System.EventHandler(this.AgentCheckBox_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(611, 449);
            this.Controls.Add(this.AgentCheckBox);
            this.Controls.Add(this.AppCheckBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.BtnRegisterLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ShowPass);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button BtnRegister;
        private Button BtnLogin;
        private CheckBox ShowPass;
        private Panel panel1;
        private Button BtnClose;
        private Label BtnRegisterLabel;
        private Label RoleLabel;
        private CheckBox AppCheckBox;
        private CheckBox AgentCheckBox;
    }

}