namespace LoginRegForm
{
    partial class AgentReg
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.PersianDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.txtcentrallocation = new System.Windows.Forms.TextBox();
            this.AppLocationLabel = new System.Windows.Forms.Label();
            this.FundDateLabel = new System.Windows.Forms.Label();
            this.txtsiteadd = new System.Windows.Forms.TextBox();
            this.WorkExpLabel = new System.Windows.Forms.Label();
            this.txtagentpos = new System.Windows.Forms.TextBox();
            this.AgentPositionLabel = new System.Windows.Forms.Label();
            this.txtbemail = new System.Windows.Forms.TextBox();
            this.BusEmailLabel = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.BNameLabel = new System.Windows.Forms.Label();
            this.AgentInfoLabel = new System.Windows.Forms.Label();
            this.BusInfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRegister.Location = new System.Drawing.Point(398, 510);
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
            this.panel1.Location = new System.Drawing.Point(-1, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 54);
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
            this.panel2.Controls.Add(this.txttel);
            this.panel2.Controls.Add(this.TelLabel);
            this.panel2.Controls.Add(this.txtlname);
            this.panel2.Controls.Add(this.LNameLabel);
            this.panel2.Controls.Add(this.txtfname);
            this.panel2.Controls.Add(this.FNameLabel);
            this.panel2.Controls.Add(this.txtagentpos);
            this.panel2.Controls.Add(this.AgentPositionLabel);
            this.panel2.Controls.Add(this.txtconfirmpassword);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.ConfirmPassLabel);
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Location = new System.Drawing.Point(11, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 203);
            this.panel2.TabIndex = 33;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(641, 116);
            this.txttel.Name = "txttel";
            this.txttel.PlaceholderText = "0903*******";
            this.txttel.Size = new System.Drawing.Size(236, 26);
            this.txttel.TabIndex = 44;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.TelLabel.Location = new System.Drawing.Point(464, 117);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(149, 25);
            this.TelLabel.TabIndex = 43;
            this.TelLabel.Text = "Mobile Number:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(641, 67);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "PirouzFar";
            this.txtlname.Size = new System.Drawing.Size(236, 26);
            this.txtlname.TabIndex = 42;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.LNameLabel.Location = new System.Drawing.Point(464, 68);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(112, 25);
            this.LNameLabel.TabIndex = 41;
            this.LNameLabel.Text = "Last Name:*";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(641, 18);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "Parsa";
            this.txtfname.Size = new System.Drawing.Size(236, 26);
            this.txtfname.TabIndex = 40;
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.FNameLabel.Location = new System.Drawing.Point(464, 19);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(114, 25);
            this.FNameLabel.TabIndex = 39;
            this.FNameLabel.Text = "First Name:*";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(206, 116);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(236, 26);
            this.txtconfirmpassword.TabIndex = 38;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(206, 67);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(236, 26);
            this.txtpassword.TabIndex = 37;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(206, 18);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "email@gmail.com";
            this.txtusername.Size = new System.Drawing.Size(236, 26);
            this.txtusername.TabIndex = 36;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConfirmPassLabel.Location = new System.Drawing.Point(24, 117);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(176, 25);
            this.ConfirmPassLabel.TabIndex = 35;
            this.ConfirmPassLabel.Text = "Confirm Password:*";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 65);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(103, 25);
            this.PasswordLabel.TabIndex = 34;
            this.PasswordLabel.Text = "Password:*";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(24, 19);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 25);
            this.UsernameLabel.TabIndex = 33;
            this.UsernameLabel.Text = "Email:*";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.PersianDatePicker);
            this.panel3.Controls.Add(this.txtcentrallocation);
            this.panel3.Controls.Add(this.AppLocationLabel);
            this.panel3.Controls.Add(this.FundDateLabel);
            this.panel3.Controls.Add(this.txtsiteadd);
            this.panel3.Controls.Add(this.WorkExpLabel);
            this.panel3.Controls.Add(this.txtbemail);
            this.panel3.Controls.Add(this.BusEmailLabel);
            this.panel3.Controls.Add(this.txtbname);
            this.panel3.Controls.Add(this.BNameLabel);
            this.panel3.Location = new System.Drawing.Point(11, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 208);
            this.panel3.TabIndex = 34;
            // 
            // PersianDatePicker
            // 
            this.PersianDatePicker.AutoSize = true;
            this.PersianDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersianDatePicker.BackColor = System.Drawing.Color.White;
            this.PersianDatePicker.GeorgianDate = null;
            this.PersianDatePicker.Location = new System.Drawing.Point(576, 90);
            this.PersianDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.PersianDatePicker.Name = "PersianDatePicker";
            this.PersianDatePicker.PersianDate.Day = 0;
            this.PersianDatePicker.PersianDate.Month = 0;
            this.PersianDatePicker.PersianDate.Year = 0;
            this.PersianDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PersianDatePicker.Size = new System.Drawing.Size(327, 29);
            this.PersianDatePicker.TabIndex = 38;
            // 
            // txtcentrallocation
            // 
            this.txtcentrallocation.Location = new System.Drawing.Point(667, 148);
            this.txtcentrallocation.Name = "txtcentrallocation";
            this.txtcentrallocation.PlaceholderText = "Iran,Tehran,Tehran";
            this.txtcentrallocation.Size = new System.Drawing.Size(236, 26);
            this.txtcentrallocation.TabIndex = 37;
            // 
            // AppLocationLabel
            // 
            this.AppLocationLabel.AutoSize = true;
            this.AppLocationLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppLocationLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.AppLocationLabel.Location = new System.Drawing.Point(433, 146);
            this.AppLocationLabel.Name = "AppLocationLabel";
            this.AppLocationLabel.Size = new System.Drawing.Size(162, 25);
            this.AppLocationLabel.TabIndex = 36;
            this.AppLocationLabel.Text = "Central Location:*";
            // 
            // FundDateLabel
            // 
            this.FundDateLabel.AutoSize = true;
            this.FundDateLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FundDateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.FundDateLabel.Location = new System.Drawing.Point(433, 90);
            this.FundDateLabel.Name = "FundDateLabel";
            this.FundDateLabel.Size = new System.Drawing.Size(110, 25);
            this.FundDateLabel.TabIndex = 35;
            this.FundDateLabel.Text = "Fund Date:*";
            // 
            // txtsiteadd
            // 
            this.txtsiteadd.Location = new System.Drawing.Point(667, 35);
            this.txtsiteadd.Name = "txtsiteadd";
            this.txtsiteadd.PlaceholderText = "https://*********";
            this.txtsiteadd.Size = new System.Drawing.Size(236, 26);
            this.txtsiteadd.TabIndex = 34;
            // 
            // WorkExpLabel
            // 
            this.WorkExpLabel.AutoSize = true;
            this.WorkExpLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkExpLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.WorkExpLabel.Location = new System.Drawing.Point(433, 33);
            this.WorkExpLabel.Name = "WorkExpLabel";
            this.WorkExpLabel.Size = new System.Drawing.Size(196, 25);
            this.WorkExpLabel.TabIndex = 33;
            this.WorkExpLabel.Text = "Business Site Address:";
            // 
            // txtagentpos
            // 
            this.txtagentpos.Location = new System.Drawing.Point(641, 158);
            this.txtagentpos.Name = "txtagentpos";
            this.txtagentpos.PlaceholderText = "Lawyer,CTO,...";
            this.txtagentpos.Size = new System.Drawing.Size(236, 26);
            this.txtagentpos.TabIndex = 32;
            // 
            // AgentPositionLabel
            // 
            this.AgentPositionLabel.AutoSize = true;
            this.AgentPositionLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgentPositionLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.AgentPositionLabel.Location = new System.Drawing.Point(464, 159);
            this.AgentPositionLabel.Name = "AgentPositionLabel";
            this.AgentPositionLabel.Size = new System.Drawing.Size(146, 25);
            this.AgentPositionLabel.TabIndex = 31;
            this.AgentPositionLabel.Text = "Agent Position:*";
            // 
            // txtbemail
            // 
            this.txtbemail.Location = new System.Drawing.Point(181, 89);
            this.txtbemail.Name = "txtbemail";
            this.txtbemail.PlaceholderText = "Company@gmail.com";
            this.txtbemail.Size = new System.Drawing.Size(236, 26);
            this.txtbemail.TabIndex = 30;
            // 
            // BusEmailLabel
            // 
            this.BusEmailLabel.AutoSize = true;
            this.BusEmailLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BusEmailLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.BusEmailLabel.Location = new System.Drawing.Point(15, 90);
            this.BusEmailLabel.Name = "BusEmailLabel";
            this.BusEmailLabel.Size = new System.Drawing.Size(147, 25);
            this.BusEmailLabel.TabIndex = 29;
            this.BusEmailLabel.Text = "Business Email:*";
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(181, 32);
            this.txtbname.Name = "txtbname";
            this.txtbname.PlaceholderText = "Arya Gostar";
            this.txtbname.Size = new System.Drawing.Size(236, 26);
            this.txtbname.TabIndex = 28;
            // 
            // BNameLabel
            // 
            this.BNameLabel.AutoSize = true;
            this.BNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.BNameLabel.Location = new System.Drawing.Point(15, 33);
            this.BNameLabel.Name = "BNameLabel";
            this.BNameLabel.Size = new System.Drawing.Size(151, 25);
            this.BNameLabel.TabIndex = 27;
            this.BNameLabel.Text = "Business Name:*";
            // 
            // AgentInfoLabel
            // 
            this.AgentInfoLabel.AutoSize = true;
            this.AgentInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgentInfoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.AgentInfoLabel.Location = new System.Drawing.Point(12, 20);
            this.AgentInfoLabel.Name = "AgentInfoLabel";
            this.AgentInfoLabel.Size = new System.Drawing.Size(165, 23);
            this.AgentInfoLabel.TabIndex = 35;
            this.AgentInfoLabel.Text = "Agent Information ";
            // 
            // BusInfoLabel
            // 
            this.BusInfoLabel.AutoSize = true;
            this.BusInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BusInfoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.BusInfoLabel.Location = new System.Drawing.Point(12, 270);
            this.BusInfoLabel.Name = "BusInfoLabel";
            this.BusInfoLabel.Size = new System.Drawing.Size(182, 23);
            this.BusInfoLabel.TabIndex = 36;
            this.BusInfoLabel.Text = "Business Information ";
            // 
            // AgentReg
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.BusInfoLabel);
            this.Controls.Add(this.AgentInfoLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegister);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AgentReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnRegister;
        private Panel panel1;
        private Button BtnClose;
        private Panel panel2;
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
        private Panel panel3;
        private PersianDatePicker PersianDatePicker;
        private TextBox txtcentrallocation;
        private Label AppLocationLabel;
        private Label FundDateLabel;
        private TextBox txtsiteadd;
        private Label WorkExpLabel;
        private TextBox txtagentpos;
        private Label AgentPositionLabel;
        private TextBox txtbemail;
        private Label BusEmailLabel;
        private TextBox txtbname;
        private Label BNameLabel;
        private Label AgentInfoLabel;
        private Label BusInfoLabel;
    }
}