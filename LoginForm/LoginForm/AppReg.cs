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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginRegForm
{
    public partial class AppReg : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public AppReg()
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
                txtfname.Text != String.Empty || txtlname.Text != String.Empty || txtgender.Text != String.Empty || txtapplocation.Text != String.Empty)
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


                        cmd = new SqlCommand("insert into Applicant values(@Email,@Uid,@Work_Exp,@AppLocation,@Gender,@Birthday,@Req_Sal)", cn);
                        cmd.Parameters.AddWithValue("Email", txtusername.Text);
                        cmd.Parameters.AddWithValue("Uid", 2);
                        cmd.Parameters.AddWithValue("Work_Exp", int.Parse(txtworkexp.Text));
                        cmd.Parameters.AddWithValue("AppLocation", txtapplocation.Text);
                        cmd.Parameters.AddWithValue("Gender", txtgender.Text);
                        cmd.Parameters.AddWithValue("Birthday", PersianDatePicker.PersianDate.ToString().Replace("/", "-"));
                        cmd.Parameters.AddWithValue("Req_Sal", int.Parse(txtreqsal.Text));
                        cmd.ExecuteNonQuery();

                        //cmd.Parameters.AddWithValue("Email", "ali@");
                        //cmd.Parameters.AddWithValue("Uid", 1);
                        //cmd.Parameters.AddWithValue("Work_Exp", 12);
                        //cmd.Parameters.AddWithValue("AppLocation", "tehran");
                        //cmd.Parameters.AddWithValue("Gender", 'M');
                        //cmd.Parameters.AddWithValue("Birthday", "2020-03-17");
                        //cmd.Parameters.AddWithValue("Req_Sal", 14);
                        //cmd.ExecuteNonQuery();


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
