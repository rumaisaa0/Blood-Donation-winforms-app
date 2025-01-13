namespace WindowsFormsApp3
{
    partial class mdonation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdonation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.Label();
            this.dtpappointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.underdate = new System.Windows.Forms.Panel();
            this.undertime = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.useridbox = new System.Windows.Forms.TextBox();
            this.underuserid = new System.Windows.Forms.Panel();
            this.l_emptyname = new System.Windows.Forms.Label();
            this.l_wrongusername = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.underbloodgroup = new System.Windows.Forms.Panel();
            this.l_bloodgroup = new System.Windows.Forms.Label();
            this.bloodgroupbox = new System.Windows.Forms.ComboBox();
            this.l_date = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.appoinbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvappointment = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 39);
            this.label9.TabIndex = 99;
            this.label9.Text = "Donate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 100;
            this.label1.Text = "Book Appointment:";
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.ForeColor = System.Drawing.Color.Gray;
            this.datebox.Location = new System.Drawing.Point(435, 163);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(196, 27);
            this.datebox.TabIndex = 117;
            this.datebox.Text = "e.g:Apr 19,2024";
            this.datebox.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // dtpappointmentDate
            // 
            this.dtpappointmentDate.CustomFormat = "MMM dd, yyyy";
            this.dtpappointmentDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpappointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpappointmentDate.Location = new System.Drawing.Point(435, 163);
            this.dtpappointmentDate.Name = "dtpappointmentDate";
            this.dtpappointmentDate.Size = new System.Drawing.Size(189, 30);
            this.dtpappointmentDate.TabIndex = 113;
            this.dtpappointmentDate.ValueChanged += new System.EventHandler(this.dtpappointmentDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 118;
            this.label3.Text = "Date:";
            // 
            // timebox
            // 
            this.timebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.timebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timebox.ForeColor = System.Drawing.Color.Gray;
            this.timebox.FormattingEnabled = true;
            this.timebox.Location = new System.Drawing.Point(439, 265);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(300, 29);
            this.timebox.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 120;
            this.label4.Text = "Time:";
            // 
            // underdate
            // 
            this.underdate.BackColor = System.Drawing.Color.Gray;
            this.underdate.Location = new System.Drawing.Point(435, 190);
            this.underdate.Name = "underdate";
            this.underdate.Size = new System.Drawing.Size(300, 3);
            this.underdate.TabIndex = 121;
            // 
            // undertime
            // 
            this.undertime.BackColor = System.Drawing.Color.Gray;
            this.undertime.Location = new System.Drawing.Point(439, 300);
            this.undertime.Name = "undertime";
            this.undertime.Size = new System.Drawing.Size(300, 3);
            this.undertime.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 27);
            this.label10.TabIndex = 123;
            this.label10.Text = "User ID:";
            // 
            // useridbox
            // 
            this.useridbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.useridbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.useridbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridbox.ForeColor = System.Drawing.Color.Gray;
            this.useridbox.Location = new System.Drawing.Point(11, 165);
            this.useridbox.Name = "useridbox";
            this.useridbox.Size = new System.Drawing.Size(314, 25);
            this.useridbox.TabIndex = 124;
            this.useridbox.Text = "e.g: 1002";
            // 
            // underuserid
            // 
            this.underuserid.BackColor = System.Drawing.Color.Gray;
            this.underuserid.Location = new System.Drawing.Point(11, 196);
            this.underuserid.Name = "underuserid";
            this.underuserid.Size = new System.Drawing.Size(300, 3);
            this.underuserid.TabIndex = 125;
            // 
            // l_emptyname
            // 
            this.l_emptyname.AutoSize = true;
            this.l_emptyname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emptyname.Location = new System.Drawing.Point(11, 202);
            this.l_emptyname.Name = "l_emptyname";
            this.l_emptyname.Size = new System.Drawing.Size(245, 21);
            this.l_emptyname.TabIndex = 129;
            this.l_emptyname.Text = "Username cannot be empty";
            this.l_emptyname.Visible = false;
            // 
            // l_wrongusername
            // 
            this.l_wrongusername.AutoSize = true;
            this.l_wrongusername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_wrongusername.Location = new System.Drawing.Point(14, 202);
            this.l_wrongusername.Name = "l_wrongusername";
            this.l_wrongusername.Size = new System.Drawing.Size(224, 21);
            this.l_wrongusername.TabIndex = 130;
            this.l_wrongusername.Text = "This user ID does not exist.";
            this.l_wrongusername.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 136;
            this.label8.Text = "Blood Group:";
            // 
            // underbloodgroup
            // 
            this.underbloodgroup.BackColor = System.Drawing.Color.Gray;
            this.underbloodgroup.Location = new System.Drawing.Point(12, 302);
            this.underbloodgroup.Name = "underbloodgroup";
            this.underbloodgroup.Size = new System.Drawing.Size(300, 3);
            this.underbloodgroup.TabIndex = 137;
            // 
            // l_bloodgroup
            // 
            this.l_bloodgroup.AutoSize = true;
            this.l_bloodgroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bloodgroup.Location = new System.Drawing.Point(15, 308);
            this.l_bloodgroup.Name = "l_bloodgroup";
            this.l_bloodgroup.Size = new System.Drawing.Size(182, 21);
            this.l_bloodgroup.TabIndex = 138;
            this.l_bloodgroup.Text = "Choose blood group";
            this.l_bloodgroup.Visible = false;
            // 
            // bloodgroupbox
            // 
            this.bloodgroupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.bloodgroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodgroupbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodgroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.bloodgroupbox.FormattingEnabled = true;
            this.bloodgroupbox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B-",
            "B+",
            "AB-",
            "AB+",
            "O-",
            "O+"});
            this.bloodgroupbox.Location = new System.Drawing.Point(15, 265);
            this.bloodgroupbox.Name = "bloodgroupbox";
            this.bloodgroupbox.Size = new System.Drawing.Size(300, 31);
            this.bloodgroupbox.TabIndex = 139;
            this.bloodgroupbox.Text = "Choose Blood group";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date.Location = new System.Drawing.Point(439, 196);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(122, 21);
            this.l_date.TabIndex = 141;
            this.l_date.Text = "choose date!";
            this.l_date.Visible = false;
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_time.Location = new System.Drawing.Point(438, 306);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(230, 21);
            this.l_time.TabIndex = 142;
            this.l_time.Text = "Choose appointment time";
            this.l_time.Visible = false;
            // 
            // appoinbtn
            // 
            this.appoinbtn.AutoEllipsis = true;
            this.appoinbtn.FlatAppearance.BorderSize = 3;
            this.appoinbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.appoinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.appoinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appoinbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinbtn.Location = new System.Drawing.Point(523, 330);
            this.appoinbtn.Name = "appoinbtn";
            this.appoinbtn.Size = new System.Drawing.Size(216, 38);
            this.appoinbtn.TabIndex = 145;
            this.appoinbtn.Text = "Make Appointment";
            this.appoinbtn.UseVisualStyleBackColor = true;
            this.appoinbtn.Click += new System.EventHandler(this.appoinbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.dgvappointment);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(12, 334);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 183);
            this.panel5.TabIndex = 147;
            // 
            // dgvappointment
            // 
            this.dgvappointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvappointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.dgvappointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvappointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvappointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvappointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvappointment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvappointment.EnableHeadersVisualStyles = false;
            this.dgvappointment.Location = new System.Drawing.Point(15, 45);
            this.dgvappointment.Name = "dgvappointment";
            this.dgvappointment.RowHeadersVisible = false;
            this.dgvappointment.RowHeadersWidth = 51;
            this.dgvappointment.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.dgvappointment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgvappointment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.dgvappointment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvappointment.RowTemplate.ReadOnly = true;
            this.dgvappointment.Size = new System.Drawing.Size(451, 122);
            this.dgvappointment.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Upcoming Appointments:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(528, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // mdonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appoinbtn);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.bloodgroupbox);
            this.Controls.Add(this.l_bloodgroup);
            this.Controls.Add(this.underbloodgroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l_wrongusername);
            this.Controls.Add(this.l_emptyname);
            this.Controls.Add(this.underuserid);
            this.Controls.Add(this.useridbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.undertime);
            this.Controls.Add(this.underdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.dtpappointmentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdonation";
            this.Size = new System.Drawing.Size(1207, 671);
            this.Load += new System.EventHandler(this.mdonation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datebox;
        private System.Windows.Forms.DateTimePicker dtpappointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel underdate;
        private System.Windows.Forms.Panel undertime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox useridbox;
        private System.Windows.Forms.Panel underuserid;
        private System.Windows.Forms.Label l_emptyname;
        private System.Windows.Forms.Label l_wrongusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel underbloodgroup;
        private System.Windows.Forms.Label l_bloodgroup;
        private System.Windows.Forms.ComboBox bloodgroupbox;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Button appoinbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvappointment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
