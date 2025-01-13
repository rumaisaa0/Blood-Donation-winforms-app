namespace WindowsFormsApp3
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.underpassword = new System.Windows.Forms.Panel();
            this.login_passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.underusername = new System.Windows.Forms.Panel();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_signupbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.l_emptyname = new System.Windows.Forms.Label();
            this.l_emptypassword = new System.Windows.Forms.Label();
            this.l_wrongpassword = new System.Windows.Forms.Label();
            this.l_wrongusername = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.login_showpassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_loginbtn = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // underpassword
            // 
            this.underpassword.BackColor = System.Drawing.Color.Gray;
            this.underpassword.Location = new System.Drawing.Point(45, 435);
            this.underpassword.Name = "underpassword";
            this.underpassword.Size = new System.Drawing.Size(400, 3);
            this.underpassword.TabIndex = 19;
            // 
            // login_passwordtxtbox
            // 
            this.login_passwordtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.login_passwordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_passwordtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_passwordtxtbox.ForeColor = System.Drawing.Color.Gray;
            this.login_passwordtxtbox.Location = new System.Drawing.Point(45, 404);
            this.login_passwordtxtbox.Name = "login_passwordtxtbox";
            this.login_passwordtxtbox.Size = new System.Drawing.Size(314, 25);
            this.login_passwordtxtbox.TabIndex = 18;
            this.login_passwordtxtbox.Text = "\r\nhello@123";
            this.login_passwordtxtbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // underusername
            // 
            this.underusername.BackColor = System.Drawing.Color.Gray;
            this.underusername.Location = new System.Drawing.Point(41, 322);
            this.underusername.Name = "underusername";
            this.underusername.Size = new System.Drawing.Size(400, 3);
            this.underusername.TabIndex = 16;
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.Color.Gray;
            this.login_username.Location = new System.Drawing.Point(41, 291);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(314, 25);
            this.login_username.TabIndex = 15;
            this.login_username.Text = "e.g: Ali_Riaz1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username:";
            // 
            // login_signupbtn
            // 
            this.login_signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.login_signupbtn.FlatAppearance.BorderSize = 0;
            this.login_signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signupbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.login_signupbtn.Location = new System.Drawing.Point(415, 0);
            this.login_signupbtn.Name = "login_signupbtn";
            this.login_signupbtn.Size = new System.Drawing.Size(355, 56);
            this.login_signupbtn.TabIndex = 12;
            this.login_signupbtn.Text = "Signup";
            this.login_signupbtn.UseVisualStyleBackColor = false;
            this.login_signupbtn.Click += new System.EventHandler(this.login_signupbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 27);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hemo Connect Version 1.0";
            // 
            // l_emptyname
            // 
            this.l_emptyname.AutoSize = true;
            this.l_emptyname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emptyname.Location = new System.Drawing.Point(41, 328);
            this.l_emptyname.Name = "l_emptyname";
            this.l_emptyname.Size = new System.Drawing.Size(245, 21);
            this.l_emptyname.TabIndex = 35;
            this.l_emptyname.Text = "Username cannot be empty";
            this.l_emptyname.Visible = false;
            // 
            // l_emptypassword
            // 
            this.l_emptypassword.AutoSize = true;
            this.l_emptypassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emptypassword.Location = new System.Drawing.Point(41, 441);
            this.l_emptypassword.Name = "l_emptypassword";
            this.l_emptypassword.Size = new System.Drawing.Size(265, 21);
            this.l_emptypassword.TabIndex = 36;
            this.l_emptypassword.Text = "Atleast 6 characters password";
            this.l_emptypassword.Visible = false;
            // 
            // l_wrongpassword
            // 
            this.l_wrongpassword.AutoSize = true;
            this.l_wrongpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_wrongpassword.Location = new System.Drawing.Point(41, 441);
            this.l_wrongpassword.Name = "l_wrongpassword";
            this.l_wrongpassword.Size = new System.Drawing.Size(175, 21);
            this.l_wrongpassword.TabIndex = 37;
            this.l_wrongpassword.Text = "Incorrect password!";
            this.l_wrongpassword.Visible = false;
            // 
            // l_wrongusername
            // 
            this.l_wrongusername.AutoSize = true;
            this.l_wrongusername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_wrongusername.Location = new System.Drawing.Point(44, 328);
            this.l_wrongusername.Name = "l_wrongusername";
            this.l_wrongusername.Size = new System.Drawing.Size(249, 21);
            this.l_wrongusername.TabIndex = 38;
            this.l_wrongusername.Text = "This username does not exist.";
            this.l_wrongusername.Visible = false;
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
            this.panel4.Location = new System.Drawing.Point(480, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 244);
            this.panel4.TabIndex = 46;
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
            // login_showpassword
            // 
            this.login_showpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_showpassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.login_showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.login_showpassword.Image = ((System.Drawing.Image)(resources.GetObject("login_showpassword.Image")));
            this.login_showpassword.Location = new System.Drawing.Point(391, 379);
            this.login_showpassword.Name = "login_showpassword";
            this.login_showpassword.Size = new System.Drawing.Size(50, 50);
            this.login_showpassword.TabIndex = 34;
            this.login_showpassword.UseVisualStyleBackColor = true;
            this.login_showpassword.Click += new System.EventHandler(this.login_showpassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(714, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 107);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // login_loginbtn
            // 
            this.login_loginbtn.AutoEllipsis = true;
            this.login_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.login_loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_loginbtn.FlatAppearance.BorderSize = 3;
            this.login_loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_loginbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.login_loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("login_loginbtn.Image")));
            this.login_loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_loginbtn.Location = new System.Drawing.Point(45, 487);
            this.login_loginbtn.Name = "login_loginbtn";
            this.login_loginbtn.Size = new System.Drawing.Size(210, 53);
            this.login_loginbtn.TabIndex = 20;
            this.login_loginbtn.Text = "login";
            this.login_loginbtn.UseVisualStyleBackColor = false;
            this.login_loginbtn.Click += new System.EventHandler(this.login_loginbtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(767, 706);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.l_wrongusername);
            this.Controls.Add(this.l_wrongpassword);
            this.Controls.Add(this.l_emptypassword);
            this.Controls.Add(this.l_emptyname);
            this.Controls.Add(this.login_showpassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_loginbtn);
            this.Controls.Add(this.underpassword);
            this.Controls.Add(this.login_passwordtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.underusername);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_signupbtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_loginbtn;
        private System.Windows.Forms.Panel underpassword;
        private System.Windows.Forms.TextBox login_passwordtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel underusername;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_signupbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button login_showpassword;
        private System.Windows.Forms.Label l_emptyname;
        private System.Windows.Forms.Label l_emptypassword;
        private System.Windows.Forms.Label l_wrongpassword;
        private System.Windows.Forms.Label l_wrongusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}