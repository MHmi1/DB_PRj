namespace LoginRegForm
{
    partial class AppReg
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PersianDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.txtapplocation = new System.Windows.Forms.TextBox();
            this.AppLocationLabel = new System.Windows.Forms.Label();
            this.txtreqsal = new System.Windows.Forms.TextBox();
            this.ReqSalLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.txtworkexp = new System.Windows.Forms.TextBox();
            this.WorkExpLabel = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.TelLabel = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AppInfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRegister.Location = new System.Drawing.Point(418, 442);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(132, 56);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(3, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 54);
            this.panel1.TabIndex = 24;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnClose.Location = new System.Drawing.Point(842, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 48);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.PersianDatePicker);
            this.panel2.Controls.Add(this.txtapplocation);
            this.panel2.Controls.Add(this.AppLocationLabel);
            this.panel2.Controls.Add(this.txtreqsal);
            this.panel2.Controls.Add(this.ReqSalLabel);
            this.panel2.Controls.Add(this.BirthLabel);
            this.panel2.Controls.Add(this.txtworkexp);
            this.panel2.Controls.Add(this.WorkExpLabel);
            this.panel2.Controls.Add(this.txtgender);
            this.panel2.Controls.Add(this.GenderLabel);
            this.panel2.Controls.Add(this.txttel);
            this.panel2.Controls.Add(this.TelLabel);
            this.panel2.Controls.Add(this.txtlname);
            this.panel2.Controls.Add(this.LNameLabel);
            this.panel2.Controls.Add(this.txtfname);
            this.panel2.Controls.Add(this.FNameLabel);
            this.panel2.Controls.Add(this.txtconfirmpassword);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.ConfirmPassLabel);
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 411);
            this.panel2.TabIndex = 25;
            // 
            // PersianDatePicker
            // 
            this.PersianDatePicker.AutoSize = true;
            this.PersianDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersianDatePicker.BackColor = System.Drawing.Color.White;
            this.PersianDatePicker.GeorgianDate = null;
            this.PersianDatePicker.Location = new System.Drawing.Point(572, 256);
            this.PersianDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.PersianDatePicker.Name = "PersianDatePicker";
            this.PersianDatePicker.PersianDate.Day = 0;
            this.PersianDatePicker.PersianDate.Month = 0;
            this.PersianDatePicker.PersianDate.Year = 0;
            this.PersianDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PersianDatePicker.Size = new System.Drawing.Size(327, 29);
            this.PersianDatePicker.TabIndex = 48;
            // 
            // txtapplocation
            // 
            this.txtapplocation.Location = new System.Drawing.Point(663, 364);
            this.txtapplocation.Name = "txtapplocation";
            this.txtapplocation.PlaceholderText = "Iran,Tehran,Tehran";
            this.txtapplocation.Size = new System.Drawing.Size(236, 26);
            this.txtapplocation.TabIndex = 47;
            // 
            // AppLocationLabel
            // 
            this.AppLocationLabel.AutoSize = true;
            this.AppLocationLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppLocationLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.AppLocationLabel.Location = new System.Drawing.Point(429, 362);
            this.AppLocationLabel.Name = "AppLocationLabel";
            this.AppLocationLabel.Size = new System.Drawing.Size(96, 25);
            this.AppLocationLabel.TabIndex = 46;
            this.AppLocationLabel.Text = "Location:*";
            // 
            // txtreqsal
            // 
            this.txtreqsal.Location = new System.Drawing.Point(663, 314);
            this.txtreqsal.Name = "txtreqsal";
            this.txtreqsal.PlaceholderText = "10";
            this.txtreqsal.Size = new System.Drawing.Size(236, 26);
            this.txtreqsal.TabIndex = 45;
            // 
            // ReqSalLabel
            // 
            this.ReqSalLabel.AutoSize = true;
            this.ReqSalLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReqSalLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ReqSalLabel.Location = new System.Drawing.Point(429, 312);
            this.ReqSalLabel.Name = "ReqSalLabel";
            this.ReqSalLabel.Size = new System.Drawing.Size(225, 25);
            this.ReqSalLabel.TabIndex = 44;
            this.ReqSalLabel.Text = "Requsted Salary: (Million)";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.BirthLabel.Location = new System.Drawing.Point(429, 256);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(130, 25);
            this.BirthLabel.TabIndex = 43;
            this.BirthLabel.Text = "Birthday Date:";
            // 
            // txtworkexp
            // 
            this.txtworkexp.Location = new System.Drawing.Point(663, 201);
            this.txtworkexp.Name = "txtworkexp";
            this.txtworkexp.PlaceholderText = "10";
            this.txtworkexp.Size = new System.Drawing.Size(236, 26);
            this.txtworkexp.TabIndex = 42;
            // 
            // WorkExpLabel
            // 
            this.WorkExpLabel.AutoSize = true;
            this.WorkExpLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkExpLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.WorkExpLabel.Location = new System.Drawing.Point(429, 199);
            this.WorkExpLabel.Name = "WorkExpLabel";
            this.WorkExpLabel.Size = new System.Drawing.Size(218, 25);
            this.WorkExpLabel.TabIndex = 41;
            this.WorkExpLabel.Text = "Work Experience: (Years)";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(177, 361);
            this.txtgender.Name = "txtgender";
            this.txtgender.PlaceholderText = "\'M\' or \'F\'";
            this.txtgender.Size = new System.Drawing.Size(236, 26);
            this.txtgender.TabIndex = 40;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.GenderLabel.Location = new System.Drawing.Point(11, 362);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(86, 25);
            this.GenderLabel.TabIndex = 39;
            this.GenderLabel.Text = "Gender:*";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(177, 311);
            this.txttel.Name = "txttel";
            this.txttel.PlaceholderText = "0903*******";
            this.txttel.Size = new System.Drawing.Size(236, 26);
            this.txttel.TabIndex = 38;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.TelLabel.Location = new System.Drawing.Point(11, 312);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(149, 25);
            this.TelLabel.TabIndex = 37;
            this.TelLabel.Text = "Mobile Number:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(177, 255);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "PirouzFar";
            this.txtlname.Size = new System.Drawing.Size(236, 26);
            this.txtlname.TabIndex = 36;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.LNameLabel.Location = new System.Drawing.Point(11, 256);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(112, 25);
            this.LNameLabel.TabIndex = 35;
            this.LNameLabel.Text = "Last Name:*";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(177, 198);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "Parsa";
            this.txtfname.Size = new System.Drawing.Size(236, 26);
            this.txtfname.TabIndex = 34;
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.FNameLabel.Location = new System.Drawing.Point(11, 199);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(114, 25);
            this.FNameLabel.TabIndex = 33;
            this.FNameLabel.Text = "First Name:*";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(382, 118);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(236, 26);
            this.txtconfirmpassword.TabIndex = 32;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(382, 69);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(236, 26);
            this.txtpassword.TabIndex = 31;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(382, 20);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "email@gmail.com";
            this.txtusername.Size = new System.Drawing.Size(236, 26);
            this.txtusername.TabIndex = 30;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConfirmPassLabel.Location = new System.Drawing.Point(200, 119);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(176, 25);
            this.ConfirmPassLabel.TabIndex = 29;
            this.ConfirmPassLabel.Text = "Confirm Password:*";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(200, 67);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(103, 25);
            this.PasswordLabel.TabIndex = 28;
            this.PasswordLabel.Text = "Password:*";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(200, 21);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 25);
            this.UsernameLabel.TabIndex = 27;
            this.UsernameLabel.Text = "Email:*";
            // 
            // AppInfoLabel
            // 
            this.AppInfoLabel.AutoSize = true;
            this.AppInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppInfoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.AppInfoLabel.Location = new System.Drawing.Point(12, 3);
            this.AppInfoLabel.Name = "AppInfoLabel";
            this.AppInfoLabel.Size = new System.Drawing.Size(189, 23);
            this.AppInfoLabel.TabIndex = 26;
            this.AppInfoLabel.Text = "Applicant Information";
            // 
            // AppReg
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(948, 558);
            this.Controls.Add(this.AppInfoLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegister);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AppReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnRegister;
        private Panel panel1;
        private Button BtnClose;
        private Panel panel2;
        private PersianDatePicker PersianDatePicker;
        private TextBox txtapplocation;
        private Label AppLocationLabel;
        private TextBox txtreqsal;
        private Label ReqSalLabel;
        private Label BirthLabel;
        private TextBox txtworkexp;
        private Label WorkExpLabel;
        private TextBox txtgender;
        private Label GenderLabel;
        private TextBox txttel;
        private Label TelLabel;
        private TextBox txtlname;
        private Label LNameLabel;
        private TextBox txtfname;
        private Label FNameLabel;
        private TextBox txtconfirmpassword;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label ConfirmPassLabel;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label AppInfoLabel;
    }
}