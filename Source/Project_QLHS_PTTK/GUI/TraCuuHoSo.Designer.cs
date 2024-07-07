using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    partial class TraCuuHoSoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ThongTinHoSo_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MaHoSo_label = new System.Windows.Forms.Label();
            this.Mahoso_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_TraCuu = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ThongTinHoSo_label);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Location = new System.Drawing.Point(-3, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 401);
            this.panel3.TabIndex = 2;
            // 
            // ThongTinHoSo_label
            // 
            this.ThongTinHoSo_label.AutoSize = true;
            this.ThongTinHoSo_label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTinHoSo_label.Location = new System.Drawing.Point(15, 4);
            this.ThongTinHoSo_label.Name = "ThongTinHoSo_label";
            this.ThongTinHoSo_label.Size = new System.Drawing.Size(146, 25);
            this.ThongTinHoSo_label.TabIndex = 1;
            this.ThongTinHoSo_label.Text = "Thông tin hồ sơ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Location = new System.Drawing.Point(33, 30);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(843, 344);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // MaHoSo_label
            // 
            this.MaHoSo_label.AutoSize = true;
            this.MaHoSo_label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHoSo_label.Location = new System.Drawing.Point(15, 24);
            this.MaHoSo_label.Name = "MaHoSo_label";
            this.MaHoSo_label.Size = new System.Drawing.Size(90, 25);
            this.MaHoSo_label.TabIndex = 0;
            this.MaHoSo_label.Text = "Mã hồ sơ";
            // 
            // Mahoso_textBox
            // 
            this.Mahoso_textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Mahoso_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mahoso_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mahoso_textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Mahoso_textBox.Location = new System.Drawing.Point(130, 22);
            this.Mahoso_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mahoso_textBox.Name = "Mahoso_textBox";
            this.Mahoso_textBox.Size = new System.Drawing.Size(190, 31);
            this.Mahoso_textBox.TabIndex = 1;
            this.Mahoso_textBox.Text = "Nhập mã hồ sơ";
            this.Mahoso_textBox.Enter += new System.EventHandler(this.Mahoso_textBox_Enter);
            this.Mahoso_textBox.Leave += new System.EventHandler(this.Mahoso_textBox_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Button_TraCuu);
            this.panel2.Controls.Add(this.Mahoso_textBox);
            this.panel2.Controls.Add(this.MaHoSo_label);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 75);
            this.panel2.TabIndex = 1;
            // 
            // Button_TraCuu
            // 
            this.Button_TraCuu.BackColor = System.Drawing.Color.LightBlue;
            this.Button_TraCuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TraCuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_TraCuu.Location = new System.Drawing.Point(337, 21);
            this.Button_TraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_TraCuu.Name = "Button_TraCuu";
            this.Button_TraCuu.Size = new System.Drawing.Size(100, 32);
            this.Button_TraCuu.TabIndex = 4;
            this.Button_TraCuu.Text = "Tra Cứu";
            this.Button_TraCuu.UseVisualStyleBackColor = false;
            this.Button_TraCuu.Click += new System.EventHandler(this.TraCuu_button);
            // 
            // TraCuuHoSoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuHoSoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuHoSo";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private Label ThongTinHoSo_label;
        private DataGridView dataGridView;
        private Label MaHoSo_label;
        private TextBox Mahoso_textBox;
        private Panel panel2;
        private Button Button_TraCuu;
    }
}
