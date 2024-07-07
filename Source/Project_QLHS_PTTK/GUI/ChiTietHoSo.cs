using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using DAL;
using System.Data;

namespace GUI
{
    public partial class ChiTietHoSo : Form
    {
        private OracleConnection connect { get; set; }
        private string MaHoSo;

        public ChiTietHoSo(OracleConnection conn, string maHoSo)
        {
            InitializeComponent();
            connect = conn;
            MaHoSo = maHoSo;

            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = BLL.ChiTietHoSoBLL.TraCuuChiTietHoSo(connect, MaHoSo);
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
            dataGridView1.Columns["LoaiHoSo"].HeaderText = "Loại hồ sơ";
            dataGridView1.Columns["TenHoSo"].HeaderText = "Tên hồ sơ";
        }

        private void TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

