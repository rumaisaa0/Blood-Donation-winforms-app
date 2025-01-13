using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    public partial class mdonor : UserControl
    {

        SqlConnection connect
         = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        donordata donordata1 = new donordata();

        public mdonor()
        {
            InitializeComponent();
            displaydonors();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        public void displaydonors()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT donorid,bloodgroup,contact,users.userid,username,email FROM donors " +
                        "left join users on users.userid=donors.userid";

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // Fill the DataTable with data from SQL
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            guna2Button1.Visible = false;
            Aneg.Text=donordata1.getbloodcount("A-").ToString();
            Apos.Text = donordata1.getbloodcount("A+").ToString();
            Bneg.Text = donordata1.getbloodcount("B-").ToString();
            Bpos.Text = donordata1.getbloodcount("B+").ToString();
            Oneg.Text = donordata1.getbloodcount("O-").ToString();
            ABneg.Text = donordata1.getbloodcount("AB-").ToString();
            ABpos.Text = donordata1.getbloodcount("AB+").ToString();
            Opos.Text = donordata1.getbloodcount("O+").ToString();
            Aneg.ForeColor=Bneg.ForeColor=Oneg.ForeColor=ABneg.ForeColor=ABpos.ForeColor=Apos.ForeColor=Bpos.ForeColor=Opos.ForeColor= Color.FromArgb(185, 223, 188);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (bloodgroupbox.SelectedIndex < 0 || bloodgroupbox.SelectedIndex > bloodgroupbox.Items.Count)
            {
                underbloodgroup.BackColor = Color.FromArgb(239, 76, 81);
                l_bloodgroup.Visible = true;
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectrows = "SELECT username, email, contact FROM donors " +
                            "left join users on users.userid=donors.userid " +
                            "where bloodgroup=@btype";

                        using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                        {
                            cmd.Parameters.AddWithValue("@btype", bloodgroupbox.Text.Trim());


                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            // Fill the DataTable with data from SQL
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                    guna2Button1.Visible = true;
                    Opos.ForeColor = Color.FromArgb(185, 223, 188);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want to go back?");
            dbox.SetPanelColor(Color.FromArgb(228, 228, 249));
            dbox.changepicture(Properties.Resources.back);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);
            if (dbox.ShowDialog(this) == DialogResult.Yes)
                displaydonors();
        }
    }
}
