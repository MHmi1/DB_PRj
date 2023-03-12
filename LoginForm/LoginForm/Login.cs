using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace LoginRegForm
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=.\\SQLSERVER2022;Initial Catalog = WoodenDoor;Integrated Security=True");
            cn.Open();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            if (AppCheckBox.Checked == true)
            {
                this.Hide();
                AppReg reg = new AppReg();
                reg.ShowDialog();
            }
            else if (AgentCheckBox.Checked == true)
            {
                this.Hide();
                AgentReg reg = new AgentReg();
                reg.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please Select One Between \"Applicant\" and \"Business Agent\" ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from \"User\" where Email='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AppCheckBox.Checked == true)
            {
                AgentCheckBox.Checked = false;
            }
        }

        private void AgentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgentCheckBox.Checked == true)
            {
                AppCheckBox.Checked = false;
            }
        }
    }
}
