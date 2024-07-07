namespace GUI
{
    partial class TraCuuDoanhNghiepForm
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
            this.btnSearchDN = new System.Windows.Forms.Button();
            this.cbbSearchFilterDN = new System.Windows.Forms.ComboBox();
            this.gvDSDN = new System.Windows.Forms.DataGridView();
            this.txtSearchDN = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDN
            // 
            this.btnSearchDN.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchDN.FlatAppearance.BorderSize = 0;
            this.btnSearchDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchDN.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearchDN.Location = new System.Drawing.Point(460, 30);
            this.btnSearchDN.Name = "btnSearchDN";
            this.btnSearchDN.Size = new System.Drawing.Size(112, 35);
            this.btnSearchDN.TabIndex = 7;
            this.btnSearchDN.Text = "Tìm ";
            this.btnSearchDN.UseVisualStyleBackColor = false;
            this.btnSearchDN.Click += new System.EventHandler(this.btnSearchDN_Click);
            // 
            // cbbSearchFilterDN
            // 
            this.cbbSearchFilterDN.BackColor = System.Drawing.Color.White;
            this.cbbSearchFilterDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbbSearchFilterDN.FormattingEnabled = true;
            this.cbbSearchFilterDN.Items.AddRange(new object[] {
            "Mã Doanh Nghiệp",
            "Tên Doanh Nghiệp",
            "Mã số thuế",
            "Địa chỉ"});
            this.cbbSearchFilterDN.Location = new System.Drawing.Point(638, 31);
            this.cbbSearchFilterDN.Name = "cbbSearchFilterDN";
            this.cbbSearchFilterDN.Size = new System.Drawing.Size(241, 34);
            this.cbbSearchFilterDN.TabIndex = 6;
            this.cbbSearchFilterDN.SelectedIndexChanged += new System.EventHandler(this.cbbSearchFilterDN_SelectedIndexChanged);
            // 
            // gvDSDN
            // 
            this.gvDSDN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvDSDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSDN.Location = new System.Drawing.Point(48, 87);
            this.gvDSDN.Name = "gvDSDN";
            this.gvDSDN.RowHeadersWidth = 51;
            this.gvDSDN.RowTemplate.Height = 24;
            this.gvDSDN.Size = new System.Drawing.Size(829, 354);
            this.gvDSDN.TabIndex = 5;
            this.gvDSDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSDN_CellContentClick);
            // 
            // txtSearchDN
            // 
            this.txtSearchDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSearchDN.Location = new System.Drawing.Point(105, 31);
            this.txtSearchDN.Name = "txtSearchDN";
            this.txtSearchDN.Size = new System.Drawing.Size(332, 32);
            this.txtSearchDN.TabIndex = 4;
            this.txtSearchDN.TextChanged += new System.EventHandler(this.txtSearchDN_TextChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = global::GUI.Properties.Resources.refresh2;
            this.buttonRefresh.FlatAppearance.BorderSize = 5;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(40, 28);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(58, 39);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefesh_Click);
            // 
            // TraCuuDoanhNghiepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 478);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.btnSearchDN);
            this.Controls.Add(this.cbbSearchFilterDN);
            this.Controls.Add(this.gvDSDN);
            this.Controls.Add(this.txtSearchDN);
            this.Name = "TraCuuDoanhNghiepForm";
            this.Text = "TraCuuDoanhNghiep";
            this.Load += new System.EventHandler(this.TraCuuDoanhNghiepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDN;
        private System.Windows.Forms.ComboBox cbbSearchFilterDN;
        private System.Windows.Forms.DataGridView gvDSDN;
        private System.Windows.Forms.TextBox txtSearchDN;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
