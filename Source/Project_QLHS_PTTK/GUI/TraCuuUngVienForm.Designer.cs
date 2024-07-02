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
            this.uvRefresh = new System.Windows.Forms.PictureBox();
            this.btnSearchUV = new System.Windows.Forms.Button();
            this.cbbSearchFilterUV = new System.Windows.Forms.ComboBox();
            this.gvDSUV = new System.Windows.Forms.DataGridView();
            this.txtSearchUV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUV)).BeginInit();
            this.SuspendLayout();
            // 
            // uvRefresh
            // 
            this.uvRefresh.Image = global::GUI.Properties.Resources.refresh;
            this.uvRefresh.Location = new System.Drawing.Point(51, 32);
            this.uvRefresh.Name = "uvRefresh";
            this.uvRefresh.Size = new System.Drawing.Size(49, 34);
            this.uvRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uvRefresh.TabIndex = 13;
            this.uvRefresh.TabStop = false;
            this.uvRefresh.Click += new System.EventHandler(this.uvRefresh_Click);
            // 
            // btnSearchUV
            // 
            this.btnSearchUV.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchUV.FlatAppearance.BorderSize = 0;
            this.btnSearchUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchUV.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearchUV.Location = new System.Drawing.Point(461, 33);
            this.btnSearchUV.Name = "btnSearchUV";
            this.btnSearchUV.Size = new System.Drawing.Size(112, 35);
            this.btnSearchUV.TabIndex = 12;
            this.btnSearchUV.Text = "Tìm ";
            this.btnSearchUV.UseVisualStyleBackColor = false;
            this.btnSearchUV.Click += new System.EventHandler(this.btnSearchUV_Click);
            // 
            // cbbSearchFilterUV
            // 
            this.cbbSearchFilterUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbbSearchFilterUV.FormattingEnabled = true;
            this.cbbSearchFilterUV.Items.AddRange(new object[] {
            "Mã Ứng Viên",
            "Họ Tên Ứng Viên",
            "Địa chỉ"});
            this.cbbSearchFilterUV.Location = new System.Drawing.Point(639, 34);
            this.cbbSearchFilterUV.Name = "cbbSearchFilterUV";
            this.cbbSearchFilterUV.Size = new System.Drawing.Size(241, 34);
            this.cbbSearchFilterUV.TabIndex = 11;
            // 
            // gvDSUV
            // 
            this.gvDSUV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDSUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSUV.Location = new System.Drawing.Point(51, 92);
            this.gvDSUV.Name = "gvDSUV";
            this.gvDSUV.RowHeadersWidth = 51;
            this.gvDSUV.RowTemplate.Height = 24;
            this.gvDSUV.Size = new System.Drawing.Size(829, 354);
            this.gvDSUV.TabIndex = 10;
            // 
            // txtSearchUV
            // 
            this.txtSearchUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSearchUV.Location = new System.Drawing.Point(106, 34);
            this.txtSearchUV.Name = "txtSearchUV";
            this.txtSearchUV.Size = new System.Drawing.Size(332, 32);
            this.txtSearchUV.TabIndex = 9;
            // 
            // TraCuuUngVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 478);
            this.Controls.Add(this.uvRefresh);
            this.Controls.Add(this.btnSearchUV);
            this.Controls.Add(this.cbbSearchFilterUV);
            this.Controls.Add(this.gvDSUV);
            this.Controls.Add(this.txtSearchUV);
            this.Name = "TraCuuUngVienForm";
            this.Text = "TraCuuUngVien";
            this.Load += new System.EventHandler(this.TraCuuUngVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uvRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uvRefresh;
        private System.Windows.Forms.Button btnSearchUV;
        private System.Windows.Forms.ComboBox cbbSearchFilterUV;
        private System.Windows.Forms.DataGridView gvDSUV;
        private System.Windows.Forms.TextBox txtSearchUV;
    }
}