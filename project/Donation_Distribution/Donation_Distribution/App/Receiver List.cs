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

namespace Donation_Distribution
{
    public partial class Receiver_List : Form
    {
        public static string receiver_name, receiver_id, reason, req_amounts, need_amounts, got_amounts;

        DataTable dtUsers = new DataTable();
        DBAccess objDBAccess = new DBAccess();
        public Receiver_List()
        {
            InitializeComponent();
        }

        private void Receiver_List_Load(object sender, EventArgs e)
        {
            string query = "Select Name,ID,Reason,Amount_request,Amount_got,Amount_need From Receivers JOIN receiver_requests ON Receivers.Email = Receiver_requests.Email; ";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count == 1)
            {

                receiver_id = dtUsers.Rows[0]["ID"].ToString();
                receiver_name = dtUsers.Rows[0]["Name"].ToString();
                reason = dtUsers.Rows[0]["Reason"].ToString();
                req_amounts = dtUsers.Rows[0]["Amount_request"].ToString();
                need_amounts = dtUsers.Rows[0]["Amount_got"].ToString();
                got_amounts = dtUsers.Rows[0]["Amount_need"].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }
            Receiver_name_list_textbox1.Text = receiver_name;
            Receiver_description_list_textbox1.Text = reason;
            Receiver_amount_list_textBox1.Text = need_amounts;
        }
    }
}
