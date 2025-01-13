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
    public partial class transfusion : UserControl
    {
        SqlConnection connect
         = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        public transfusion()
        {
            InitializeComponent();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {
            dtpappointmentDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpappointmentDate_ValueChanged(object sender, EventArgs e)
        {
            datebox.Text = dtpappointmentDate.Text;

        }

        private void transfusion_Load(object sender, EventArgs e)
        {
            //datebox.Text = dtpappointmentDate.Text;
        }
        static bool IsInteger(string input)
        {
            // Regular expression to match integers
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(input);
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            bool inany = false;
            urecipient.BackColor = udate.BackColor = udonor.BackColor = uquantity.BackColor = upurpose.BackColor = ubloodgroup.BackColor = Color.FromName("Gray");
            wrongdonor.Visible = wrongpurpose.Visible = wrongquantity.Visible = wrongrecipient.Visible = emptydonor.Visible =
                emptyquantity.Visible = emptyrecipient.Visible = emptybloodgroup.Visible = emptydate.Visible = false;
            if (recipientbox.Text.Length == 0)
            {
                urecipient.BackColor = Color.FromArgb(239, 76, 81);
                emptyrecipient.Visible = inany = true;
            }
            if (donorbox.Text.Length == 0)
            {
                udonor.BackColor = Color.FromArgb(239, 76, 81);
                emptydonor.Visible = inany = true;
            }
            if (quantitybox.Text.Length == 0)
            {
                uquantity.BackColor = Color.FromArgb(239, 76, 81);
                emptyquantity.Visible = inany = true;
            }
            if (!IsInteger(quantitybox.Text) || (IsInteger(quantitybox.Text.Trim()) && (Convert.ToInt32(quantitybox.Text.Trim()) < 3 || Convert.ToInt32(quantitybox.Text.Trim()) > 15)))
            {
                uquantity.BackColor = Color.FromArgb(239, 76, 81);
                wrongquantity.Visible = inany = true;
            }
            if (!IsInteger(recipientbox.Text))
            {
                urecipient.BackColor = Color.FromArgb(239, 76, 81);
                wrongrecipient.Visible = inany = true;
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectrows = "SELECT * FROM recipients where recipientid=@userid ";

                        using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                        {
                            cmd.Parameters.AddWithValue("@userid", recipientbox.Text.Trim());
                            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                            DataTable table1 = new DataTable();
                            adapter1.Fill(table1);
                            if (table1.Rows.Count == 0)
                            {
                                // Incorrect password
                                urecipient.BackColor = Color.FromArgb(239, 76, 81);
                                wrongrecipient.Visible = inany = true;
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
                }
            }
            if (!IsInteger(donorbox.Text))
            {
                udonor.BackColor = Color.FromArgb(239, 76, 81);
                wrongdonor.Visible = inany = true;
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectrows = "SELECT * FROM donors where donorid=@userid ";

                        using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                        {
                            cmd.Parameters.AddWithValue("@userid", donorbox.Text.Trim());
                            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                            DataTable table1 = new DataTable();
                            adapter1.Fill(table1);
                            if (table1.Rows.Count == 0)
                            {
                                // Incorrect password
                                udonor.BackColor = Color.FromArgb(239, 76, 81);
                                wrongdonor.Visible = inany = true;
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
                }
            }
            if (bloodgroupbox.SelectedIndex < 0 || bloodgroupbox.SelectedIndex > bloodgroupbox.Items.Count)
            {
                ubloodgroup.BackColor = Color.FromArgb(239, 76, 81);
                emptybloodgroup.Visible = inany = true;
            }
            else
            {
                if (connect.State != ConnectionState.Open && IsInteger(donorbox.Text) && IsInteger(recipientbox.Text))
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectrows = "SELECT @bdonor = bloodgroup FROM donors WHERE donorid = @userid";

                        using (SqlCommand cmd = new SqlCommand(selectrows, connect))
                        {
                            cmd.Parameters.AddWithValue("@userid", donorbox.Text.Trim());
                            SqlParameter bdonorParam = cmd.Parameters.Add("@bdonor", SqlDbType.VarChar, 3);
                            bdonorParam.Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();

                            // Retrieve the output value from the parameter
                            string bloodGroup = bdonorParam.Value.ToString();

                            if (string.IsNullOrEmpty(bloodGroup))
                            {
                                // Blood group not found for the given donor ID
                                udonor.BackColor = Color.FromArgb(239, 76, 81);
                                wrongdonor.Visible = inany = true;
                            }
                            else
                            {
                                // Blood group found
                                // Do something with the blood group value
                                string selectreci = "SELECT @brecipient = bloodtype FROM recipients WHERE recipientID = @rid";
                                using (SqlCommand cmd1 = new SqlCommand(selectreci, connect))
                                {
                                    cmd1.Parameters.AddWithValue("@rid", recipientbox.Text.Trim());
                                    SqlParameter brecipParam = cmd1.Parameters.Add("@brecipient", SqlDbType.VarChar, 3);
                                    brecipParam.Direction = ParameterDirection.Output;
                                    cmd1.ExecuteNonQuery();

                                    // Retrieve the output value from the parameter
                                    string bloodGroupre = brecipParam.Value.ToString();

                                    if (string.IsNullOrEmpty(bloodGroup))
                                    {
                                        // Blood group not found for the given donor ID
                                        udonor.BackColor = Color.FromArgb(239, 76, 81);
                                        wrongdonor.Visible = inany = true;
                                    }
                                    else if ((bloodGroup != bloodGroupre) || (bloodGroup != bloodgroupbox.Text) || (bloodgroupbox.Text != bloodGroupre))
                                    {
                                        // Blood group found
                                        // Do something with the blood group value
                                        inany = true;
                                        messageform dbox = new messageform();
                                        dbox.ChangeLabelText("Donor  Recipient bloodgroup\n      do not match");
                                        dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
                                        dbox.changepicture(Properties.Resources.error);
                                        dbox.changepicture1(Properties.Resources.redcross);
                                        dbox.btnvisible(false);

                                        dbox.ShowDialog(this);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }

            if (datebox.Text != dtpappointmentDate.Text)
            {
                udate.BackColor = Color.FromArgb(239, 76, 81);
                emptydate.Visible = inany = true;
            }
            if ((connect.State != ConnectionState.Open) && !inany)
            {
                try
                {
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY

                    messageform dbox = new messageform();
                    dbox.ChangeLabelText(" Do you want to add \n         Transfusion?");
                    dbox.SetPanelColor(Color.FromArgb(185, 223, 188));
                    dbox.changepicture(Properties.Resources.adduser);
                    dbox.changepicture1(Properties.Resources.greencross);
                    dbox.btnvisible(true);
                    if (dbox.ShowDialog(this) == DialogResult.Yes)
                    {

                        string insertData = "INSERT INTO bloodtransfusions " +
                            "(donationid, recipientid, bloodtype, quantity, purpose, tranfusiondate ) " +
                            "VALUES(@did, @rid, @btype, @quantity, @purpose, @tdate)";
                        using (SqlCommand cmd1 = new SqlCommand(insertData, connect))
                        {
                            cmd1.Parameters.AddWithValue("@did", donorbox.Text.Trim());
                            cmd1.Parameters.AddWithValue("@rid", recipientbox.Text.Trim());
                            cmd1.Parameters.AddWithValue("@btype", bloodgroupbox.Text.Trim());
                            cmd1.Parameters.AddWithValue("@tdate", DateTime.Parse(datebox.Text));
                            cmd1.Parameters.AddWithValue("@quantity", quantitybox.Text.Trim());
                            cmd1.Parameters.AddWithValue("@purpose", purposebox.Text.Trim());
                            cmd1.ExecuteNonQuery();
                        }
                        messageform dbox1 = new messageform();
                        dbox1.ChangeLabelText("      Transfusion Added!");
                        dbox1.SetPanelColor(Color.FromArgb(185, 223, 188));
                        dbox1.changepicture(Properties.Resources.ok);
                        dbox1.changepicture1(Properties.Resources.greencross);
                        dbox1.btnvisible(false);

                        dbox1.ShowDialog(this);
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

    }
}
