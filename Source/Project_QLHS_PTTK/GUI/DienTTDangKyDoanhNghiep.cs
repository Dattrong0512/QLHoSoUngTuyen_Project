using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Oracle.ManagedDataAccess.Client;

namespace GUI
{
    public partial class DienTTDangKyDoanhNghiep : Form
    {
        private OracleConnection connect { get; set; }
        public DienTTDangKyDoanhNghiep(OracleConnection conn)
        {
            InitializeComponent();
            InitializeHeader();
            InitializeCustomComponents();
            connect = conn;
        }

        private void InitializeHeader()
        {
            // Panel header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.LightGray
            };
            this.Controls.Add(headerPanel);

            // Label header title
            Label headerLabel = new Label
            {
                Text = "Đăng ký thành viên DOANH NGHIỆP",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            headerPanel.Controls.Add(headerLabel);

            // Event to layout the headerLabel after the panel is resized
            headerPanel.Layout += (sender, e) =>
            {
                headerLabel.Location = new Point((headerPanel.Width - headerLabel.Width) / 2, (headerPanel.Height - headerLabel.Height) / 2);
            };
        }

        private void InitializeCustomComponents()
        {
            // Initialize TextBoxes with placeholder
            SetPlaceholder(tbTenCongTy, "Tên công ty");
            SetPlaceholder(tbMaSoThue, "Mã số thuế");
            SetPlaceholder(tbNguoiDaiDien, "Người đại diện");
            SetPlaceholder(tbDiaChi, "Địa chỉ");
            SetPlaceholder(tbEmail, "Email");

            // Arrange TextBoxes and Buttons
            ArrangeControls();
            this.Resize += new EventHandler(Form_Resize);
        }

        private void ArrangeControls()
        {
            int textBoxWidth = this.ClientSize.Width - 40;
            int startY = 60;
            int spacing = 40;

            // Arrange TextBoxes
            tbTenCongTy.Width = textBoxWidth;
            tbTenCongTy.Location = new Point((this.ClientSize.Width - textBoxWidth) / 2, startY);
            tbTenCongTy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            tbMaSoThue.Width = textBoxWidth;
            tbMaSoThue.Location = new Point((this.ClientSize.Width - textBoxWidth) / 2, startY + spacing);
            tbMaSoThue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            tbNguoiDaiDien.Width = textBoxWidth;
            tbNguoiDaiDien.Location = new Point((this.ClientSize.Width - textBoxWidth) / 2, startY + 2 * spacing);
            tbNguoiDaiDien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            tbDiaChi.Width = textBoxWidth;
            tbDiaChi.Location = new Point((this.ClientSize.Width - textBoxWidth) / 2, startY + 3 * spacing);
            tbDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            tbEmail.Width = textBoxWidth;
            tbEmail.Location = new Point((this.ClientSize.Width - textBoxWidth) / 2, startY + 4 * spacing);
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Arrange Buttons
            int buttonWidth = 75;
            int buttonHeight = 30;
            int buttonSpacing = 20;
            int buttonsY = startY + 5 * spacing + 20;

            btnThoat.Width = buttonWidth;
            btnThoat.Height = buttonHeight;
            btnThoat.Location = new Point((this.ClientSize.Width - 2 * buttonWidth - buttonSpacing) / 2, buttonsY);
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThoat.Click += new EventHandler(ButtonThoat_Click);

            btnDangKy.Width = buttonWidth;
            btnDangKy.Height = buttonHeight;
            btnDangKy.Location = new Point(btnThoat.Location.X + buttonWidth + buttonSpacing, buttonsY);
            btnDangKy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDangKy.Click += new EventHandler(ButtonDangKy_Click);
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

        private void Form_Resize(object sender, EventArgs e)
        {
            ArrangeControls();
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDangKy_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool exists = DoanhNghiep.KiemTraDoanhNghiepTonTai(connect, tbMaSoThue.Text.Trim());

                if (exists)
                {
                    MessageBox.Show("Thông tin doanh nghiệp đã tồn tại.");
                }
                else
                {
                    // Tạo mật khẩu ngẫu nhiên
                    string matKhau = BLL.DoanhNghiep.GenerateRandomPassword(20);

                    bool success = DoanhNghiep.ThemDoanhNghiep(connect, tbTenCongTy.Text.Trim(),
                                                               tbMaSoThue.Text.Trim(),
                                                               tbNguoiDaiDien.Text.Trim(),
                                                               tbDiaChi.Text.Trim(),
                                                               tbEmail.Text.Trim(),
                                                               matKhau
                                                             );
                    if (success)
                    {
                        MessageBox.Show($"Đăng ký thành công.\nMật khẩu tạm thời: {matKhau}");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin nhập không hợp lệ.");
            }
        }

        private bool ValidateInputs()
        {
            // Check if any TextBox is empty or contains placeholder text
            if (IsPlaceholderOrEmpty(tbTenCongTy, "Tên công ty") ||
                    IsPlaceholderOrEmpty(tbMaSoThue, "Mã số thuế") ||
                    IsPlaceholderOrEmpty(tbNguoiDaiDien, "Người đại diện") ||
                    IsPlaceholderOrEmpty(tbDiaChi, "Địa chỉ") ||
                    IsPlaceholderOrEmpty(tbEmail, "Email"))
            {
                MessageBox.Show("Thông tin nhập không hợp lệ.");
                return false;
            }

            bool exists = DoanhNghiep.KiemTraDoanhNghiepTonTai(connect, tbMaSoThue.Text.Trim());
            if (exists)
            {
                MessageBox.Show("Thông tin doanh nghiệp đã tồn tại.");
                return false;
            }

            return true;
        }

        private bool IsPlaceholderOrEmpty(TextBox textBox, string placeholder)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholder;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
