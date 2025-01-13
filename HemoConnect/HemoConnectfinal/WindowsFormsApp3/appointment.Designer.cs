namespace WindowsFormsApp3
{
    partial class appointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvappointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addappoinbtn = new System.Windows.Forms.Button();
            this.l_time = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.bloodgroupbox = new System.Windows.Forms.ComboBox();
            this.l_bloodgroup = new System.Windows.Forms.Label();
            this.underbloodgroup = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.l_wrongusername = new System.Windows.Forms.Label();
            this.l_emptyname = new System.Windows.Forms.Label();
            this.underuserid = new System.Windows.Forms.Panel();
            this.useridbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.undertime = new System.Windows.Forms.Panel();
            this.underdate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.Label();
            this.dtpappointmentDate = new System.Windows.Forms.DateTimePicker();
            this.l_wrongapp = new System.Windows.Forms.Label();
            this.l_emptyapp = new System.Windows.Forms.Label();
            this.underapp = new System.Windows.Forms.Panel();
            this.appidbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.dgvappointment);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(38, 37);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 266);
            this.panel5.TabIndex = 107;
            // 
            // dgvappointment
            // 
            this.dgvappointment.AllowUserToAddRows = false;
            this.dgvappointment.AllowUserToDeleteRows = false;
            this.dgvappointment.AllowUserToOrderColumns = true;
            this.dgvappointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvappointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvappointment.ColumnHeadersHeight = 40;
            this.dgvappointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvappointment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvappointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvappointment.Location = new System.Drawing.Point(7, 47);
            this.dgvappointment.Name = "dgvappointment";
            this.dgvappointment.ReadOnly = true;
            this.dgvappointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvappointment.RowHeadersVisible = false;
            this.dgvappointment.RowHeadersWidth = 51;
            this.dgvappointment.RowTemplate.Height = 30;
            this.dgvappointment.Size = new System.Drawing.Size(471, 219);
            this.dgvappointment.TabIndex = 67;
            this.dgvappointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.dgvappointment.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvappointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvappointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvappointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.dgvappointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvappointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvappointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvappointment.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvappointment.ThemeStyle.ReadOnly = true;
            this.dgvappointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.dgvappointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvappointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvappointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dgvappointment.ThemeStyle.RowsStyle.Height = 30;
            this.dgvappointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvappointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 34);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pending Appointments:";
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
            // addappoinbtn
            // 
            this.addappoinbtn.AutoEllipsis = true;
            this.addappoinbtn.FlatAppearance.BorderSize = 3;
            this.addappoinbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.addappoinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.addappoinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addappoinbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addappoinbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.addappoinbtn.Location = new System.Drawing.Point(446, 529);
            this.addappoinbtn.Name = "addappoinbtn";
            this.addappoinbtn.Size = new System.Drawing.Size(216, 38);
            this.addappoinbtn.TabIndex = 164;
            this.addappoinbtn.Text = "Add Appointment";
            this.addappoinbtn.UseVisualStyleBackColor = true;
            this.addappoinbtn.Click += new System.EventHandler(this.addappoinbtn_Click);
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_time.Location = new System.Drawing.Point(364, 505);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(112, 21);
            this.l_time.TabIndex = 163;
            this.l_time.Text = "choose time";
            this.l_time.Visible = false;
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date.Location = new System.Drawing.Point(366, 409);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(125, 21);
            this.l_date.TabIndex = 162;
            this.l_date.Text = "Choose date!";
            this.l_date.Visible = false;
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
            this.bloodgroupbox.Location = new System.Drawing.Point(41, 462);
            this.bloodgroupbox.Name = "bloodgroupbox";
            this.bloodgroupbox.Size = new System.Drawing.Size(300, 31);
            this.bloodgroupbox.TabIndex = 161;
            this.bloodgroupbox.Text = "Choose Blood group";
            // 
            // l_bloodgroup
            // 
            this.l_bloodgroup.AutoSize = true;
            this.l_bloodgroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bloodgroup.Location = new System.Drawing.Point(41, 505);
            this.l_bloodgroup.Name = "l_bloodgroup";
            this.l_bloodgroup.Size = new System.Drawing.Size(182, 21);
            this.l_bloodgroup.TabIndex = 160;
            this.l_bloodgroup.Text = "Choose blood group";
            this.l_bloodgroup.Visible = false;
            // 
            // underbloodgroup
            // 
            this.underbloodgroup.BackColor = System.Drawing.Color.Gray;
            this.underbloodgroup.Location = new System.Drawing.Point(38, 499);
            this.underbloodgroup.Name = "underbloodgroup";
            this.underbloodgroup.Size = new System.Drawing.Size(300, 3);
            this.underbloodgroup.TabIndex = 159;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 158;
            this.label8.Text = "Blood Group:";
            // 
            // l_wrongusername
            // 
            this.l_wrongusername.AutoSize = true;
            this.l_wrongusername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_wrongusername.Location = new System.Drawing.Point(41, 409);
            this.l_wrongusername.Name = "l_wrongusername";
            this.l_wrongusername.Size = new System.Drawing.Size(224, 21);
            this.l_wrongusername.TabIndex = 157;
            this.l_wrongusername.Text = "This user ID does not exist.";
            this.l_wrongusername.Visible = false;
            // 
            // l_emptyname
            // 
            this.l_emptyname.AutoSize = true;
            this.l_emptyname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emptyname.Location = new System.Drawing.Point(38, 409);
            this.l_emptyname.Name = "l_emptyname";
            this.l_emptyname.Size = new System.Drawing.Size(245, 21);
            this.l_emptyname.TabIndex = 156;
            this.l_emptyname.Text = "Username cannot be empty";
            this.l_emptyname.Visible = false;
            // 
            // underuserid
            // 
            this.underuserid.BackColor = System.Drawing.Color.Gray;
            this.underuserid.Location = new System.Drawing.Point(38, 403);
            this.underuserid.Name = "underuserid";
            this.underuserid.Size = new System.Drawing.Size(300, 3);
            this.underuserid.TabIndex = 155;
            // 
            // useridbox
            // 
            this.useridbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.useridbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.useridbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridbox.ForeColor = System.Drawing.Color.Gray;
            this.useridbox.Location = new System.Drawing.Point(38, 372);
            this.useridbox.Name = "useridbox";
            this.useridbox.Size = new System.Drawing.Size(314, 25);
            this.useridbox.TabIndex = 154;
            this.useridbox.Text = "e.g: 1002";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 27);
            this.label10.TabIndex = 153;
            this.label10.Text = "User ID:";
            // 
            // undertime
            // 
            this.undertime.BackColor = System.Drawing.Color.Gray;
            this.undertime.Location = new System.Drawing.Point(365, 499);
            this.undertime.Name = "undertime";
            this.undertime.Size = new System.Drawing.Size(300, 3);
            this.undertime.TabIndex = 152;
            // 
            // underdate
            // 
            this.underdate.BackColor = System.Drawing.Color.Gray;
            this.underdate.Location = new System.Drawing.Point(362, 403);
            this.underdate.Name = "underdate";
            this.underdate.Size = new System.Drawing.Size(300, 3);
            this.underdate.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 150;
            this.label4.Text = "Time:";
            // 
            // timebox
            // 
            this.timebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.timebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timebox.ForeColor = System.Drawing.Color.Gray;
            this.timebox.FormattingEnabled = true;
            this.timebox.Location = new System.Drawing.Point(365, 462);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(300, 35);
            this.timebox.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 148;
            this.label3.Text = "Date:";
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.ForeColor = System.Drawing.Color.Gray;
            this.datebox.Location = new System.Drawing.Point(362, 376);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(196, 27);
            this.datebox.TabIndex = 147;
            this.datebox.Text = "e.g:Apr 19,2024";
            this.datebox.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // dtpappointmentDate
            // 
            this.dtpappointmentDate.CustomFormat = "MMM dd, yyyy";
            this.dtpappointmentDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpappointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpappointmentDate.Location = new System.Drawing.Point(362, 376);
            this.dtpappointmentDate.Name = "dtpappointmentDate";
            this.dtpappointmentDate.Size = new System.Drawing.Size(189, 30);
            this.dtpappointmentDate.TabIndex = 146;
            this.dtpappointmentDate.ValueChanged += new System.EventHandler(this.dtpappointmentDate_ValueChanged);
            // 
            // l_wrongapp
            // 
            this.l_wrongapp.AutoSize = true;
            this.l_wrongapp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_wrongapp.Location = new System.Drawing.Point(522, 156);
            this.l_wrongapp.Name = "l_wrongapp";
            this.l_wrongapp.Size = new System.Drawing.Size(302, 21);
            this.l_wrongapp.TabIndex = 169;
            this.l_wrongapp.Text = "This Appointment ID does not exist.";
            this.l_wrongapp.Visible = false;
            // 
            // l_emptyapp
            // 
            this.l_emptyapp.AutoSize = true;
            this.l_emptyapp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emptyapp.Location = new System.Drawing.Point(519, 156);
            this.l_emptyapp.Name = "l_emptyapp";
            this.l_emptyapp.Size = new System.Drawing.Size(296, 21);
            this.l_emptyapp.TabIndex = 168;
            this.l_emptyapp.Text = "Appointment ID cannot be empty";
            this.l_emptyapp.Visible = false;
            // 
            // underapp
            // 
            this.underapp.BackColor = System.Drawing.Color.Gray;
            this.underapp.Location = new System.Drawing.Point(519, 150);
            this.underapp.Name = "underapp";
            this.underapp.Size = new System.Drawing.Size(300, 3);
            this.underapp.TabIndex = 167;
            // 
            // appidbox
            // 
            this.appidbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.appidbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appidbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appidbox.ForeColor = System.Drawing.Color.Gray;
            this.appidbox.Location = new System.Drawing.Point(519, 119);
            this.appidbox.Name = "appidbox";
            this.appidbox.Size = new System.Drawing.Size(314, 25);
            this.appidbox.TabIndex = 166;
            this.appidbox.Text = "e.g: 1002";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 27);
            this.label7.TabIndex = 165;
            this.label7.Text = "Appointment ID:";
            // 
            // cancelbtn
            // 
            this.cancelbtn.AutoEllipsis = true;
            this.cancelbtn.FlatAppearance.BorderSize = 3;
            this.cancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.cancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.cancelbtn.Location = new System.Drawing.Point(519, 194);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(108, 38);
            this.cancelbtn.TabIndex = 170;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.AutoEllipsis = true;
            this.confirmbtn.FlatAppearance.BorderSize = 3;
            this.confirmbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.confirmbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.Color.Gray;
            this.confirmbtn.Location = new System.Drawing.Point(656, 194);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(108, 38);
            this.confirmbtn.TabIndex = 171;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 39);
            this.label9.TabIndex = 172;
            this.label9.Text = "Update Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 39);
            this.label11.TabIndex = 173;
            this.label11.Text = "Add Appointment:";
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.l_wrongapp);
            this.Controls.Add(this.l_emptyapp);
            this.Controls.Add(this.underapp);
            this.Controls.Add(this.appidbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addappoinbtn);
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
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "appointment";
            this.Size = new System.Drawing.Size(1207, 763);
            this.Load += new System.EventHandler(this.appointment_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button addappoinbtn;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.ComboBox bloodgroupbox;
        private System.Windows.Forms.Label l_bloodgroup;
        private System.Windows.Forms.Panel underbloodgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_wrongusername;
        private System.Windows.Forms.Label l_emptyname;
        private System.Windows.Forms.Panel underuserid;
        private System.Windows.Forms.TextBox useridbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel undertime;
        private System.Windows.Forms.Panel underdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datebox;
        private System.Windows.Forms.DateTimePicker dtpappointmentDate;
        private System.Windows.Forms.Label l_wrongapp;
        private System.Windows.Forms.Label l_emptyapp;
        private System.Windows.Forms.Panel underapp;
        private System.Windows.Forms.TextBox appidbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView dgvappointment;
    }
}
