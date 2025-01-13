using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class Signupform : Form
    {
        //SqlConnection connect
        //   = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        public Signupform()
        {
            InitializeComponent();
            
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            loginform.Show();
            this.Hide();
        }

        private void signup_showpassword1_Click(object sender, EventArgs e)
        {
            signup_passwordtxtbox.UseSystemPasswordChar = !signup_passwordtxtbox.UseSystemPasswordChar;

            // Update the button icon based on the current password visibility state
            signup_showpassword1.Image = signup_passwordtxtbox.UseSystemPasswordChar
                ? Properties.Resources.openeye
                : Properties.Resources.hideeye;
        }

        private void signup_showpassword2_Click(object sender, EventArgs e)
        {
            signup_confirmpasswordtxtbox.UseSystemPasswordChar = !signup_confirmpasswordtxtbox.UseSystemPasswordChar;

            // Update the button icon based on the current password visibility state
            signup_showpassword2.Image = signup_confirmpasswordtxtbox.UseSystemPasswordChar
                ? Properties.Resources.openeye
                : Properties.Resources.hideeye;
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
        private void signup_signupbtn_Click(object sender, EventArgs e)
        {
            bool inany = false;
            s_invalidemail.Visible = s_errorpassword.Visible = s_errorpassnotmatch.Visible = 
                s_erroremail.Visible = s_errorusername.Visible = inany;
            s_underpassword.BackColor = s_underconpass.BackColor = s_underusername.BackColor =
                    s_underemail.BackColor = Color.FromName("Gray");
            if (signup_username.Text == "")
            {
                s_underusername.BackColor = Color.FromArgb(239, 76, 81);
                s_errorusername.Visible = inany = true;
            }
            if (signup_passwordtxtbox.Text.Length < 6)
            {
                s_underpassword.BackColor = Color.FromArgb(239, 76, 81);
                s_errorpassword.Visible = inany = true;
            }
            if (signup_confirmpasswordtxtbox.Text.Length < 6)
            {
                s_underconpass.BackColor = Color.FromArgb(239, 76, 81);
                inany = true;
            }
            if (signup_confirmpasswordtxtbox.Text != signup_passwordtxtbox.Text)
            {
                s_underpassword.BackColor = s_underconpass.BackColor = Color.FromArgb(239, 76, 81);
                s_errorpassnotmatch.Visible = inany = true;
            }
            if (!IsValidEmail(signup_email.Text.Trim()))
            {
                s_underemail.BackColor = Color.FromArgb(239, 76, 81);
                if (signup_email.Text == "")
                    s_erroremail.Visible = inany = true;
                else
                    s_invalidemail.Visible = inany = true;
            }
            if (inany == false)
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(userid) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                s_underusername.BackColor = Color.FromArgb(239, 76, 81);

                                messageform dbox = new messageform();
                                dbox.ChangeLabelText("This username is taken :(");
                                dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
                                dbox.changepicture(Properties.Resources.error);
                                dbox.changepicture1(Properties.Resources.redcross);

                                dbox.ShowDialog(this);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users " +
                                    "(username, password, email,usertype) " +
                                    "VALUES(@username, @password, @email,'user')";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_passwordtxtbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.ExecuteNonQuery();


                                    signupdialog dialogForm = new signupdialog("user");
                                    dialogForm.ChangeLabelText("Signup Successful!");

                                    dialogForm.Show();
                                    this.Hide();
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            messageform dbox = new messageform();
            dbox.ChangeLabelText(" Do you want to Exit");
            dbox.SetPanelColor(Color.FromArgb(239, 76, 81));
            dbox.changepicture(Properties.Resources.logout);
            dbox.changepicture1(Properties.Resources.redcross);
            dbox.btnvisible(true);


            if (dbox.ShowDialog(this) == DialogResult.Yes)
                Application.Exit();

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Aboutform aform = new Aboutform();
            aform.Show();
            this.Hide();
        }
    }
}
