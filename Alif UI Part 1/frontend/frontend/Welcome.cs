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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Donar_btn_Click(object sender, EventArgs e)
        {
            Login dl1 = new Login();
            this.Hide();
            dl1.Show();
        }

        private void Receiver_btn_Click(object sender, EventArgs e)
        {
            Receiver_login rl1 = new Receiver_login();
            this.Hide();
            rl1.Show();
        }

        private void Guest_btn_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }

        private void Welome_label_Click(object sender, EventArgs e)
        {

        }
    }
}
