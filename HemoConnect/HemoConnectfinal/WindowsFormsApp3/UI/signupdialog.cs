using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class signupdialog : Form
    {
        string usertype;
        public signupdialog(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }
        public void ChangeLabelText(string newText)
        {
            successfulmssg.Text = newText;
        }

        private void successful_timer_Tick(object sender, EventArgs e)
        {
            successful_timer.Stop();
            if (usertype == "staff")
            {
                Mainform mform = new Mainform();
                mform.Show();
            }
            else
            {
                dashboard dform = new dashboard();
                dform.Show();
            }
            this.Close();
        }

        private void signupdialog_Load(object sender, EventArgs e)
        {
            successful_timer.Start();
        }
    }
}
