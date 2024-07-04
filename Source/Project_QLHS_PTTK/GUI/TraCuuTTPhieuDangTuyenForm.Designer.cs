namespace GUI
{
    partial class TraCuuTTPhieuDangTuyenForm
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
            this.uvRefresh = new System.Windows.Forms.PictureBox();
            this.filterCBB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TraCuuPDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuPDT)).BeginInit();
            this.SuspendLayout();
            // 
            // uvRefresh
            // 
            this.uvRefresh.Image = global::GUI.Properties.Resources.refresh;
            this.uvRefresh.Location = new System.Drawing.Point(791, 39);
            this.uvRefresh.Name = "uvRefresh";
            this.uvRefresh.Size = new System.Drawing.Size(49, 34);
            this.uvRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uvRefresh.TabIndex = 22;
            this.uvRefresh.TabStop = false;
            this.uvRefresh.Click += new System.EventHandler(this.uvRefresh_Click);
            // 
            // filterCBB
            // 
            this.filterCBB.FormattingEnabled = true;
            this.filterCBB.Items.AddRange(new object[] {
            "Mã phiếu đăng tuyển",
            "Mã công ty",
            "Tên công ty",
            "Vị trí ứng tuyển",
            "Số lượng tuyển dụng",
            "Khoảng thời gian đăng tuyển",
            "Tiêu chí",
            "Tổng tiền đã thanh toán"});
            this.filterCBB.Location = new System.Drawing.Point(77, 43);
            this.filterCBB.Name = "filterCBB";
            this.filterCBB.Size = new System.Drawing.Size(224, 24);
            this.filterCBB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Tìm Kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 22);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TraCuuPDT
            // 
            this.TraCuuPDT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TraCuuPDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TraCuuPDT.Location = new System.Drawing.Point(38, 96);
            this.TraCuuPDT.Name = "TraCuuPDT";
            this.TraCuuPDT.RowHeadersWidth = 51;
            this.TraCuuPDT.RowTemplate.Height = 24;
            this.TraCuuPDT.Size = new System.Drawing.Size(822, 342);
            this.TraCuuPDT.TabIndex = 17;
            // 
            // TraCuuTTPhieuDangTuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.uvRefresh);
            this.Controls.Add(this.filterCBB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TraCuuPDT);
            this.Name = "TraCuuTTPhieuDangTuyenForm";
            this.Text = "TraCuuTTPhieuDangTuyen";
            this.Load += new System.EventHandler(this.TraCuuTTPhieuDangTuyenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuPDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox uvRefresh;
        private System.Windows.Forms.ComboBox filterCBB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView TraCuuPDT;
    }
}