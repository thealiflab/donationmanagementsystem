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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void Back_to_login_button_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            
            DBAccess objDBAccess = new DBAccess();
            string userName = name_textBox.Text;
            string userEmail = email_textBox2.Text;
            string userPhone_number = Phn_textBox.Text;
            string userPassword = Password_textBox2.Text;
            if (userName.Equals(""))
            {
                MessageBox.Show("please enter your Name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("please enter your Email.");
            }
            else if (userPhone_number.Equals(""))
            {
                MessageBox.Show("please enter your Phone number.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("please enter your Password.");
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into users(name,email,phone_number,password) values(@userName,@userEmail,@userPhone_number,@userPassword)");

                insertcommand.Parameters.AddWithValue("@userName", userName);
                insertcommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertcommand.Parameters.AddWithValue("@userPhone_number", userPhone_number);
                insertcommand.Parameters.AddWithValue("@userPassword", userPassword);

                int row = objDBAccess.executeQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created Successfully");
                    HomeForm hf = new HomeForm();
                    this.Hide();
                    hf.Show();
                }
                else
                {
                    MessageBox.Show("Error occured. try again.");
                }
            }

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
