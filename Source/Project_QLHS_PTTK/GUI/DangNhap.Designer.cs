namespace GUI
{
    partial class DangNhap
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
            this.LabelUser = new System.Windows.Forms.Label();
            this.TextBoxUSN = new System.Windows.Forms.TextBox();
            this.TextBoxPSW = new System.Windows.Forms.TextBox();
            this.LabelPW = new System.Windows.Forms.Label();
            this.ButtonDN = new System.Windows.Forms.Button();
            this.ButtonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HinhAnh = new System.Windows.Forms.PictureBox();
            this.TextDN = new System.Windows.Forms.Label();
            this.groupBoxDN = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).BeginInit();
            this.groupBoxDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelUser.Location = new System.Drawing.Point(22, 52);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(84, 19);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "Tài khoản";
            // 
            // TextBoxUSN
            // 
            this.TextBoxUSN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBoxUSN.Location = new System.Drawing.Point(170, 43);
            this.TextBoxUSN.Name = "TextBoxUSN";
            this.TextBoxUSN.Size = new System.Drawing.Size(222, 29);
            this.TextBoxUSN.TabIndex = 1;
            // 
            // TextBoxPSW
            // 
            this.TextBoxPSW.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBoxPSW.Location = new System.Drawing.Point(170, 93);
            this.TextBoxPSW.Name = "TextBoxPSW";
            this.TextBoxPSW.PasswordChar = '*';
            this.TextBoxPSW.Size = new System.Drawing.Size(219, 29);
            this.TextBoxPSW.TabIndex = 2;
            this.TextBoxPSW.TextChanged += new System.EventHandler(this.TextBoxPSW_TextChanged);
            // 
            // LabelPW
            // 
            this.LabelPW.AutoSize = true;
            this.LabelPW.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelPW.Location = new System.Drawing.Point(28, 102);
            this.LabelPW.Name = "LabelPW";
            this.LabelPW.Size = new System.Drawing.Size(78, 19);
            this.LabelPW.TabIndex = 3;
            this.LabelPW.Text = "Mật khẩu";
            // 
            // ButtonDN
            // 
            this.ButtonDN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDN.Location = new System.Drawing.Point(56, 181);
            this.ButtonDN.Name = "ButtonDN";
            this.ButtonDN.Size = new System.Drawing.Size(162, 51);
            this.ButtonDN.TabIndex = 4;
            this.ButtonDN.Text = "Đăng nhập";
            this.ButtonDN.UseVisualStyleBackColor = false;
            this.ButtonDN.Click += new System.EventHandler(this.ButtonDN_Click);
            // 
            // ButtonThoat
            // 
            this.ButtonThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThoat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonThoat.Location = new System.Drawing.Point(271, 181);
            this.ButtonThoat.Name = "ButtonThoat";
            this.ButtonThoat.Size = new System.Drawing.Size(108, 51);
            this.ButtonThoat.TabIndex = 5;
            this.ButtonThoat.Text = "Thoát";
            this.ButtonThoat.UseVisualStyleBackColor = false;
            this.ButtonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HinhAnh);
            this.groupBox1.Location = new System.Drawing.Point(36, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HinhAnh.Image = global::GUI.Properties.Resources.AnhDangNhap;
            this.HinhAnh.Location = new System.Drawing.Point(3, 16);
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Size = new System.Drawing.Size(280, 187);
            this.HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HinhAnh.TabIndex = 0;
            this.HinhAnh.TabStop = false;
            // 
            // TextDN
            // 
            this.TextDN.AutoSize = true;
            this.TextDN.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextDN.ForeColor = System.Drawing.Color.DarkOrange;
            this.TextDN.Location = new System.Drawing.Point(289, 53);
            this.TextDN.Name = "TextDN";
            this.TextDN.Size = new System.Drawing.Size(255, 29);
            this.TextDN.TabIndex = 7;
            this.TextDN.Text = "Đăng nhập hệ thống";
            // 
            // groupBoxDN
            // 
            this.groupBoxDN.Controls.Add(this.TextBoxUSN);
            this.groupBoxDN.Controls.Add(this.TextBoxPSW);
            this.groupBoxDN.Controls.Add(this.ButtonThoat);
            this.groupBoxDN.Controls.Add(this.ButtonDN);
            this.groupBoxDN.Controls.Add(this.LabelUser);
            this.groupBoxDN.Controls.Add(this.LabelPW);
            this.groupBoxDN.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDN.Location = new System.Drawing.Point(349, 103);
            this.groupBoxDN.Name = "groupBoxDN";
            this.groupBoxDN.Size = new System.Drawing.Size(430, 281);
            this.groupBoxDN.TabIndex = 8;
            this.groupBoxDN.TabStop = false;
            this.groupBoxDN.Text = "Thông tin đăng nhập";
            this.groupBoxDN.Enter += new System.EventHandler(this.groupBoxDN_Enter);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDN);
            this.Controls.Add(this.TextDN);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).EndInit();
            this.groupBoxDN.ResumeLayout(false);
            this.groupBoxDN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.TextBox TextBoxUSN;
        private System.Windows.Forms.TextBox TextBoxPSW;
        private System.Windows.Forms.Label LabelPW;
        private System.Windows.Forms.Button ButtonDN;
        private System.Windows.Forms.Button ButtonThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox HinhAnh;
        private System.Windows.Forms.Label TextDN;
        private System.Windows.Forms.GroupBox groupBoxDN;
    }
}