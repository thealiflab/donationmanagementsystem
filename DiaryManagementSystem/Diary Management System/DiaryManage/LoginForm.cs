using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diary_manage
{
    public partial class LoginForm : Form
    {
        public static string id, name, email, password, phn_num;
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string useremail = email_textBox.Text;
            string userpassword = password_textBox.Text;

            if (useremail.Equals(""))
            {
                MessageBox.Show("please enter your Email.");
            }
            else if (userpassword.Equals(""))
            {
                MessageBox.Show("please enter your Password.");
            }
            else
            {
                string query = "select * from Users where email = '"+useremail+"' AND password = '"+userpassword+"'";
                objDBAccess.readDatathroughAdapter(query,dtUsers);
                if (dtUsers.Rows.Count == 1)
                {
                   
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["name"].ToString();
                    email = dtUsers.Rows[0]["email"].ToString();
                    password = dtUsers.Rows[0]["password"].ToString();
                    phn_num = dtUsers.Rows[0]["phone_number"].ToString();
                    //MessageBox.Show("login Successfully");
                    objDBAccess.closeConn();
                    HomeForm hf = new HomeForm();
                    this.Hide();
                    hf.Show();
                }
                else
                {
                    MessageBox.Show("Invalid information. Provide correct email and password");
                }
            }
        }

        private void Signup_label_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            this.Hide();
            sf.Show();
        }

        

        
    }
}
