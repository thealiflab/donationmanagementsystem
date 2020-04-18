using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_manage

{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Action_button_Click(object sender, EventArgs e)
        {
            ActionForm af = new ActionForm();
            this.Hide();
            af.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            name_home_textBox.Text = LoginForm.name;
            email_home_textBox2.Text = LoginForm.email;
            Phn_home_textBox.Text = LoginForm.phn_num;

        }
    }
}
