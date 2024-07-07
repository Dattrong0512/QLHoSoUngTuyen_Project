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

            MaHS_textBox.Text = MaHoSo; // Thiết lập giá trị cho MAHS_textBox
            LoadData();
        }

        private void LoadData()
        {
            var data = BLL.ChiTietHoSoBLL.TraCuuChiTietHoSo(connect, MaHoSo);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy chi tiết hồ sơ.");
            }
            else
            {
                dataGridView1.DataSource = data;
                SetupDataGridView();
            }
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

        private void MaHS_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}