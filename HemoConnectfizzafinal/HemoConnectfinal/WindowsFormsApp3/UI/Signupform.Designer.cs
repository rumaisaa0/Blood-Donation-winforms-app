namespace WindowsFormsApp3
{
    partial class Signupform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signupform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signup_showpassword1 = new System.Windows.Forms.Button();
            this.signup_signupbtn = new System.Windows.Forms.Button();
            this.s_underpassword = new System.Windows.Forms.Panel();
            this.signup_passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.s_underusername = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.s_underemail = new System.Windows.Forms.Panel();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showpassword2 = new System.Windows.Forms.Button();
            this.s_underconpass = new System.Windows.Forms.Panel();
            this.signup_confirmpasswordtxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.s_errorusername = new System.Windows.Forms.Label();
            this.s_erroremail = new System.Windows.Forms.Label();
            this.s_errorpassword = new System.Windows.Forms.Label();
            this.s_errorpassnotmatch = new System.Windows.Forms.Label();
            this.s_invalidemail = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.s_underusername.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 107);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // signup_showpassword1
            // 
            this.signup_showpassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signup_showpassword1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.signup_showpassword1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_showpassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_showpassword1.Image = ((System.Drawing.Image)(resources.GetObject("signup_showpassword1.Image")));
            this.signup_showpassword1.Location = new System.Drawing.Point(693, 394);
            this.signup_showpassword1.Name = "signup_showpassword1";
            this.signup_showpassword1.Size = new System.Drawing.Size(50, 50);
            this.signup_showpassword1.TabIndex = 33;
            this.signup_showpassword1.UseVisualStyleBackColor = true;
            this.signup_showpassword1.Click += new System.EventHandler(this.signup_showpassword1_Click);
            // 
            // signup_signupbtn
            // 
            this.signup_signupbtn.AutoEllipsis = true;
            this.signup_signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signup_signupbtn.FlatAppearance.BorderSize = 3;
            this.signup_signupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signup_signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.signup_signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_signupbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_signupbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.signup_signupbtn.Image = ((System.Drawing.Image)(resources.GetObject("signup_signupbtn.Image")));
            this.signup_signupbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup_signupbtn.Location = new System.Drawing.Point(533, 602);
            this.signup_signupbtn.Name = "signup_signupbtn";
            this.signup_signupbtn.Size = new System.Drawing.Size(210, 53);
            this.signup_signupbtn.TabIndex = 32;
            this.signup_signupbtn.Text = "Signup";
            this.signup_signupbtn.UseVisualStyleBackColor = false;
            this.signup_signupbtn.Click += new System.EventHandler(this.signup_signupbtn_Click);
            // 
            // s_underpassword
            // 
            this.s_underpassword.BackColor = System.Drawing.Color.Gray;
            this.s_underpassword.Location = new System.Drawing.Point(347, 450);
            this.s_underpassword.Name = "s_underpassword";
            this.s_underpassword.Size = new System.Drawing.Size(400, 3);
            this.s_underpassword.TabIndex = 31;
            // 
            // signup_passwordtxtbox
            // 
            this.signup_passwordtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_passwordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_passwordtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_passwordtxtbox.ForeColor = System.Drawing.Color.Gray;
            this.signup_passwordtxtbox.Location = new System.Drawing.Point(347, 419);
            this.signup_passwordtxtbox.Name = "signup_passwordtxtbox";
            this.signup_passwordtxtbox.Size = new System.Drawing.Size(314, 25);
            this.signup_passwordtxtbox.TabIndex = 30;
            this.signup_passwordtxtbox.Text = "\r\nhello@123";
            this.signup_passwordtxtbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password:";
            // 
            // s_underusername
            // 
            this.s_underusername.BackColor = System.Drawing.Color.Gray;
            this.s_underusername.Controls.Add(this.label7);
            this.s_underusername.Location = new System.Drawing.Point(347, 245);
            this.s_underusername.Name = "s_underusername";
            this.s_underusername.Size = new System.Drawing.Size(400, 3);
            this.s_underusername.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // signup_username
            // 
            this.signup_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.ForeColor = System.Drawing.Color.Gray;
            this.signup_username.Location = new System.Drawing.Point(347, 214);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(314, 25);
            this.signup_username.TabIndex = 27;
            this.signup_username.Text = "e.g: Ali_Riaz1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username:";
            // 
            // signup_loginbtn
            // 
            this.signup_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.signup_loginbtn.FlatAppearance.BorderSize = 0;
            this.signup_loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_loginbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_loginbtn.Location = new System.Drawing.Point(0, 0);
            this.signup_loginbtn.Name = "signup_loginbtn";
            this.signup_loginbtn.Size = new System.Drawing.Size(352, 56);
            this.signup_loginbtn.TabIndex = 24;
            this.signup_loginbtn.Text = "Login";
            this.signup_loginbtn.UseVisualStyleBackColor = false;
            this.signup_loginbtn.Click += new System.EventHandler(this.signup_loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Signup";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 27);
            this.panel1.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(252, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hemo Connect Version 1.0";
            // 
            // s_underemail
            // 
            this.s_underemail.BackColor = System.Drawing.Color.Gray;
            this.s_underemail.Location = new System.Drawing.Point(342, 346);
            this.s_underemail.Name = "s_underemail";
            this.s_underemail.Size = new System.Drawing.Size(400, 3);
            this.s_underemail.TabIndex = 39;
            // 
            // signup_email
            // 
            this.signup_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.ForeColor = System.Drawing.Color.Gray;
            this.signup_email.Location = new System.Drawing.Point(342, 315);
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(314, 25);
            this.signup_email.TabIndex = 38;
            this.signup_email.Text = "e.g: Ali_Riaz1@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email:";
            // 
            // signup_showpassword2
            // 
            this.signup_showpassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signup_showpassword2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.signup_showpassword2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_showpassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_showpassword2.Image = ((System.Drawing.Image)(resources.GetObject("signup_showpassword2.Image")));
            this.signup_showpassword2.Location = new System.Drawing.Point(693, 504);
            this.signup_showpassword2.Name = "signup_showpassword2";
            this.signup_showpassword2.Size = new System.Drawing.Size(50, 50);
            this.signup_showpassword2.TabIndex = 43;
            this.signup_showpassword2.UseVisualStyleBackColor = true;
            this.signup_showpassword2.Click += new System.EventHandler(this.signup_showpassword2_Click);
            // 
            // s_underconpass
            // 
            this.s_underconpass.BackColor = System.Drawing.Color.Gray;
            this.s_underconpass.Location = new System.Drawing.Point(347, 560);
            this.s_underconpass.Name = "s_underconpass";
            this.s_underconpass.Size = new System.Drawing.Size(400, 3);
            this.s_underconpass.TabIndex = 42;
            // 
            // signup_confirmpasswordtxtbox
            // 
            this.signup_confirmpasswordtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.signup_confirmpasswordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_confirmpasswordtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_confirmpasswordtxtbox.ForeColor = System.Drawing.Color.Gray;
            this.signup_confirmpasswordtxtbox.Location = new System.Drawing.Point(347, 529);
            this.signup_confirmpasswordtxtbox.Name = "signup_confirmpasswordtxtbox";
            this.signup_confirmpasswordtxtbox.Size = new System.Drawing.Size(314, 25);
            this.signup_confirmpasswordtxtbox.TabIndex = 41;
            this.signup_confirmpasswordtxtbox.Text = "\r\nhello@123";
            this.signup_confirmpasswordtxtbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "Confirm Password:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel4.Location = new System.Drawing.Point(32, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 244);
            this.panel4.TabIndex = 45;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 84);
            this.label6.TabIndex = 5;
            this.label6.Text = "\"Curious? Learn more \r\nabout our mission.\r\nClick here to find\r\nout more.\"";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(7, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 7);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 237);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(244, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 237);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 7);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(714, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // s_errorusername
            // 
            this.s_errorusername.AutoSize = true;
            this.s_errorusername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_errorusername.Location = new System.Drawing.Point(348, 251);
            this.s_errorusername.Name = "s_errorusername";
            this.s_errorusername.Size = new System.Drawing.Size(245, 21);
            this.s_errorusername.TabIndex = 47;
            this.s_errorusername.Text = "Username cannot be empty";
            this.s_errorusername.Visible = false;
            // 
            // s_erroremail
            // 
            this.s_erroremail.AutoSize = true;
            this.s_erroremail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_erroremail.Location = new System.Drawing.Point(348, 352);
            this.s_erroremail.Name = "s_erroremail";
            this.s_erroremail.Size = new System.Drawing.Size(204, 21);
            this.s_erroremail.TabIndex = 48;
            this.s_erroremail.Text = "Email cannot be empty";
            this.s_erroremail.Visible = false;
            // 
            // s_errorpassword
            // 
            this.s_errorpassword.AutoSize = true;
            this.s_errorpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_errorpassword.Location = new System.Drawing.Point(348, 456);
            this.s_errorpassword.Name = "s_errorpassword";
            this.s_errorpassword.Size = new System.Drawing.Size(265, 21);
            this.s_errorpassword.TabIndex = 49;
            this.s_errorpassword.Text = "Atleast 6 characters password";
            this.s_errorpassword.Visible = false;
            // 
            // s_errorpassnotmatch
            // 
            this.s_errorpassnotmatch.AutoSize = true;
            this.s_errorpassnotmatch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_errorpassnotmatch.Location = new System.Drawing.Point(348, 566);
            this.s_errorpassnotmatch.Name = "s_errorpassnotmatch";
            this.s_errorpassnotmatch.Size = new System.Drawing.Size(216, 21);
            this.s_errorpassnotmatch.TabIndex = 50;
            this.s_errorpassnotmatch.Text = "Passwords do not match";
            this.s_errorpassnotmatch.Visible = false;
            // 
            // s_invalidemail
            // 
            this.s_invalidemail.AutoSize = true;
            this.s_invalidemail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_invalidemail.Location = new System.Drawing.Point(353, 352);
            this.s_invalidemail.Name = "s_invalidemail";
            this.s_invalidemail.Size = new System.Drawing.Size(185, 21);
            this.s_invalidemail.TabIndex = 51;
            this.s_invalidemail.Text = "Invalid Email Address";
            this.s_invalidemail.Visible = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(767, 706);
            this.Controls.Add(this.s_invalidemail);
            this.Controls.Add(this.s_errorpassnotmatch);
            this.Controls.Add(this.s_errorpassword);
            this.Controls.Add(this.s_erroremail);
            this.Controls.Add(this.s_errorusername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.signup_showpassword2);
            this.Controls.Add(this.s_underconpass);
            this.Controls.Add(this.signup_confirmpasswordtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_underemail);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_showpassword1);
            this.Controls.Add(this.signup_signupbtn);
            this.Controls.Add(this.s_underpassword);
            this.Controls.Add(this.signup_passwordtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.s_underusername);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_loginbtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signupform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signupform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.s_underusername.ResumeLayout(false);
            this.s_underusername.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signup_showpassword1;
        private System.Windows.Forms.Button signup_signupbtn;
        private System.Windows.Forms.Panel s_underpassword;
        private System.Windows.Forms.TextBox signup_passwordtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel s_underusername;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signup_loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel s_underemail;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signup_showpassword2;
        private System.Windows.Forms.Panel s_underconpass;
        private System.Windows.Forms.TextBox signup_confirmpasswordtxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label s_errorusername;
        private System.Windows.Forms.Label s_erroremail;
        private System.Windows.Forms.Label s_errorpassword;
        private System.Windows.Forms.Label s_errorpassnotmatch;
        private System.Windows.Forms.Label s_invalidemail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}