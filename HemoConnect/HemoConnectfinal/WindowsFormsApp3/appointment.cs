using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class appointment : UserControl
    {
        SqlConnection connect
          = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        public appointment()
        {
            InitializeComponent();
            loaddata();
        }

        private void dtpappointmentDate_ValueChanged(object sender, EventArgs e)
        {
            datebox.Text = dtpappointmentDate.Text;

        }

        private void lbldate_Click(object sender, EventArgs e)
        {
            dtpappointmentDate.Select();
            SendKeys.Send("%{DOWN}");
        }
        private void PopulateTimeSlots()
        {
            timebox.Items.Clear();
            // Add time slots from 9 AM to 5 PM with half-hour intervals
            for (int hour = 9; hour < 17; hour++) // Loop through hours
            {
                // Add time slot at the beginning of the hour
                timebox.Items.Add($"{hour:00}:00:00.000");

                // Add time slot after half an hour
                timebox.Items.Add($"{hour:00}:30:00.000");
            }
            // Add the last time slot for 5 PM
            timebox.Items.Add("17:00:00.000");
        }

        private void appointment_Load(object sender, EventArgs e)
        {
            PopulateTimeSlots();
        }
        private void loaddata()
        {

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT appointmentid, donorid, appointmentdate, confirmationstatus FROM appointments " +
                        "where confirmationstatus='pending'";
                    //"left join users on users.userid=donors.userid";

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // Fill the DataTable with data from SQL
                        adapter.Fill(dataTable);
                        dgvappointment.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dgvappointment.Columns[0].HeaderText = "AppID";
                    dgvappointment.Columns[1].HeaderText = "DonorID";
                    dgvappointment.Columns[2].HeaderText = "Date";
                    dgvappointment.Columns[3].HeaderText = "Status";
                    connect.Close();
                }
            }

        }
        static bool IsInteger(string input)
        {
            // Regular expression to match integers
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(input);
        }
        private void addappoinbtn_Click(object sender, EventArgs e)
        {
            undertime.BackColor = underdate.BackColor = underuserid.BackColor = underbloodgroup.BackColor = Color.FromName("Gray");
            l_date.Visible = l_time.Visible = l_emptyname.Visible = l_wrongusername.Visible = l_bloodgroup.Visible = false;
            bool inany = false;
            if (bloodgroupbox.SelectedIndex < 0 || bloodgroupbox.SelectedIndex > bloodgroupbox.Items.Count)
            {
                underbloodgroup.BackColor = Color.FromArgb(239, 76, 81);
                l_bloodgroup.Visible = inany = true;
            }
            if (timebox.SelectedIndex < 0 || timebox.SelectedIndex > timebox.Items.Count)
            {
                undertime.BackColor = Color.FromArgb(239, 76, 81);
                l_time.Visible = inany = true;
            }
            if (useridbox.Text == "")
            {
                underuserid.BackColor = Color.FromArgb(239, 76, 81);
                l_emptyname.Visible = inany = true;
            }
            if (!IsInteger(useridbox.Text))
            {
                underuserid.BackColor = Color.FromArgb(239, 76, 81);
                l_wrongusername.Visible = inany = true;
            }
            if (datebox.Text == "e.g:Apr 19,2024")
            {
                underdate.BackColor = Color.FromArgb(239, 76, 81);
                l_date.Visible = inany = true;
            }
            if ((connect.State != ConnectionState.Open) && !inany)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT * FROM users where userid=@userid ";

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {

                        cmd.Parameters.AddWithValue("@userid", useridbox.Text.Trim());
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows.Count == 0)
                        {
                            // Incorrect userid
                            underuserid.BackColor = Color.FromArgb(239, 76, 81);
                            l_wrongusername.Visible = true;
                        }
                        else
                        {
                            string checkdonor = "select * from donors where userid = @userid";
                            using (SqlCommand cmd0 = new SqlCommand(checkdonor, connect))
                            {
                                cmd0.Parameters.AddWithValue("@userid", useridbox.Text.Trim());
                                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd0);
                                DataTable table2 = new DataTable();
                                adapter2.Fill(table2);
                                if (table2.Rows.Count > 0)
                                {
                                    int did = table2.Rows[0].Field<int>("donorid");
                                    messageform dbox = new messageform();
                                    dbox.ChangeLabelText(" want to book appointment?");
                                    dbox.SetPanelColor(Color.FromArgb(185, 223, 188));
                                    dbox.changepicture(Properties.Resources.adduser);
                                    dbox.changepicture1(Properties.Resources.greencross);
                                    dbox.btnvisible(true);
                                    if (dbox.ShowDialog(this) == DialogResult.Yes)
                                    {
                                        DateTime ddate = DateTime.Parse(datebox.Text);

                                        // Get the time from the DateTimePicker
                                        TimeSpan stime = TimeSpan.Parse(timebox.Text); ;
                                        DateTime combinedDate = ddate.Date + stime;
                                        string insertData = "INSERT INTO appointments " +
                                            "(donorid, appointmentdate, confirmationstatus) " +
                                            "VALUES(@donorid, @appdate, 'pending')";
                                        using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                                        {
                                            cmd1.Parameters.AddWithValue("@donorid", did);
                                            cmd1.Parameters.AddWithValue("@appdate", combinedDate);
                                            cmd1.ExecuteNonQuery();
                                        }
                                        messageform dbox1 = new messageform();
                                        dbox1.ChangeLabelText("    Appointment Added!");
                                        dbox1.SetPanelColor(Color.FromArgb(185, 223, 188));
                                        dbox1.changepicture(Properties.Resources.ok);
                                        dbox1.changepicture1(Properties.Resources.greencross);
                                        dbox1.btnvisible(false);

                                        dbox1.ShowDialog(this);

                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
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
                    loaddata();
                }

            }
        }
        private void updatestatus(string status) {
            bool inany = false;
            l_emptyapp.Visible = l_wrongapp.Visible = false;
            underapp.BackColor = Color.FromName("Gray");
            if (appidbox.Text == "")
            {
                underapp.BackColor = Color.FromArgb(239, 76, 81);
                l_emptyapp.Visible = inany = true;
            }
            if (!IsInteger(appidbox.Text))
            {
                underapp.BackColor = Color.FromArgb(239, 76, 81);
                l_wrongapp.Visible = inany = true;
            }
            if ((connect.State != ConnectionState.Open) && !inany)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT * FROM appointments where appointmentid=@appid ";

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {
                        cmd.Parameters.AddWithValue("@appid", appidbox.Text.Trim());
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows.Count == 0)
                        {
                            // Incorrect password
                            underapp.BackColor = Color.FromArgb(239, 76, 81);
                            l_wrongapp.Visible = true;
                        }
                        else
                        {
                            string updateq = "update appointments " +
                                    "SET confirmationstatus = @status where appointmentid = @userid";
                            using (SqlCommand cmd1 = new SqlCommand(updateq, connect))
                            {
                                cmd1.Parameters.AddWithValue("userid", appidbox.Text.Trim());
                                cmd1.Parameters.AddWithValue("@status", status);
                                cmd1.ExecuteNonQuery();

                            }
                        }
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
                    loaddata();
                }
            }
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        { updatestatus("cancelled");
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        { updatestatus("confirmed");
        }
    }
}
