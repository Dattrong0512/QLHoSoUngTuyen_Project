using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            // Đảm bảo sự kiện chỉ được đăng ký một lần

        }

        private void InitializeHeader()
        {
            // Panel header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.Transparent
            };
            this.Controls.Add(headerPanel);

            // Add gradient background to headerPanel
            headerPanel.Paint += (sender, e) =>
            {
                LinearGradientBrush brush = new LinearGradientBrush(headerPanel.ClientRectangle, Color.CornflowerBlue, Color.DeepSkyBlue, LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle(brush, headerPanel.ClientRectangle);
            };

            // Label header title
            Label headerLabel = new Label
            {
                Text = "Đăng ký thành viên DOANH NGHIỆP",
                Font = new Font("Arial", 20, FontStyle.Bold),
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
            int textBoxWidth = this.ClientSize.Width - 400;
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
            int buttonWidth = 150;
            int buttonHeight = 70;
            int buttonSpacing = 50;
            int buttonsY = startY + 5 * spacing + 10;

            btnDangKy.Width = buttonWidth;
            btnDangKy.Height = buttonHeight;
            btnDangKy.Location = new Point((this.ClientSize.Width - 2 * buttonWidth - buttonSpacing) / 2, buttonsY);
            btnDangKy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDangKy.Click += new EventHandler(ButtonThoat_Click);
            btnDangKy.Font = new Font(btnDangKy.Font.FontFamily, 15, FontStyle.Regular);


            btnThoat.Width = buttonWidth;
            btnThoat.Height = buttonHeight;
            btnThoat.Location = new Point(btnDangKy.Location.X + buttonWidth + buttonSpacing, buttonsY);
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //btnDangKy.Click += new EventHandler(ButtonDangKy_Click);
            btnThoat.Font = new Font(btnThoat.Font.FontFamily, 15, FontStyle.Regular);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Font = new Font(textBox.Font.FontFamily, 15, FontStyle.Regular);
            textBox.Enter += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => AddPlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.Font = new Font(textBox.Font.FontFamily, 15, FontStyle.Regular);
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                textBox.Font = new Font(textBox.Font.FontFamily, 15, FontStyle.Regular);
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
            this.ButtonDangKy();
        }
        private void ButtonDangKy()
        {
            int check = BLL.DoanhNghiep.ValidateInputs(tbTenCongTy.Text.Trim(), tbMaSoThue.Text.Trim(), tbNguoiDaiDien.Text.Trim(), tbDiaChi.Text.Trim(), tbEmail.Text.Trim(), connect);
            if (check==1)
            {
                    // Tạo mật khẩu ngẫu nhiên
                string matKhau = BLL.DoanhNghiep.GenerateRandomString(20);                    
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
                    tbTenCongTy.Text = string.Empty;
                    tbMaSoThue.Text = string.Empty;
                    tbNguoiDaiDien.Text = string.Empty;
                    tbDiaChi.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    SetPlaceholder(tbTenCongTy, "Tên công ty");
                    SetPlaceholder(tbMaSoThue, "Mã số thuế");
                    SetPlaceholder(tbNguoiDaiDien, "Người đại diện");
                    SetPlaceholder(tbDiaChi, "Địa chỉ");
                    SetPlaceholder(tbEmail, "Email");
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại.");
                    return;
                }
            }    
            else
            {
                switch(check)
                { 
                    case 0:
                    {
                        MessageBox.Show("Nhập thiếu, vui lòng nhập đầy đủ");
                        break;
                    }
                    case 2:
                    {
                        tbMaSoThue.Text = string.Empty;
                        break;
                    }
                    case 3:
                    {
                        tbEmail.Text = string.Empty;
                        break;
                    }
                    case 4:
                    {
                        tbTenCongTy.Text = string.Empty;
                        tbMaSoThue.Text = string.Empty;
                        tbNguoiDaiDien.Text = string.Empty;
                        tbDiaChi.Text = string.Empty;
                        tbEmail.Text = string.Empty;
                        SetPlaceholder(tbTenCongTy, "Tên công ty");
                        SetPlaceholder(tbMaSoThue, "Mã số thuế");
                        SetPlaceholder(tbNguoiDaiDien, "Người đại diện");
                        SetPlaceholder(tbDiaChi, "Địa chỉ");
                        SetPlaceholder(tbEmail, "Email");
                        break;
                    }
                }
            }
        }
    }
}
