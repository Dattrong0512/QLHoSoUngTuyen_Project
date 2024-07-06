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

namespace GUI
{
    public partial class DienPhieuDangKyUngVien : Form
    {
        public DienPhieuDangKyUngVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttondangky.Click += Buttondangky_Click;
            buttonthoat.Click += Buttonthoat_Click;
        }

        // Hàm kiểm tra tính hợp lệ của thông tin người dùng
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(textHovaten.Text) ||
                string.IsNullOrWhiteSpace(textBoxsodienthoai.Text) ||
                string.IsNullOrWhiteSpace(textdiachi.Text))
            {
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

        // Xử lý sự kiện nhấn nút Đăng ký
        private void Buttondangky_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thêm logic lưu thông tin người dùng ở đây (ví dụ: lưu vào cơ sở dữ liệu hoặc tệp)
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nhấn nút Thoát
        private void Buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
