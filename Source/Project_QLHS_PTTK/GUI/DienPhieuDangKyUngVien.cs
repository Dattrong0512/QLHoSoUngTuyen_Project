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
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Kiểm tra số điện thoại phải là 10 chữ số
            if (!Regex.IsMatch(textsdt.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
