using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginRegForm
{
    public partial class AgentReg : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public AgentReg()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=.\\SQLSERVER2022;Initial Catalog = WoodenDoor;Integrated Security=True");
            cn.Open();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty ||
                txtbname.Text != String.Empty || txtbemail.Text != String.Empty || txtagentpos.Text != String.Empty || txtcentrallocation.Text != String.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    cmd = new SqlCommand("select * from \"User\" where Email='" + txtusername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();


                        cmd = new SqlCommand("insert into \"User\" values(@Email,@Password,@FName,@LName,@Tel)", cn);
                        cmd.Parameters.AddWithValue("Email", txtusername.Text);
                        cmd.Parameters.AddWithValue("Password", txtpassword.Text);
                        cmd.Parameters.AddWithValue("FName", txtfname.Text);
                        cmd.Parameters.AddWithValue("LName", txtlname.Text);
                        cmd.Parameters.AddWithValue("Tel", txttel.Text);
                        cmd.ExecuteNonQuery();


                        cmd = new SqlCommand("insert into Agent values(@Email,@Position)", cn);
                        cmd.Parameters.AddWithValue("Email", txtusername.Text);
                        cmd.Parameters.AddWithValue("Position", txtagentpos.Text);
                        cmd.ExecuteNonQuery();

                        
                        cmd = new SqlCommand("insert into Business values(@Bus_Email,@BName,@Agent_Email,@Uid,@FundDate,@Site_Address,@IsValid)", cn);
                        cmd.Parameters.AddWithValue("Bus_Email", txtbemail.Text);
                        cmd.Parameters.AddWithValue("BName", txtbname.Text);
                        cmd.Parameters.AddWithValue("Agent_Email", txtusername.Text);
                        cmd.Parameters.AddWithValue("Uid", 5);
                        cmd.Parameters.AddWithValue("FundDate", PersianDatePicker.PersianDate.ToString().Replace("/", "-"));
                        cmd.Parameters.AddWithValue("Site_Address", txtsiteadd.Text);
                        cmd.Parameters.AddWithValue("IsValid", 0);
                        cmd.ExecuteNonQuery();


                        cmd = new SqlCommand("insert into BLocations values(@BName,@Location)", cn);
                        cmd.Parameters.AddWithValue("BName", txtbname.Text);
                        cmd.Parameters.AddWithValue("Location", txtcentrallocation.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in fields with *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtapplocation_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
