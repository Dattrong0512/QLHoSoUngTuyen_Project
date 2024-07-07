using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Oracle.ManagedDataAccess.Client;

namespace GUI
{
    public partial class DienPhieuDangKyUngVien : Form
    {
        public DienPhieuDangKyUngVien()
        {
            InitializeComponent();
            buttonĐK.Click += new EventHandler(ButtonDangKy_Click);
            buttonthoat.Click += new EventHandler(ButtonThoat_Click);
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDangKy_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Lấy thông tin từ các ô nhập liệu
                string hovaten = textBoxhovaten.Text.Trim();
                DateTime ngaysinh = dateTimeNS.Value;
                string diachi = textĐC.Text.Trim();
                string sodienthoai = textsdt.Text.Trim();

                // Tạo mật khẩu ngẫu nhiên
                string password = BLL.UngVien.GenerateRandomPassword();

                // Thêm ứng viên vào database
                OracleConnection conn = new OracleConnection("connection_string"); // Thay bằng connection string của bạn
                try
                {
                    conn.Open();
                    BLL.UngVien.AddCandidate(conn, hovaten, ngaysinh, diachi, sodienthoai, password);
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private bool ValidateForm()
        {
            // Kiểm tra các ô không được để trống
            if (string.IsNullOrWhiteSpace(textBoxhovaten.Text) ||
                string.IsNullOrWhiteSpace(textĐC.Text) ||
                string.IsNullOrWhiteSpace(textsdt.Text))
            {
                MessageBox.Show("Không được để trống bất kỳ ô nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra họ và tên phải viết hoa chữ cái đầu
            if (!Regex.IsMatch(textBoxhovaten.Text, @"^[A-Z][a-z]*"))
            {
                MessageBox.Show("Họ và tên phải viết hoa chữ cái đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số điện thoại
            string sdt = textsdt.Text.Trim(); // Loại bỏ khoảng trắng ở đầu và cuối chuỗi

            // Kiểm tra độ dài phải là 10 ký tự và toàn bộ là số
            if (sdt.Length != 10 || !Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

