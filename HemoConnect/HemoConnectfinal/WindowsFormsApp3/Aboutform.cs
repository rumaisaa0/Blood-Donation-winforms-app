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
    public partial class Aboutform : Form
    {
        string parent;
        public Aboutform(string parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want to Exit?");
            dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
            dbox.changepicture(Properties.Resources.logout);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);


            if (dbox.ShowDialog(this) == DialogResult.Yes)
                Application.Exit();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (parent == "signup")
            {
                Signupform signupform = new Signupform();
                signupform.Show();
                this.Hide();
            }
            if (parent == "login")
            {
                Loginform loginform = new Loginform();
                loginform.Show();
                this.Hide();
            }
            else
            {
                dashboard dform = new dashboard(parent);
                dform.Show();
                this.Hide();
            }
        }
    }
}
