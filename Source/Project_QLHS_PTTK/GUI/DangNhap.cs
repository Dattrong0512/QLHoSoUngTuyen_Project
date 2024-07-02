using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Oracle.ManagedDataAccess.Client;
using DAL;
using DTO;
namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            

        }
        private void DangNhap_Activated(object sender, EventArgs e)
        {
            
        }
        private void ButtonDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxUSN.Text))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Thoát khỏi hàm nếu TextBoxUSN trống
            }
            // Kiểm tra TextBoxPSW trống
            if (string.IsNullOrWhiteSpace(TextBoxPSW.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Thoát khỏi hàm nếu TextBoxPSW trống
            }
            
            if (TextBoxUSN.Text.Contains("CTY"))
            {
                DTO.TaiKhoanDN TKDN = new TaiKhoanDN(TextBoxUSN.Text, TextBoxPSW.Text,"DN"); // Gán "VaiTroCTY" hoặc vai trò tương ứng
                var userConnection = new Connection(TextBoxUSN.Text, TextBoxPSW.Text);
                TKDN.TKconn = userConnection.conn;
                DAL.DataBaseAccess.CheckLogic(TKDN);
                string result = DAL.DataBaseAccess.CheckLogic(TKDN);
                MessageBox.Show(result, "Kết quả đăng nhập");
                
            }
            else if (TextBoxUSN.Text.Contains("NV"))
            {
                DTO.TaiKhoanNV TKNV = new TaiKhoanNV(TextBoxUSN.Text, TextBoxPSW.Text, "NV"); // Gán "VaiTroNV" hoặc vai trò tương ứng             
                DAL.DataBaseAccess.CheckLogic(TKNV);
                string result = DAL.DataBaseAccess.CheckLogic(TKNV);
                MessageBox.Show(result, "Kết quả đăng nhập");
                if(result=="Thành công")
                {
                    var userConnection = new Connection(TextBoxUSN.Text, TextBoxPSW.Text);
                    TKNV.TKconn = userConnection.conn;
                    this.Hide();
                    NhanVienForm FormNV = new NhanVienForm(TKNV);
                    FormNV.Show();
                }    
                
            }
            else
            {
                DTO.TaiKhoanUV TKUV = new TaiKhoanUV(TextBoxUSN.Text, TextBoxPSW.Text, "UV"); // Gán "VaiTroUV" hoặc vai trò tương ứng
                var userConnection = new Connection(TextBoxUSN.Text, TextBoxPSW.Text);
                TKUV.TKconn = userConnection.conn;
                DAL.DataBaseAccess.CheckLogic(TKUV);
                string result = DAL.DataBaseAccess.CheckLogic(TKUV);
                MessageBox.Show(result, "Kết quả đăng nhập");
            } 
                           
            
        }
        private void groupBoxDN_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxPSW_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

