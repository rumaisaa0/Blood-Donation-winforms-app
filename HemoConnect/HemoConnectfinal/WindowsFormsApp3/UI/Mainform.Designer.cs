namespace WindowsFormsApp3
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainsidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarbtn = new System.Windows.Forms.PictureBox();
            this.donorbtn = new System.Windows.Forms.Button();
            this.donationbtn = new System.Windows.Forms.Button();
            this.transfusionbtn = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.mainmenu_timer = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            //this.donationhistory1 = new WindowsFormsApp3.donationhistory();
            //this.donors1 = new WindowsFormsApp3.donors();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 75);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1406, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hemo Connect";
            // 
            // mainsidebar
            // 
            this.mainsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.mainsidebar.Controls.Add(this.sidebarbtn);
            this.mainsidebar.Controls.Add(this.donorbtn);
            this.mainsidebar.Controls.Add(this.donationbtn);
            this.mainsidebar.Controls.Add(this.transfusionbtn);
            this.mainsidebar.Controls.Add(this.aboutbtn);
            this.mainsidebar.Controls.Add(this.logoutbtn);
            this.mainsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainsidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.mainsidebar.Location = new System.Drawing.Point(0, 75);
            this.mainsidebar.Name = "mainsidebar";
            this.mainsidebar.Size = new System.Drawing.Size(260, 763);
            this.mainsidebar.TabIndex = 1;
            // 
            // sidebarbtn
            // 
            this.sidebarbtn.Image = ((System.Drawing.Image)(resources.GetObject("sidebarbtn.Image")));
            this.sidebarbtn.Location = new System.Drawing.Point(3, 3);
            this.sidebarbtn.Name = "sidebarbtn";
            this.sidebarbtn.Size = new System.Drawing.Size(62, 45);
            this.sidebarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sidebarbtn.TabIndex = 0;
            this.sidebarbtn.TabStop = false;
            this.sidebarbtn.Click += new System.EventHandler(this.sidebarbtn_Click);
            // 
            // donorbtn
            // 
            this.donorbtn.FlatAppearance.BorderSize = 0;
            this.donorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donorbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorbtn.Image = ((System.Drawing.Image)(resources.GetObject("donorbtn.Image")));
            this.donorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donorbtn.Location = new System.Drawing.Point(3, 54);
            this.donorbtn.Name = "donorbtn";
            this.donorbtn.Size = new System.Drawing.Size(260, 70);
            this.donorbtn.TabIndex = 2;
            this.donorbtn.Text = "Donors";
            this.donorbtn.UseVisualStyleBackColor = true;
            this.donorbtn.Click += new System.EventHandler(this.donorbtn_Click);
            // 
            // donationbtn
            // 
            this.donationbtn.FlatAppearance.BorderSize = 0;
            this.donationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donationbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationbtn.Image = ((System.Drawing.Image)(resources.GetObject("donationbtn.Image")));
            this.donationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donationbtn.Location = new System.Drawing.Point(3, 130);
            this.donationbtn.Name = "donationbtn";
            this.donationbtn.Size = new System.Drawing.Size(260, 70);
            this.donationbtn.TabIndex = 3;
            this.donationbtn.Text = "Donations";
            this.donationbtn.UseVisualStyleBackColor = true;
            this.donationbtn.Click += new System.EventHandler(this.donationbtn_Click);
            // 
            // transfusionbtn
            // 
            this.transfusionbtn.FlatAppearance.BorderSize = 0;
            this.transfusionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfusionbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfusionbtn.Image = ((System.Drawing.Image)(resources.GetObject("transfusionbtn.Image")));
            this.transfusionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transfusionbtn.Location = new System.Drawing.Point(3, 206);
            this.transfusionbtn.Name = "transfusionbtn";
            this.transfusionbtn.Size = new System.Drawing.Size(260, 70);
            this.transfusionbtn.TabIndex = 4;
            this.transfusionbtn.Text = "  Transfusion";
            this.transfusionbtn.UseVisualStyleBackColor = true;
            this.transfusionbtn.Click += new System.EventHandler(this.transfusionbtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutbtn.Image")));
            this.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbtn.Location = new System.Drawing.Point(3, 282);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(260, 70);
            this.aboutbtn.TabIndex = 5;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(3, 358);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(260, 70);
            this.logoutbtn.TabIndex = 6;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // mainmenu_timer
            // 
            this.mainmenu_timer.Interval = 7;
            this.mainmenu_timer.Tick += new System.EventHandler(this.mainmenu_timer_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // donationhistory1
            // 
            //this.donationhistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            //this.donationhistory1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            //this.donationhistory1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            //this.donationhistory1.Location = new System.Drawing.Point(261, 75);
            //this.donationhistory1.Name = "donationhistory1";
            //this.donationhistory1.Size = new System.Drawing.Size(1207, 763);
            //this.donationhistory1.TabIndex = 3;
            //this.donationhistory1.Visible = false;
            // 
            // donors1
            // 
            //this.donors1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            //this.donors1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            //this.donors1.Location = new System.Drawing.Point(261, 75);
            //this.donors1.Name = "donors1";
            //this.donors1.Size = new System.Drawing.Size(1207, 763);
            //this.donors1.TabIndex = 4;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1467, 838);
            //this.Controls.Add(this.donors1);
            //this.Controls.Add(this.donationhistory1);
            this.Controls.Add(this.mainsidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logindialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel mainsidebar;
        private System.Windows.Forms.PictureBox sidebarbtn;
        private System.Windows.Forms.Button donorbtn;
        private System.Windows.Forms.Button donationbtn;
        private System.Windows.Forms.Button transfusionbtn;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Timer mainmenu_timer;
        //private donors donors1;
        //private donationhistory donationhistory1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        //private donors donors1;
    }
}