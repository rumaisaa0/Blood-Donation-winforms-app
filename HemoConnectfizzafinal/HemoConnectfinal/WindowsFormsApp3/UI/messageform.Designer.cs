namespace WindowsFormsApp3
{
    partial class messageform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageform));
            this.successfulmssg = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.successful_timer = new System.Windows.Forms.Timer(this.components);
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.okbtn = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // successfulmssg
            // 
            this.successfulmssg.AutoSize = true;
            this.successfulmssg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successfulmssg.Location = new System.Drawing.Point(94, 166);
            this.successfulmssg.Name = "successfulmssg";
            this.successfulmssg.Size = new System.Drawing.Size(225, 26);
            this.successfulmssg.TabIndex = 11;
            this.successfulmssg.Text = "Signup Successsful!";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 258);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(406, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 258);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 7);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 7);
            this.panel1.TabIndex = 7;
            // 
            // successful_timer
            // 
            this.successful_timer.Enabled = true;
            this.successful_timer.Interval = 2000;
            // 
            // yesbtn
            // 
            this.yesbtn.AutoEllipsis = true;
            this.yesbtn.FlatAppearance.BorderSize = 3;
            this.yesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.yesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.yesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbtn.Location = new System.Drawing.Point(227, 209);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(92, 38);
            this.yesbtn.TabIndex = 12;
            this.yesbtn.Text = "Yes";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Visible = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.AutoEllipsis = true;
            this.nobtn.FlatAppearance.BorderSize = 3;
            this.nobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.nobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.nobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nobtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobtn.ForeColor = System.Drawing.Color.White;
            this.nobtn.Location = new System.Drawing.Point(99, 209);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(92, 38);
            this.nobtn.TabIndex = 13;
            this.nobtn.Text = "No";
            this.nobtn.UseVisualStyleBackColor = true;
            this.nobtn.Visible = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // okbtn
            // 
            this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbtn.Image = ((System.Drawing.Image)(resources.GetObject("okbtn.Image")));
            this.okbtn.Location = new System.Drawing.Point(347, 13);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(54, 52);
            this.okbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.okbtn.TabIndex = 0;
            this.okbtn.TabStop = false;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // messageform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(413, 272);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.successfulmssg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okbtn);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messageform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox okbtn;
        private System.Windows.Forms.Label successfulmssg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer successful_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}