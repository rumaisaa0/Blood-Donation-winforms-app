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
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class inventory : UserControl
    {
        SqlConnection connect
          = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        // SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        private donordata model;
        private Button currbtn;
        public inventory()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-365);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            l_min.Visible=l_bloodgroup.Visible=false;
            btnui(btnToday);
            model = new donordata();
            LoadData();
        }
        private void LoadData()
        {
            bool refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData )
            {
                lblNumdonors.Text = model.Numdonors.ToString();
                lblnumdonations.Text = model.Numdonations.ToString();
                lblTotalquantity.Text=model.Totalqauntity.ToString();
                lblused.Text=model.used.ToString();
                lblunused.Text = model.unused.ToString();
                lblexpired.Text = model.expired.ToString();

                chartTopProducts.DataSource = model.TopbloodList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                dgvUnderstock.DataSource = model.lowstockList;
                dgvUnderstock.Columns[0].HeaderText = "Blood Group";
                dgvUnderstock.Columns[1].HeaderText = "Quantity";
                //dgvUnderstock.Columns[2].HeaderText = "Threshold";


            }
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }
        private void btnui(object button)
        {
            var btn=(Button)button;
            btn.BackColor = Color.FromArgb(124, 141, 181);
            btn.ForeColor=Color.White;
            if (currbtn!=null && currbtn!=btn)
            {
                currbtn.BackColor=this.BackColor;
                currbtn.ForeColor=Color.FromArgb(124,141,181);
            }
            currbtn = btn;
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-365);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            btnui(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
            btnui(sender);

        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            btnui(sender);

        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            btnui(sender);

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
            btnui(sender);

        }
        public bool IsValidNumber(string numberString)
        {
            if (int.TryParse(numberString, out int number))
            {
                // Check if the parsed number is positive and less than 150
                return number > 0 && number < 150;
            }
            else
            {
                // Parsing failed, so the string is not a valid number
                return false;
            }
        }

        private void btnthreshold_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try 
                { 
                    connect.Open();
                    string update = "update threshold " +
                                   "SET minquantity = @minquantity where bloodgroup = @bloodgroup";
                    l_bloodgroup.Visible = l_min.Visible = false;
                    undermin.BackColor=underbloodgroup.BackColor = Color.FromArgb(181,181,181);

                    using (SqlCommand cmd1 = new SqlCommand(update, connect))
                    {
                        if (bloodgroupbox.SelectedIndex < 0 || bloodgroupbox.SelectedIndex > bloodgroupbox.Items.Count)
                        {
                            underbloodgroup.BackColor = Color.FromArgb(239, 76, 81);
                            l_bloodgroup.Visible = true;
                        }
                        else
                        {
                            if (IsValidNumber(quantitybox.Text.Trim()))
                            {
                                cmd1.Parameters.AddWithValue("bloodgroup", bloodgroupbox.Text.Trim());
                                cmd1.Parameters.AddWithValue("@minquantity", quantitybox.Text.Trim());
                                cmd1.ExecuteNonQuery();
                            }

                            else
                            {
                                l_min.Visible = true;
                            }
                        }

                    }
                } 
                catch(Exception ex) {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
                finally
                {
                    connect.Close();
                }
            }
        }

        private void lblstartdate_Click(object sender, EventArgs e)
        {
            if (currbtn == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblenddate_Click(object sender, EventArgs e)
        {

            if (currbtn == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblstartdate.Text=dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblenddate.Text=dtpEndDate.Text;
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            lblstartdate.Text = dtpStartDate.Text;
            lblenddate.Text = dtpEndDate.Text;
        }
    }
}
