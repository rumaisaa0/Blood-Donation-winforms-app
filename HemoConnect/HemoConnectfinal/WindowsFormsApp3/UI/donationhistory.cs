using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class donationhistory : UserControl
    {
        //SqlConnection connect
        //   = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        donordata donordata1 = new donordata();

        public donationhistory()
        {
            InitializeComponent();
            displaydonations();
            displaycharts();
        }

        private void donationhistory_Load(object sender, EventArgs e)
        {

        }
        public void displaydonations()
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
                        DataGridView1.DataSource = dataTable;
                        guna2Button1.Visible = label11.Visible = label14.Visible = label13.Visible = label12.Visible =
                            label15.Visible = label16.Visible = label1.Visible = label2.Visible = label3.Visible
                            = label4.Visible = label5.Visible = label6.Visible = false;
                        label7.Visible = true;
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
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];

            // Access data from specific columns in the selected row
            string cellValue = selectedRow.Cells["donorid"].Value.ToString();
            string lname = selectedRow.Cells["username"].Value.ToString();
            string luserid = selectedRow.Cells["userid"].Value.ToString();
            string lbloodgroup = selectedRow.Cells["bloodgroup"].Value.ToString();
            string lcontact = selectedRow.Cells["contact"].Value.ToString();
            string lemail = selectedRow.Cells["email"].Value.ToString();


            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string equery = "select * from blooddonations where donorid=@donorid";

                    using (SqlCommand cmd = new SqlCommand(equery, connect))
                    {
                        cmd.Parameters.AddWithValue("@donorid",cellValue);
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // Fill the DataTable with data from SQL
                        adapter.Fill(dataTable);
                        DataGridView1.DataSource = dataTable;
                        guna2Button1.Visible=label11.Visible=label14.Visible=label13.Visible=label12.Visible=
                            label15.Visible=label16.Visible=label1.Visible=label2.Visible=label3.Visible
                            =label4.Visible=label5.Visible=label6.Visible=true;
                        label7.Visible=false;
                        label11.Text= lname;
                        label14.Text =  luserid;
                        label13.Text =  lbloodgroup;
                        label12.Text =  lcontact;
                        label16.Text = lemail;
                        label15.Text =  cellValue;
                        displaycharts1(int.Parse(cellValue));

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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want to go back?");
            dbox.SetPanelColor(Color.FromArgb(228,228,249));
            dbox.changepicture(Properties.Resources.back);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);
            if (dbox.ShowDialog(this) == DialogResult.Yes)
            { displaydonations();
                displaycharts();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void displaycharts()
        {
            chart1.Series["Series1"].Points.Clear();
            //chart1.Series.Add("MyData"); // Add a new series
            chart1.Series["Series1"].Points.AddXY("used", donordata1.getstatus(0,"used")); // Add data points
            chart1.Series["Series1"].Points.AddXY("unused", donordata1.getstatus(0, "unused"));
            chart1.Series["Series1"].Points.AddXY("expired", donordata1.getstatus(0, "expired"));
            chart1.Series["Series1"]["DoughnutRadius"] = "50";

        }
        public void displaycharts1(int donorid)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY("used", donordata1.getstatus(donorid, "used")); // Add data points
            chart1.Series["Series1"].Points.AddXY("unused", donordata1.getstatus(donorid, "unused"));
            chart1.Series["Series1"].Points.AddXY("expired", donordata1.getstatus(donorid, "expired"));
            chart1.Series["Series1"]["DoughnutRadius"] = "50";


            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
