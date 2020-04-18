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
    public partial class Donar_profile : Form
    {
        public Donar_profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Receiver_Request rr = new Receiver_Request();
            this.Hide();
            rr.Show();
        }

        private void Fakename_label_Click(object sender, EventArgs e)
        {

        }

        private void NameShow_label_Click(object sender, EventArgs e)
        {

        }

        private void Emailshow_label_Click(object sender, EventArgs e)
        {

        }

        private void Phoneshow_label_Click(object sender, EventArgs e)
        {

        }

        private void Dobshow_label_Click(object sender, EventArgs e)
        {

        }

        private void Addressshow_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registration_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
