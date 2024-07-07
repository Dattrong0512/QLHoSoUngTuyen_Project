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
            this.CBBFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            // CBBFilter
            // 
            this.CBBFilter.BackColor = System.Drawing.Color.SkyBlue;
            this.CBBFilter.FormattingEnabled = true;
            this.CBBFilter.Items.AddRange(new object[] {
            "Mã phiếu ứng tuyển",
            "Vị trí ứng tuyển",
            "Tình trạng phiếu",
            "Mã ứng viên"});
            this.CBBFilter.Location = new System.Drawing.Point(78, 48);
            this.CBBFilter.Name = "CBBFilter";
            this.CBBFilter.Size = new System.Drawing.Size(200, 24);
            this.CBBFilter.TabIndex = 15;
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
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.Location = new System.Drawing.Point(684, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(89, 40);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Tìm Kiếm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxSearch.Location = new System.Drawing.Point(284, 49);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(375, 22);
            this.textBoxSearch.TabIndex = 12;
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
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.uvRefresh);
            this.Controls.Add(this.CBBFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
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
        private System.Windows.Forms.ComboBox CBBFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox uvRefresh;
    }
}