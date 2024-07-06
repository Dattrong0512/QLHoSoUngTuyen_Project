namespace GUI
{
    partial class DienTTDangKyDoanhNghiep
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.tbTenCongTy = new System.Windows.Forms.TextBox();
            this.tbMaSoThue = new System.Windows.Forms.TextBox();
            this.tbNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(368, 404);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(555, 404);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 28);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.ButtonDangKy_Click);
            // 
            // tbTenCongTy
            // 
            this.tbTenCongTy.Location = new System.Drawing.Point(239, 105);
            this.tbTenCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTenCongTy.Name = "tbTenCongTy";
            this.tbTenCongTy.Size = new System.Drawing.Size(524, 22);
            this.tbTenCongTy.TabIndex = 2;
            // 
            // tbMaSoThue
            // 
            this.tbMaSoThue.Location = new System.Drawing.Point(239, 162);
            this.tbMaSoThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaSoThue.Name = "tbMaSoThue";
            this.tbMaSoThue.Size = new System.Drawing.Size(524, 22);
            this.tbMaSoThue.TabIndex = 3;
            // 
            // tbNguoiDaiDien
            // 
            this.tbNguoiDaiDien.Location = new System.Drawing.Point(239, 225);
            this.tbNguoiDaiDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNguoiDaiDien.Name = "tbNguoiDaiDien";
            this.tbNguoiDaiDien.Size = new System.Drawing.Size(524, 22);
            this.tbNguoiDaiDien.TabIndex = 4;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(239, 289);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(524, 22);
            this.tbDiaChi.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(239, 353);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(524, 22);
            this.tbEmail.TabIndex = 6;
            // 
            // DienTTDangKyDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbNguoiDaiDien);
            this.Controls.Add(this.tbMaSoThue);
            this.Controls.Add(this.tbTenCongTy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnThoat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DienTTDangKyDoanhNghiep";
            this.Text = "DienTTDangKyDoanhNghiep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox tbTenCongTy;
        private System.Windows.Forms.TextBox tbMaSoThue;
        private System.Windows.Forms.TextBox tbNguoiDaiDien;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbEmail;
    }
}