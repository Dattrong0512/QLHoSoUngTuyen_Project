using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanVienForm : Form
    {
        private TaiKhoanNV taikhoanNV { get; set; }
        public NhanVienForm(TaiKhoanNV taikhoan)
        {
            InitializeComponent();
            taikhoanNV = taikhoan;
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm tt";
            OpenChildForm(new TraCuuUngVienForm());
            LabelTitle.Text = "Tra cứu ứng viên";
            LabelTitle.Show();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill; 
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonTraCuuDN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraCuuDoanhNghiepForm(taikhoanNV.TKconn));
            LabelTitle.Text = "Tra cứu doanh nghiệp";
            LabelTitle.Show();
        }

        private void ButtonTraCuuUV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraCuuUngVienForm());
            LabelTitle.Text = "Tra cứu ứng viên";
            LabelTitle.Show();
        }

        private void ImageNV_Click(object sender, EventArgs e)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap formDN= new DangNhap();
            formDN.Show();
        }
    }
 
}
