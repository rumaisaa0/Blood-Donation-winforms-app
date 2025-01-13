using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class Loginform : Form
    {
        //SqlConnection connect
        //   = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        public Loginform()
        {
            InitializeComponent();
        }
        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            Signupform signupform = new Signupform();
            signupform.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want to Exit?");
            dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
            dbox.changepicture(Properties.Resources.logout);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);


            if (dbox.ShowDialog(this) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_showpassword_Click(object sender, EventArgs e)
        {
            login_passwordtxtbox.UseSystemPasswordChar = !login_passwordtxtbox.UseSystemPasswordChar;
            // Update the button icon based on the current password visibility state
            login_showpassword.Image = login_passwordtxtbox.UseSystemPasswordChar
                ? Properties.Resources.openeye
                : Properties.Resources.hideeye;
        }
        private void login_loginbtn_Click(object sender, EventArgs e)
        {
            bool inany = false;
            l_wrongusername.Visible=l_emptyname.Visible=l_emptypassword.Visible =l_wrongpassword.Visible= inany;
            underusername.BackColor = underpassword.BackColor = Color.FromName("Gray");
            if (login_username.Text == "")
            {
                underusername.BackColor = Color.FromArgb(239, 76, 81);
                l_emptyname.Visible = inany = true;
            }
            if (login_passwordtxtbox.Text.Length < 6)
            {
                underpassword.BackColor = Color.FromArgb(239, 76, 81);
                l_emptypassword.Visible = inany = true;
            }
            if(!inany) {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_passwordtxtbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                // Username exists, check password
                                string passwordFromDB = table.Rows[0]["password"].ToString();
                                if (passwordFromDB == login_passwordtxtbox.Text.Trim())
                                {
                                    signupdialog mForm = new signupdialog(table.Rows[0]["usertype"].ToString());
                                    mForm.ChangeLabelText("Login Successful!");
                                    mForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                string selectname = "SELECT * FROM users WHERE username = @username ";
                                using (SqlCommand cmd1 = new SqlCommand(selectname, connect)) 
                                {
                                    cmd1.Parameters.AddWithValue("@username", login_username.Text.Trim());
                                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                                    DataTable table1 = new DataTable();
                                    adapter1.Fill(table1);
                                    if (table1.Rows.Count>=1)
                                    {
                                        // Incorrect password
                                        underpassword.BackColor = Color.FromArgb(239, 76, 81);
                                        l_wrongpassword.Visible = true;
                                    }
                                    else {
                                        // Username does not exist
                                        underusername.BackColor = Color.FromArgb(239, 76, 81);
                                        l_wrongusername.Visible = true; }
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
                }
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Aboutform aform = new Aboutform();
            aform.Show();
            this.Hide();
        }
    }
}
