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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
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

        private void sidebarbtn_Click(object sender, EventArgs e)
        {
            mainmenu_timer.Start();
        }
        bool expandbar=true;
        private void mainmenu_timer_Tick(object sender, EventArgs e)
        {
            if (expandbar)
            {
                mainsidebar.Width -= 10;
                if (mainsidebar.Width <= 52)
                {
                    expandbar = false;
                    mainmenu_timer.Stop();
                    //button1.Width = button2.Width = button3.Width = button4.Width = button5.Width = mainsidebar.Width;
                    sidebarbtn.Image = Properties.Resources.menu;

                }
            }
            else
            {
                mainsidebar.Width += 10;
                if (mainsidebar.Width >= 200)
                {
                    expandbar = true;
                    mainmenu_timer.Stop();
                    donorbtn.Width = donationbtn.Width = transfusionbtn.Width = aboutbtn.Width = logoutbtn.Width = mainsidebar.Width = 200;
                    sidebarbtn.Image = Properties.Resources.cross;

                }
            }
        }

        private void donorbtn_Click(object sender, EventArgs e)
        {
            //donors1.Visible = true;
            //donationhistory1.Visible = false;
        }

        private void donationbtn_Click(object sender, EventArgs e)
        {
            //donors1.Visible = false;
            //donationhistory1.Visible = true;

        }

        private void transfusionbtn_Click(object sender, EventArgs e)
        {
           //donationhistory1.Visible = donors1.Visible = false;
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            //donationhistory1.Visible=donors1.Visible = false;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            //donors1.Visible=false;
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want logout?");
            dbox.SetPanelColor(Color.FromArgb(239,76,81));
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
    }
}
