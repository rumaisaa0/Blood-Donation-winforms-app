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
    public partial class messageform : Form
    {
        public messageform()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChangeLabelText(string newText)
        {
            successfulmssg.Text = newText;
        }
        public void changepicture(Image image)
        {
            pictureBox1.Image = image;
        }
        public void SetPanelColor(Color color)
        {
            panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = successfulmssg.ForeColor=
                yesbtn.ForeColor=color;
        }
        public void changepicture1(Image image)
        {
            okbtn.Image = image;
        }
        public void btnvisible(bool visib)
        {
            yesbtn.Visible=nobtn.Visible=visib;
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Yes;
            this.Close();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close ();
        }
    }
}
