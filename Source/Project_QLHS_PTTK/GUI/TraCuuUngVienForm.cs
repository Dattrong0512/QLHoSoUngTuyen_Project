using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using BLL;
namespace GUI
{
    public partial class TraCuuUngVienForm : Form
    {
        private OracleConnection connect { get; set; }
        public TraCuuUngVienForm(OracleConnection conn)
        {
            InitializeComponent();
            SetPlaceholder(txtSearchUV, "Nhập thông tin tìm kiếm...");
            connect = conn;
            cbbSearchFilterUV.DropDownStyle = ComboBoxStyle.DropDownList;
            gvDSUV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSearchFilterUV.SelectedIndex = 0;
            lblNoData.Visible = false;
        }

        

    

        private void txtSearchUV_TextChanged(object sender, EventArgs e)
        {
            lblNoData.Visible = false;
            DataResult result = BLL.UngVien.TraCuuUngVien(connect, cbbSearchFilterUV.Text, txtSearchUV.Text);
            if(!result.HasData)
            {
                lblNoData.Visible = true;
            }
            gvDSUV.DataSource = result.DataTable;
        }

        private void cbbSearchFilterUV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNoData.Visible = false;
            DataResult result = BLL.UngVien.TraCuuUngVien(connect, cbbSearchFilterUV.Text, txtSearchUV.Text);
            if (!result.HasData)
            {
                lblNoData.Visible = true;
            }
            gvDSUV.DataSource = result.DataTable;
        }

        private void TraCuuUngVienForm_HienThi(object sender, EventArgs e)
        {
            gvDSUV.DataSource = BLL.UngVien.HienThiUngVien(connect);
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => AddPlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
