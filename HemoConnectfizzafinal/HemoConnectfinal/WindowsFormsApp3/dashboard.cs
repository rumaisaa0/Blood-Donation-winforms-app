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
    public partial class dashboard : Form
    {
        public dashboard(string username)
        {
            InitializeComponent();
            lblname.Text = username;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do want to exit application");
            dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
            dbox.changepicture(Properties.Resources.logout);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);


            if (dbox.ShowDialog(this) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void donorbtn_Click(object sender, EventArgs e)
        {
            mdonor1.Visible=true;
            mdonation1.Visible=false;
            undrdonor.BackColor= Color.FromArgb(0,48,73);
            undrdonation.BackColor= Color.FromArgb(181,181,181);
        }

        private void donatebtn_Click(object sender, EventArgs e)
        {
            mdonor1.Visible = false;
            mdonation1.Visible = true;
            undrdonation.BackColor = Color.FromArgb(0,48,73);
            undrdonor.BackColor = Color.FromArgb(181,181,181);

            mdonation1.setuserid(lblname.Text);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            //donors1.Visible=false;
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want logout?");
            dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
            dbox.changepicture(Properties.Resources.logout);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);


            if (dbox.ShowDialog(this) == DialogResult.Yes)
            {
                Loginform loginform = new Loginform();
                loginform.Show();
                this.Hide();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //Aboutform aform = new Aboutform(lblname.Text);
            //aform.Show();
            //this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Aboutform aform = new Aboutform(lblname.Text);
            aform.Show();
            this.Hide();
        }
    }
}
