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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            this.filterCBB.BackColor = System.Drawing.Color.SkyBlue;
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
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.Location = new System.Drawing.Point(686, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 37);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Tìm Kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxSearch.Location = new System.Drawing.Point(307, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(364, 22);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.uvRefresh);
            this.Controls.Add(this.filterCBB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView TraCuuPDT;
    }
}