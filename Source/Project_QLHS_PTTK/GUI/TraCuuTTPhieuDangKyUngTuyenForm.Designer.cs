namespace GUI
{
    partial class TraCuuTTPhieuDangKyUngTuyenForm
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
            this.TraCuuPUT = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uvRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuPUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // TraCuuPUT
            // 
            this.TraCuuPUT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TraCuuPUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TraCuuPUT.Location = new System.Drawing.Point(31, 102);
            this.TraCuuPUT.Name = "TraCuuPUT";
            this.TraCuuPUT.RowHeadersWidth = 51;
            this.TraCuuPUT.RowTemplate.Height = 24;
            this.TraCuuPUT.Size = new System.Drawing.Size(822, 342);
            this.TraCuuPUT.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã phiếu ứng tuyển",
            "Vị trí ứng tuyển",
            "Tình trạng phiếu",
            "Mã ứng viên"});
            this.comboBox1.Location = new System.Drawing.Point(78, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 12;
            // 
            // uvRefresh
            // 
            this.uvRefresh.Image = global::GUI.Properties.Resources.refresh;
            this.uvRefresh.Location = new System.Drawing.Point(792, 48);
            this.uvRefresh.Name = "uvRefresh";
            this.uvRefresh.Size = new System.Drawing.Size(49, 34);
            this.uvRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uvRefresh.TabIndex = 16;
            this.uvRefresh.TabStop = false;
            this.uvRefresh.Click += new System.EventHandler(this.uvRefresh_Click);
            // 
            // TraCuuTTPhieuDangKyUngTuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.uvRefresh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TraCuuPUT);
            this.Name = "TraCuuTTPhieuDangKyUngTuyenForm";
            this.Text = "TraCuuTTPhieuDangKyUngTuyen";
            this.Load += new System.EventHandler(this.TraCuuTTPhieuDangKyUngTuyenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuPUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TraCuuPUT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox uvRefresh;
    }
}