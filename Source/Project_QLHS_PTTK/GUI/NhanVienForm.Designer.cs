namespace GUI
{
    partial class NhanVienForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonTraCuuPDT = new System.Windows.Forms.Button();
            this.buttonTraCuuHS = new System.Windows.Forms.Button();
            this.ButtonTraCuuDN = new System.Windows.Forms.Button();
            this.ButtonTraCuuUV = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(803, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(94, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Xin chào ";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 33);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.AliceBlue;
            this.panelLeft.Controls.Add(this.buttonTraCuuPDT);
            this.panelLeft.Controls.Add(this.buttonTraCuuHS);
            this.panelLeft.Controls.Add(this.ButtonTraCuuDN);
            this.panelLeft.Controls.Add(this.ButtonTraCuuUV);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 101);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(190, 504);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonTraCuuPDT
            // 
            this.buttonTraCuuPDT.BackColor = System.Drawing.Color.LightCyan;
            this.buttonTraCuuPDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTraCuuPDT.FlatAppearance.BorderSize = 0;
            this.buttonTraCuuPDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraCuuPDT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTraCuuPDT.Location = new System.Drawing.Point(0, 213);
            this.buttonTraCuuPDT.Name = "buttonTraCuuPDT";
            this.buttonTraCuuPDT.Size = new System.Drawing.Size(190, 70);
            this.buttonTraCuuPDT.TabIndex = 3;
            this.buttonTraCuuPDT.Text = "Tra cứu phiếu đăng tuyền";
            this.buttonTraCuuPDT.UseVisualStyleBackColor = false;
            // 
            // buttonTraCuuHS
            // 
            this.buttonTraCuuHS.BackColor = System.Drawing.Color.LightCyan;
            this.buttonTraCuuHS.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTraCuuHS.FlatAppearance.BorderSize = 0;
            this.buttonTraCuuHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraCuuHS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTraCuuHS.Location = new System.Drawing.Point(0, 143);
            this.buttonTraCuuHS.Name = "buttonTraCuuHS";
            this.buttonTraCuuHS.Size = new System.Drawing.Size(190, 70);
            this.buttonTraCuuHS.TabIndex = 2;
            this.buttonTraCuuHS.Text = "Tra cứu hồ sơ";
            this.buttonTraCuuHS.UseVisualStyleBackColor = false;
            // 
            // ButtonTraCuuDN
            // 
            this.ButtonTraCuuDN.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonTraCuuDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTraCuuDN.FlatAppearance.BorderSize = 0;
            this.ButtonTraCuuDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTraCuuDN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonTraCuuDN.Location = new System.Drawing.Point(0, 70);
            this.ButtonTraCuuDN.Name = "ButtonTraCuuDN";
            this.ButtonTraCuuDN.Size = new System.Drawing.Size(190, 73);
            this.ButtonTraCuuDN.TabIndex = 1;
            this.ButtonTraCuuDN.Text = "Tra cứu doanh nghiệp";
            this.ButtonTraCuuDN.UseVisualStyleBackColor = false;
            this.ButtonTraCuuDN.Click += new System.EventHandler(this.ButtonTraCuuDN_Click);
            // 
            // ButtonTraCuuUV
            // 
            this.ButtonTraCuuUV.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonTraCuuUV.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTraCuuUV.FlatAppearance.BorderSize = 0;
            this.ButtonTraCuuUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTraCuuUV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonTraCuuUV.Location = new System.Drawing.Point(0, 0);
            this.ButtonTraCuuUV.Name = "ButtonTraCuuUV";
            this.ButtonTraCuuUV.Size = new System.Drawing.Size(190, 70);
            this.ButtonTraCuuUV.TabIndex = 0;
            this.ButtonTraCuuUV.Text = "Tra cứu ứng viên";
            this.ButtonTraCuuUV.UseVisualStyleBackColor = false;
            this.ButtonTraCuuUV.Click += new System.EventHandler(this.ButtonTraCuuUV_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.LabelTitle);
            this.panelTop.Controls.Add(this.buttonLogout);
            this.panelTop.Controls.Add(this.TitleLabel);
            this.panelTop.Controls.Add(this.dateTimePicker1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1104, 101);
            this.panelTop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Company_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelTitle.Location = new System.Drawing.Point(196, 27);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(331, 46);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Tra cứu ứng viên";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.Location = new System.Drawing.Point(948, 65);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(153, 39);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.Window;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(190, 101);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(914, 504);
            this.panelBody.TabIndex = 5;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint_1);
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 605);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVienForm";
            this.Text = "NhanVienForm";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button ButtonTraCuuUV;
        private System.Windows.Forms.Button ButtonTraCuuDN;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTraCuuPDT;
        private System.Windows.Forms.Button buttonTraCuuHS;
    }
}