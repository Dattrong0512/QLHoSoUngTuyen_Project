namespace GUI
{
    partial class DienPhieuDangKyUngVien
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
            this.textBoxhovaten = new System.Windows.Forms.TextBox();
            this.textĐC = new System.Windows.Forms.TextBox();
            this.textsdt = new System.Windows.Forms.TextBox();
            this.labelhovaten = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelnamsinh = new System.Windows.Forms.Label();
            this.labelĐC = new System.Windows.Forms.Label();
            this.labesdt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonĐK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxhovaten
            // 
            this.textBoxhovaten.Location = new System.Drawing.Point(249, 118);
            this.textBoxhovaten.Name = "textBoxhovaten";
            this.textBoxhovaten.Size = new System.Drawing.Size(306, 22);
            this.textBoxhovaten.TabIndex = 0;
            // 
            // textĐC
            // 
            this.textĐC.Location = new System.Drawing.Point(249, 315);
            this.textĐC.Name = "textĐC";
            this.textĐC.Size = new System.Drawing.Size(306, 22);
            this.textĐC.TabIndex = 2;
            // 
            // textsdt
            // 
            this.textsdt.Location = new System.Drawing.Point(249, 244);
            this.textsdt.Name = "textsdt";
            this.textsdt.Size = new System.Drawing.Size(306, 22);
            this.textsdt.TabIndex = 3;
            // 
            // labelhovaten
            // 
            this.labelhovaten.AutoSize = true;
            this.labelhovaten.Location = new System.Drawing.Point(258, 99);
            this.labelhovaten.Name = "labelhovaten";
            this.labelhovaten.Size = new System.Drawing.Size(64, 16);
            this.labelhovaten.TabIndex = 4;
            this.labelhovaten.Text = "Họ và tên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelnamsinh
            // 
            this.labelnamsinh.AutoSize = true;
            this.labelnamsinh.Location = new System.Drawing.Point(258, 158);
            this.labelnamsinh.Name = "labelnamsinh";
            this.labelnamsinh.Size = new System.Drawing.Size(67, 16);
            this.labelnamsinh.TabIndex = 6;
            this.labelnamsinh.Text = "Ngày sinh";
            // 
            // labelĐC
            // 
            this.labelĐC.AutoSize = true;
            this.labelĐC.Location = new System.Drawing.Point(258, 225);
            this.labelĐC.Name = "labelĐC";
            this.labelĐC.Size = new System.Drawing.Size(47, 16);
            this.labelĐC.TabIndex = 7;
            this.labelĐC.Text = "Địa chỉ";
            // 
            // labesdt
            // 
            this.labesdt.AutoSize = true;
            this.labesdt.Location = new System.Drawing.Point(258, 296);
            this.labesdt.Name = "labesdt";
            this.labesdt.Size = new System.Drawing.Size(85, 16);
            this.labesdt.TabIndex = 8;
            this.labesdt.Text = "Số điện thoại";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "THÔNG TIN CÁ NHÂN CỦA ỨNG VIÊN";
            // 
            // buttonthoat
            // 
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.Location = new System.Drawing.Point(216, 401);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(106, 35);
            this.buttonthoat.TabIndex = 10;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            // 
            // buttonĐK
            // 
            this.buttonĐK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonĐK.Location = new System.Drawing.Point(495, 401);
            this.buttonĐK.Name = "buttonĐK";
            this.buttonĐK.Size = new System.Drawing.Size(94, 35);
            this.buttonĐK.TabIndex = 11;
            this.buttonĐK.Text = "Đăng ký";
            this.buttonĐK.UseVisualStyleBackColor = true;
            // 
            // DienPhieuDangKyUngVien
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 506);
            this.Controls.Add(this.buttonĐK);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labesdt);
            this.Controls.Add(this.labelĐC);
            this.Controls.Add(this.labelnamsinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelhovaten);
            this.Controls.Add(this.textsdt);
            this.Controls.Add(this.textĐC);
            this.Controls.Add(this.textBoxhovaten);
            this.Name = "DienPhieuDangKyUngVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textHovaten;
        private System.Windows.Forms.Label label1hovaten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelngaysinh;
        private System.Windows.Forms.Label labelsodienthoai;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.TextBox textBoxsodienthoai;
        private System.Windows.Forms.TextBox textdiachi;
        private System.Windows.Forms.Button buttondangky;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.TextBox textBoxhovaten;
        private System.Windows.Forms.TextBox textĐC;
        private System.Windows.Forms.TextBox textsdt;
        private System.Windows.Forms.Label labelhovaten;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelnamsinh;
        private System.Windows.Forms.Label labelĐC;
        private System.Windows.Forms.Label labesdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonĐK;
    }
}