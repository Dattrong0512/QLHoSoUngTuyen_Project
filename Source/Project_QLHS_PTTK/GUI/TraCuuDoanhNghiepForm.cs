using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace GUI
{
    public partial class TraCuuDoanhNghiepForm : Form
    {
        private OracleConnection connect { get; set; }
        public TraCuuDoanhNghiepForm(OracleConnection conn)
        {
            InitializeComponent();
            connect = conn;
            cbbSearchFilterDN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSearchFilterDN.SelectedIndex = 0;
            buttonRefresh.ImageAlign = ContentAlignment.MiddleLeft; // Căn giữa hình ảnh
        }

        private void TraCuuDoanhNghiepForm_Load(object sender, EventArgs e)
        {
            gvDSDN.DataSource=BLL.DoanhNghiep.HienThiDoanhNghiep(connect);
        }

        private void cbbSearchFilterDN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvDSDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchDN_Click(object sender, EventArgs e)
        {
            gvDSDN.DataSource = BLL.DoanhNghiep.TraCuuDoanhNghiep(connect, cbbSearchFilterDN.Text, txtSearchDN.Text);
        }

        private void buttonRefesh_Click(object sender, EventArgs e)
        {
            gvDSDN.DataSource = BLL.DoanhNghiep.HienThiDoanhNghiep(connect);
        }

    }
}
