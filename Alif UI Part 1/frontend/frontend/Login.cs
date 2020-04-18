using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Donar_profile dp = new Donar_profile();
            this.Hide();
            dp.Show();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            Donar_Registration dr = new Donar_Registration();
            this.Hide();
            dr.Show();
        }

        private void Username_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
