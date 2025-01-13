using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class donors : UserControl
    {
        //SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        //SqlConnection connect
        // = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        donordata donordata1 = new donordata();
        public donors()
        {
            InitializeComponent();
            displaydonors();
            
        }
        private bool isvalidcontact(string contact)
        {
            // Regular expression pattern for the contact number format
            string pattern = @"^03[0-9]{2}-[0-9]{7}$";
            // Check if the contact number matches the pattern
            return Regex.IsMatch(contact, pattern);
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);
            // Return true if the email matches the pattern, false otherwise
            return regex.IsMatch(email);
        }
        private void adddonorbtn_Click(object sender, EventArgs e)
        { bool inany=false;
            l_email.Visible = l_wrongusername.Visible = l_emptyname.Visible = l_bloodgroup.Visible=l_contact.Visible = inany;
            underusername.BackColor = underpassword.BackColor = undercontact.BackColor=underbloodgroup.BackColor= Color.FromName("Gray");
            if (login_username.Text == "")
            {
                underusername.BackColor = Color.FromArgb(239, 76, 81);
                l_emptyname.Visible = inany = true;
            }
            if (!IsInteger(login_username.Text))
            {
                underusername.BackColor = Color.FromArgb(239, 76, 81);
                l_wrongusername.Visible = inany = true;
            }
            if (contactbox.Text == "")
            {
                undercontact.BackColor = Color.FromArgb(239, 76, 81);
                l_contact.Text = "Contact number cannot be empty";
                l_contact.Visible = inany = true;
            }
            if (bloodgroupbox.SelectedIndex <0||bloodgroupbox.SelectedIndex>bloodgroupbox.Items.Count)
            {
                underbloodgroup.BackColor = Color.FromArgb(239, 76, 81);
                l_bloodgroup.Visible = inany = true;
            }
            if(!isvalidcontact(contactbox.Text))
            {
                undercontact.BackColor = Color.FromArgb(239, 76, 81);
                l_contact.Text = "Enter valid Contact number ";
                l_contact.Visible = inany = true;
            }

            if ((connect.State != ConnectionState.Open)&&!inany)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT * FROM users where userid=@userid " ;

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {
                        cmd.Parameters.AddWithValue("@userid", login_username.Text.Trim());
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows.Count ==0)
                        {
                            // Incorrect password
                            underusername.BackColor = Color.FromArgb(239, 76, 81);
                            l_wrongusername.Visible = true;
                        }
                        else
                        {
                            string checkdonor = "select * from donors where userid = @userid";
                            using (SqlCommand cmd0 = new SqlCommand(checkdonor, connect))
                            {
                                cmd0.Parameters.AddWithValue("@userid", login_username.Text.Trim());
                                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd0);
                                DataTable table2 = new DataTable();
                                adapter2.Fill(table2);
                                if (table2.Rows.Count >0)
                                {
                                    //connect dialogbox2
                                    //underpassword.BackColor= Color.FromArgb(239, 76, 81);
                                    messageform dbox = new messageform();
                                    dbox.ChangeLabelText("Donor already exists!");
                                    dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
                                    dbox.changepicture(Properties.Resources.error);
                                    dbox.changepicture1(Properties.Resources.redcross);
                                    dbox.btnvisible(false);

                                    dbox.ShowDialog(this);
                                }
                                else
                                {

                                    messageform dbox = new messageform();
                                    dbox.ChangeLabelText(" Do you want to add donor?");
                                    dbox.SetPanelColor(Color.FromArgb(185, 223, 188));
                                    dbox.changepicture(Properties.Resources.adduser);
                                    dbox.changepicture1(Properties.Resources.greencross);
                                    dbox.btnvisible(true);


                                    if (dbox.ShowDialog(this) == DialogResult.Yes)
                                    {

                                        string insertData = "INSERT INTO donors " +
                                            "(userid, contact, bloodgroup) " +
                                            "VALUES(@userid, @contact, @btype)";
                                        using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                                        {
                                            cmd1.Parameters.AddWithValue("@userid", login_username.Text.Trim());
                                            cmd1.Parameters.AddWithValue("@contact", contactbox.Text.Trim());
                                            cmd1.Parameters.AddWithValue("@btype", bloodgroupbox.Text.Trim());
                                            cmd1.ExecuteNonQuery();
                                        }
                                        messageform dbox1 = new messageform();
                                        dbox1.ChangeLabelText("      Donor Added!");
                                        dbox1.SetPanelColor(Color.FromArgb(185, 223, 188));
                                        dbox1.changepicture(Properties.Resources.ok);
                                        dbox1.changepicture1(Properties.Resources.greencross);
                                        dbox1.btnvisible(false);

                                        dbox1.ShowDialog(this);
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
                }
                displaydonors();
            }
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
                        "left join users on users.userid=donors.userid" ;

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
            chartAp.Series["Series1"].Points.Clear();
            chartAn.Series["Series1"].Points.Clear();
            chartBn.Series["Series1"].Points.Clear();
            chartBp.Series["Series1"].Points.Clear();
            chartABn.Series["Series1"].Points.Clear();
            chartABp.Series["Series1"].Points.Clear();
            chartOp.Series["Series1"].Points.Clear();
            chartOn.Series["Series1"].Points.Clear();
            chartAp.Series["Series1"].Points.AddXY("A+", donordata1.getbloodcount("A+")); // Add data points
            chartAp.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartAp.Series["Series1"]["DoughnutRadius"] = "40";

            chartAn.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("A-")); // Add data points
            chartAn.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartAn.Series["Series1"]["DoughnutRadius"] = "40";

            chartABp.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("AB+")); // Add data points
            chartABp.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartABp.Series["Series1"]["DoughnutRadius"] = "40";

            chartABn.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("AB-")); // Add data points
            chartABn.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartABn.Series["Series1"]["DoughnutRadius"] = "40";

            chartBn.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("B-")); // Add data points
            chartBn.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartBn.Series["Series1"]["DoughnutRadius"] = "40";

            chartBp.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("B+")); // Add data points
            chartBp.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartBp.Series["Series1"]["DoughnutRadius"] = "40";

            chartOn.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("O-")); // Add data points
            chartOn.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartOn.Series["Series1"]["DoughnutRadius"] = "40";

            chartOp.Series["Series1"].Points.AddXY("used", donordata1.getbloodcount("O+")); // Add data points
            chartOp.Series["Series1"].Points.AddXY("unused", donordata1.getbloodcount("total"));
            chartOp.Series["Series1"]["DoughnutRadius"] = "40";


        }
        static bool IsInteger(string input)
        {
            // Regular expression to match integers
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(input);
        }
        private void updatedonorbtn_Click(object sender, EventArgs e)
        {
            bool inany = false;
            l_email.Visible = l_wrongusername.Visible = l_emptyname.Visible = l_bloodgroup.Visible = l_contact.Visible = inany;
            underusername.BackColor = underpassword.BackColor = undercontact.BackColor = underbloodgroup.BackColor = Color.FromName("Gray");
            if (login_username.Text == "")
            {
                underusername.BackColor = Color.FromArgb(239, 76, 81);
                l_emptyname.Visible = inany = true;
            }
            if ((contactbox.Text == ""||contactbox.Text== "e.g: 03XX-XXXXXXX") 
                &&(bloodgroupbox.SelectedIndex < 0 || bloodgroupbox.SelectedIndex > bloodgroupbox.Items.Count)
                &&(login_passwordtxtbox.Text==""|| login_passwordtxtbox.Text == "e.g: hello123@gmail.com"))
            {
                //add dialogbox3
                messageform dbox = new messageform();
                dbox.ChangeLabelText("Enter Information to update.");
                dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
                dbox.changepicture(Properties.Resources.error);
                dbox.changepicture1(Properties.Resources.redcross);
                dbox.btnvisible(false);

                dbox.ShowDialog(this);

            }
            if (!IsInteger(login_username.Text))
            {
                underusername.BackColor = Color.FromArgb(239, 76, 81);
                l_wrongusername.Visible = inany = true;
            }
            if ((connect.State != ConnectionState.Open) && !inany)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    string selectrows = "SELECT * FROM donors where userid=@userid ";

                    using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                    {

                        cmd.Parameters.AddWithValue("@userid", login_username.Text.Trim());
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        if (table1.Rows.Count == 0)
                        {
                            // Incorrect password
                            underusername.BackColor = Color.FromArgb(239, 76, 81);
                            l_wrongusername.Visible = true;
                        }
                        else
                        { bool anyupdate=false;
                            if (login_passwordtxtbox.Text != ""&&login_passwordtxtbox.Text!="e.g: hello123@gmail.com") {
                                if (!IsValidEmail(login_passwordtxtbox.Text))
                                { underpassword.BackColor = Color.FromArgb(239, 76, 81);
                                    l_email.Visible = true;
                                }
                                else {
                                    string updateq = "update users " +
                                    "SET email = @email where userid = @userid";
                                    using (SqlCommand cmd1 = new SqlCommand(updateq, connect))
                                    {
                                        cmd1.Parameters.AddWithValue("userid", login_username.Text.Trim());
                                        cmd1.Parameters.AddWithValue("@email", login_passwordtxtbox.Text.Trim());
                                        cmd1.ExecuteNonQuery();
                                        anyupdate = true;

                                    }
                                }
                            }
                            if (contactbox.Text != "" && contactbox.Text!="e.g: 03XX-XXXXXXX") {
                                if (!isvalidcontact(contactbox.Text))
                                {
                                    undercontact.BackColor = Color.FromArgb(239, 76, 81);
                                    l_contact.Text = "Enter valid Contact number ";
                                    l_contact.Visible  = true;
                                }
                                else
                                {
                                    string updateq = "update donors " +
                                    "SET contact = @contact where userid = @userid";
                                    using (SqlCommand cmd1 = new SqlCommand(updateq, connect))
                                    {
                                        cmd1.Parameters.AddWithValue("userid", login_username.Text.Trim());
                                        cmd1.Parameters.AddWithValue("@contact", contactbox.Text.Trim());
                                        cmd1.ExecuteNonQuery();
                                        anyupdate = true;

                                    }
                                }
                            }
                            if (bloodgroupbox.SelectedIndex >= 0 && bloodgroupbox.SelectedIndex < bloodgroupbox.Items.Count) {
                                string updateq = "update donors " +
                                    "SET bloodgroup = @bloodtype where userid = @userid";
                                using (SqlCommand cmd1=new SqlCommand(updateq,connect))
                                {
                                    cmd1.Parameters.AddWithValue("userid",login_username.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@bloodtype",bloodgroupbox.Text.Trim());
                                    cmd1.ExecuteNonQuery();
                                    anyupdate = true;

                                }
                            }
                            if(anyupdate)
                            {
                                messageform dbox = new messageform();
                                dbox.ChangeLabelText("Update successsful");
                                dbox.SetPanelColor(Color.FromArgb(185, 223, 188));
                                dbox.changepicture(Properties.Resources.ok);
                                dbox.changepicture1(Properties.Resources.greencross);
                                dbox.btnvisible(false);
                                dbox.ShowDialog(this);
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
                }
                displaydonors();

            }
        }

        private void chartAp_Click(object sender, EventArgs e)
        {

        }

        private void chartAn_Click(object sender, EventArgs e)
        {

        }
    }
}
