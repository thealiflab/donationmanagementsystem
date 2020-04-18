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
    public partial class Receiver_login : Form
    {
        public Receiver_login()
        {
            InitializeComponent();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            Receiver_Profile rp = new Receiver_Profile();
            this.Hide();
            rp.Show();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            Receiver_Registration rr = new Receiver_Registration();
            this.Hide();
            rr.Show();
        }

        private void Username_label_Click(object sender, EventArgs e)
        {

        }
    }
}
