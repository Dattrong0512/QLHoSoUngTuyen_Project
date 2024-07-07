using System.Drawing;
using System.Windows.Forms;
using System;
using Oracle.ManagedDataAccess.Client;

namespace GUI
{
    public partial class TraCuuHoSoForm : Form
    {
        private OracleConnection connect { get; set; }

        public TraCuuHoSoForm(OracleConnection conn)
        {
            InitializeComponent();
            connect = conn;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = BLL.HoSoBLL.TraCuuHoSo(connect);
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView.Columns["MaHoSo"].HeaderText = "Mã Hồ Sơ";
            dataGridView.Columns["NgayNopHoSo"].HeaderText = "Ngày Nộp Hồ Sơ";
            dataGridView.Columns["TinhTrangHS"].HeaderText = "Tình Trạng Hồ Sơ";

            if (!dataGridView.Columns.Contains("ChiTiet"))
            {
                DataGridViewButtonColumn detailColumn = new DataGridViewButtonColumn();
                detailColumn.Name = "ChiTiet";
                detailColumn.HeaderText = "";
                detailColumn.Text = "Chi Tiết";
                detailColumn.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(detailColumn);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["ChiTiet"].Index)
            {
                string maHoSo = dataGridView.Rows[e.RowIndex].Cells["MaHoSo"].Value.ToString();
                ChiTietHoSo chiTietForm = new ChiTietHoSo(connect, maHoSo);
                chiTietForm.Tag = maHoSo;
                chiTietForm.ShowDialog();
            }
        }

        private void TraCuu_button(object sender, EventArgs e)
        {
            string maHoSo = Mahoso_textBox.Text.Trim();

            if (maHoSo == "Nhập mã hồ sơ")
            {
                MessageBox.Show("Vui lòng nhập mã hồ sơ.");
                return;
            }

            if (string.IsNullOrWhiteSpace(maHoSo))
            {
                LoadData();
                return;
            }

            var data = BLL.HoSoBLL.TraCuuHoSo(connect, maHoSo);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hồ sơ.");
                LoadData();
            }
            else
            {
                dataGridView.DataSource = data;
                SetupDataGridView();
            }
        }

        private void TroVe_button(object sender, EventArgs e)
        {
            // Implement this method if needed
        }

        private void Mahoso_textBox_Enter(object sender, EventArgs e)
        {
            if (Mahoso_textBox.Text == "Nhập mã hồ sơ")
            {
                Mahoso_textBox.Text = "";
                Mahoso_textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void Mahoso_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mahoso_textBox.Text))
            {
                Mahoso_textBox.Text = "Nhập mã hồ sơ";
                Mahoso_textBox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
