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
    public partial class Welcomeform : Form
    {
        public Welcomeform()
        {
            InitializeComponent();
        }
        private void Welcomeform_Load(object sender, EventArgs e)
        {
            welcome_timer.Start();
        }
        private void welcome_timer_Tick(object sender, EventArgs e)
        {
            welcome_timer.Stop();
            this.Close();
        }

       
    }
}
