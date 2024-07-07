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
        private OracleConnection connect { get; set; }
        public DienPhieuDangKyUngVien(OracleConnection conn)
        {
            InitializeComponent();
            connect = conn;

        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDangKy_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (!UngVien.KiemTraTaiKhoanTonTai(connect, textEmail.Text.Trim())) {

                    // Lấy thông tin từ các ô nhập liệu
                    string hovaten = textBoxhovaten.Text.Trim();
                    string email = textEmail.Text.Trim();
                    string diachi = textĐC.Text.Trim();
                    string sodienthoai = textsdt.Text.Trim();

                    // Tạo mật khẩu ngẫu nhiên
                    string password = BLL.UngVien.GenerateRandomPassword();
                    UngVien.AddCandidate(connect, hovaten, email, diachi, sodienthoai, password);
                }
                else
                {
                    MessageBox.Show("Tài Khoản đã tồn tại");
                }
            }
        }

        private bool ValidateForm()
        {
            // Kiểm tra các ô không được để trống
            if (textBoxhovaten?.Text?.Trim() == "" ||
                textĐC?.Text?.Trim() == "" ||
                textsdt?.Text?.Trim() == "")
            {
                MessageBox.Show("Không được để trống bất kỳ ô nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textEmail.Text, @"^[\w-\.]+@gmail\.com$"))
            {
                MessageBox.Show("Email phải có đuôi @gmail.com", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Kiểm tra họ và tên phải viết hoa chữ cái đầu
            if (!Regex.IsMatch(textBoxhovaten.Text, @"^[A-Z][a-z]*"))
            {
                MessageBox.Show("Họ và tên phải viết hoa chữ cái đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            string phonePattern = @"^[0-9]{10}$"; // Giả sử số điện thoại là 10 chữ số
            if (!Regex.IsMatch(textBoxsodienthoai.Text, phonePattern))
            {
                return false;
            }

            return true;
        }
    }
}

