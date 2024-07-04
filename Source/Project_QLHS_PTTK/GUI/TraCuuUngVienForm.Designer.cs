namespace GUI
{
    partial class TraCuuUngVienForm
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
            this.cbbSearchFilterUV = new System.Windows.Forms.ComboBox();
            this.gvDSUV = new System.Windows.Forms.DataGridView();
            this.txtSearchUV = new System.Windows.Forms.TextBox();
            this.lblNoData = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSearchFilterUV
            // 
            this.cbbSearchFilterUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbbSearchFilterUV.FormattingEnabled = true;
            this.cbbSearchFilterUV.Items.AddRange(new object[] {
            "Mã Ứng Viên",
            "Họ Tên Ứng Viên",
            "Địa chỉ"});
            this.cbbSearchFilterUV.Location = new System.Drawing.Point(586, 36);
            this.cbbSearchFilterUV.Name = "cbbSearchFilterUV";
            this.cbbSearchFilterUV.Size = new System.Drawing.Size(241, 34);
            this.cbbSearchFilterUV.TabIndex = 11;
            this.cbbSearchFilterUV.SelectedIndexChanged += new System.EventHandler(this.cbbSearchFilterUV_SelectedIndexChanged);
            // 
            // gvDSUV
            // 
            this.gvDSUV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDSUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSUV.Location = new System.Drawing.Point(63, 89);
            this.gvDSUV.Name = "gvDSUV";
            this.gvDSUV.RowHeadersWidth = 51;
            this.gvDSUV.RowTemplate.Height = 24;
            this.gvDSUV.Size = new System.Drawing.Size(807, 354);
            this.gvDSUV.TabIndex = 10;
            // 
            // txtSearchUV
            // 
            this.txtSearchUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSearchUV.Location = new System.Drawing.Point(82, 36);
            this.txtSearchUV.Name = "txtSearchUV";
            this.txtSearchUV.Size = new System.Drawing.Size(332, 32);
            this.txtSearchUV.TabIndex = 9;
            this.txtSearchUV.TextChanged += new System.EventHandler(this.txtSearchUV_TextChanged);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNoData.Location = new System.Drawing.Point(285, 245);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(383, 36);
            this.lblNoData.TabIndex = 14;
            this.lblNoData.Text = "Không có dữ liệu tương ứng";
            this.lblNoData.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = true;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Purple;
            this.txtSearch.Location = new System.Drawing.Point(460, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(96, 25);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Tìm theo";
            // 
            // TraCuuUngVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(928, 478);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cbbSearchFilterUV);
            this.Controls.Add(this.gvDSUV);
            this.Controls.Add(this.txtSearchUV);
            this.Name = "TraCuuUngVienForm";
            this.Text = "TraCuuUngVien";
            this.Load += new System.EventHandler(this.TraCuuUngVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbSearchFilterUV;
        private System.Windows.Forms.DataGridView gvDSUV;
        private System.Windows.Forms.TextBox txtSearchUV;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Label txtSearch;
    }
}