namespace WindowsFormsApp3
{
    partial class transfusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transfusion));
            this.label9 = new System.Windows.Forms.Label();
            this.bloodgroupbox = new System.Windows.Forms.ComboBox();
            this.emptybloodgroup = new System.Windows.Forms.Label();
            this.ubloodgroup = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.wrongrecipient = new System.Windows.Forms.Label();
            this.emptyrecipient = new System.Windows.Forms.Label();
            this.urecipient = new System.Windows.Forms.Panel();
            this.recipientbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wrongdonor = new System.Windows.Forms.Label();
            this.emptydonor = new System.Windows.Forms.Label();
            this.udonor = new System.Windows.Forms.Panel();
            this.donorbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emptydate = new System.Windows.Forms.Label();
            this.udate = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.Label();
            this.dtpappointmentDate = new System.Windows.Forms.DateTimePicker();
            this.wrongquantity = new System.Windows.Forms.Label();
            this.emptyquantity = new System.Windows.Forms.Label();
            this.uquantity = new System.Windows.Forms.Panel();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.wrongpurpose = new System.Windows.Forms.Label();
            this.upurpose = new System.Windows.Forms.Panel();
            this.purposebox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 39);
            this.label9.TabIndex = 94;
            this.label9.Text = "Transfusions";
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
            this.bloodgroupbox.Location = new System.Drawing.Point(24, 334);
            this.bloodgroupbox.Name = "bloodgroupbox";
            this.bloodgroupbox.Size = new System.Drawing.Size(300, 31);
            this.bloodgroupbox.TabIndex = 148;
            this.bloodgroupbox.Text = "Choose Blood group";
            // 
            // emptybloodgroup
            // 
            this.emptybloodgroup.AutoSize = true;
            this.emptybloodgroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptybloodgroup.Location = new System.Drawing.Point(24, 377);
            this.emptybloodgroup.Name = "emptybloodgroup";
            this.emptybloodgroup.Size = new System.Drawing.Size(182, 21);
            this.emptybloodgroup.TabIndex = 147;
            this.emptybloodgroup.Text = "Choose blood group";
            this.emptybloodgroup.Visible = false;
            // 
            // ubloodgroup
            // 
            this.ubloodgroup.BackColor = System.Drawing.Color.Gray;
            this.ubloodgroup.Location = new System.Drawing.Point(21, 371);
            this.ubloodgroup.Name = "ubloodgroup";
            this.ubloodgroup.Size = new System.Drawing.Size(300, 3);
            this.ubloodgroup.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 145;
            this.label8.Text = "Blood Group:";
            // 
            // wrongrecipient
            // 
            this.wrongrecipient.AutoSize = true;
            this.wrongrecipient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongrecipient.Location = new System.Drawing.Point(23, 271);
            this.wrongrecipient.Name = "wrongrecipient";
            this.wrongrecipient.Size = new System.Drawing.Size(264, 21);
            this.wrongrecipient.TabIndex = 144;
            this.wrongrecipient.Text = "This recipient ID does not exist.";
            this.wrongrecipient.Visible = false;
            // 
            // emptyrecipient
            // 
            this.emptyrecipient.AutoSize = true;
            this.emptyrecipient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyrecipient.Location = new System.Drawing.Point(20, 271);
            this.emptyrecipient.Name = "emptyrecipient";
            this.emptyrecipient.Size = new System.Drawing.Size(263, 21);
            this.emptyrecipient.TabIndex = 143;
            this.emptyrecipient.Text = "Recipient ID cannot be empty";
            this.emptyrecipient.Visible = false;
            // 
            // urecipient
            // 
            this.urecipient.BackColor = System.Drawing.Color.Gray;
            this.urecipient.Location = new System.Drawing.Point(20, 265);
            this.urecipient.Name = "urecipient";
            this.urecipient.Size = new System.Drawing.Size(300, 3);
            this.urecipient.TabIndex = 142;
            // 
            // recipientbox
            // 
            this.recipientbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.recipientbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipientbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientbox.ForeColor = System.Drawing.Color.Gray;
            this.recipientbox.Location = new System.Drawing.Point(20, 234);
            this.recipientbox.Name = "recipientbox";
            this.recipientbox.Size = new System.Drawing.Size(314, 25);
            this.recipientbox.TabIndex = 141;
            this.recipientbox.Text = "e.g: 1002";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 27);
            this.label10.TabIndex = 140;
            this.label10.Text = "Recipient ID:";
            // 
            // wrongdonor
            // 
            this.wrongdonor.AutoSize = true;
            this.wrongdonor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongdonor.Location = new System.Drawing.Point(411, 271);
            this.wrongdonor.Name = "wrongdonor";
            this.wrongdonor.Size = new System.Drawing.Size(241, 21);
            this.wrongdonor.TabIndex = 153;
            this.wrongdonor.Text = "This Donor ID does not exist.";
            this.wrongdonor.Visible = false;
            // 
            // emptydonor
            // 
            this.emptydonor.AutoSize = true;
            this.emptydonor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptydonor.Location = new System.Drawing.Point(408, 271);
            this.emptydonor.Name = "emptydonor";
            this.emptydonor.Size = new System.Drawing.Size(230, 21);
            this.emptydonor.TabIndex = 152;
            this.emptydonor.Text = "DonorID cannot be empty";
            this.emptydonor.Visible = false;
            // 
            // udonor
            // 
            this.udonor.BackColor = System.Drawing.Color.Gray;
            this.udonor.Location = new System.Drawing.Point(408, 265);
            this.udonor.Name = "udonor";
            this.udonor.Size = new System.Drawing.Size(300, 3);
            this.udonor.TabIndex = 151;
            // 
            // donorbox
            // 
            this.donorbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.donorbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donorbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorbox.ForeColor = System.Drawing.Color.Gray;
            this.donorbox.Location = new System.Drawing.Point(408, 234);
            this.donorbox.Name = "donorbox";
            this.donorbox.Size = new System.Drawing.Size(314, 25);
            this.donorbox.TabIndex = 150;
            this.donorbox.Text = "e.g: 1002";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 149;
            this.label3.Text = "Donor ID:";
            // 
            // emptydate
            // 
            this.emptydate.AutoSize = true;
            this.emptydate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptydate.Location = new System.Drawing.Point(416, 377);
            this.emptydate.Name = "emptydate";
            this.emptydate.Size = new System.Drawing.Size(118, 21);
            this.emptydate.TabIndex = 167;
            this.emptydate.Text = "choose date";
            this.emptydate.Visible = false;
            // 
            // udate
            // 
            this.udate.BackColor = System.Drawing.Color.Gray;
            this.udate.Location = new System.Drawing.Point(412, 371);
            this.udate.Name = "udate";
            this.udate.Size = new System.Drawing.Size(300, 3);
            this.udate.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 27);
            this.label5.TabIndex = 165;
            this.label5.Text = "Date:";
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.ForeColor = System.Drawing.Color.Gray;
            this.datebox.Location = new System.Drawing.Point(412, 344);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(196, 27);
            this.datebox.TabIndex = 164;
            this.datebox.Text = "e.g: Apr 19,2024";
            this.datebox.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // dtpappointmentDate
            // 
            this.dtpappointmentDate.CustomFormat = "MMM dd, yyyy";
            this.dtpappointmentDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpappointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpappointmentDate.Location = new System.Drawing.Point(412, 344);
            this.dtpappointmentDate.Name = "dtpappointmentDate";
            this.dtpappointmentDate.Size = new System.Drawing.Size(189, 30);
            this.dtpappointmentDate.TabIndex = 163;
            this.dtpappointmentDate.ValueChanged += new System.EventHandler(this.dtpappointmentDate_ValueChanged);
            // 
            // wrongquantity
            // 
            this.wrongquantity.AutoSize = true;
            this.wrongquantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongquantity.Location = new System.Drawing.Point(36, 472);
            this.wrongquantity.Name = "wrongquantity";
            this.wrongquantity.Size = new System.Drawing.Size(143, 21);
            this.wrongquantity.TabIndex = 172;
            this.wrongquantity.Text = "Invalid Quantity";
            this.wrongquantity.Visible = false;
            // 
            // emptyquantity
            // 
            this.emptyquantity.AutoSize = true;
            this.emptyquantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyquantity.Location = new System.Drawing.Point(31, 472);
            this.emptyquantity.Name = "emptyquantity";
            this.emptyquantity.Size = new System.Drawing.Size(234, 21);
            this.emptyquantity.TabIndex = 171;
            this.emptyquantity.Text = "Quantity cannot be empty";
            this.emptyquantity.Visible = false;
            // 
            // uquantity
            // 
            this.uquantity.BackColor = System.Drawing.Color.Gray;
            this.uquantity.Location = new System.Drawing.Point(25, 466);
            this.uquantity.Name = "uquantity";
            this.uquantity.Size = new System.Drawing.Size(300, 3);
            this.uquantity.TabIndex = 170;
            // 
            // quantitybox
            // 
            this.quantitybox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.quantitybox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantitybox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitybox.ForeColor = System.Drawing.Color.Gray;
            this.quantitybox.Location = new System.Drawing.Point(34, 435);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(314, 25);
            this.quantitybox.TabIndex = 169;
            this.quantitybox.Text = "e.g: 35";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 27);
            this.label11.TabIndex = 168;
            this.label11.Text = "Quantity:";
            // 
            // wrongpurpose
            // 
            this.wrongpurpose.AutoSize = true;
            this.wrongpurpose.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongpurpose.Location = new System.Drawing.Point(414, 472);
            this.wrongpurpose.Name = "wrongpurpose";
            this.wrongpurpose.Size = new System.Drawing.Size(137, 21);
            this.wrongpurpose.TabIndex = 176;
            this.wrongpurpose.Text = "invalid purpose";
            this.wrongpurpose.Visible = false;
            // 
            // upurpose
            // 
            this.upurpose.BackColor = System.Drawing.Color.Gray;
            this.upurpose.Location = new System.Drawing.Point(408, 466);
            this.upurpose.Name = "upurpose";
            this.upurpose.Size = new System.Drawing.Size(300, 3);
            this.upurpose.TabIndex = 175;
            // 
            // purposebox
            // 
            this.purposebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.purposebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purposebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposebox.ForeColor = System.Drawing.Color.Gray;
            this.purposebox.Location = new System.Drawing.Point(417, 435);
            this.purposebox.Name = "purposebox";
            this.purposebox.Size = new System.Drawing.Size(314, 25);
            this.purposebox.TabIndex = 174;
            this.purposebox.Text = "e.g: 35";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(419, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 27);
            this.label12.TabIndex = 173;
            this.label12.Text = "Purpose:";
            // 
            // confirmbtn
            // 
            this.confirmbtn.AutoEllipsis = true;
            this.confirmbtn.FlatAppearance.BorderSize = 3;
            this.confirmbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.confirmbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.Color.Gray;
            this.confirmbtn.Image = ((System.Drawing.Image)(resources.GetObject("confirmbtn.Image")));
            this.confirmbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmbtn.Location = new System.Drawing.Point(541, 526);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(171, 52);
            this.confirmbtn.TabIndex = 178;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 179;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(404, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 180;
            this.pictureBox2.TabStop = false;
            // 
            // transfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.wrongpurpose);
            this.Controls.Add(this.upurpose);
            this.Controls.Add(this.purposebox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.wrongquantity);
            this.Controls.Add(this.emptyquantity);
            this.Controls.Add(this.uquantity);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emptydate);
            this.Controls.Add(this.udate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.dtpappointmentDate);
            this.Controls.Add(this.wrongdonor);
            this.Controls.Add(this.emptydonor);
            this.Controls.Add(this.udonor);
            this.Controls.Add(this.donorbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bloodgroupbox);
            this.Controls.Add(this.emptybloodgroup);
            this.Controls.Add(this.ubloodgroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wrongrecipient);
            this.Controls.Add(this.emptyrecipient);
            this.Controls.Add(this.urecipient);
            this.Controls.Add(this.recipientbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.Name = "transfusion";
            this.Size = new System.Drawing.Size(1207, 763);
            this.Load += new System.EventHandler(this.transfusion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bloodgroupbox;
        private System.Windows.Forms.Label emptybloodgroup;
        private System.Windows.Forms.Panel ubloodgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wrongrecipient;
        private System.Windows.Forms.Label emptyrecipient;
        private System.Windows.Forms.Panel urecipient;
        private System.Windows.Forms.TextBox recipientbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label wrongdonor;
        private System.Windows.Forms.Label emptydonor;
        private System.Windows.Forms.Panel udonor;
        private System.Windows.Forms.TextBox donorbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emptydate;
        private System.Windows.Forms.Panel udate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datebox;
        private System.Windows.Forms.DateTimePicker dtpappointmentDate;
        private System.Windows.Forms.Label wrongquantity;
        private System.Windows.Forms.Label emptyquantity;
        private System.Windows.Forms.Panel uquantity;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label wrongpurpose;
        private System.Windows.Forms.Panel upurpose;
        private System.Windows.Forms.TextBox purposebox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
