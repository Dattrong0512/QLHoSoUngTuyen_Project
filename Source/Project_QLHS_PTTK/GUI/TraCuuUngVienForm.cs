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
    public partial class TraCuuUngVienForm : Form
    {
        private OracleConnection connect { get; set; }
        public TraCuuUngVienForm(OracleConnection conn)
        {
            InitializeComponent();
            connect = conn;
            cbbSearchFilterUV.DropDownStyle = ComboBoxStyle.DropDownList;
            gvDSUV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSearchFilterUV.SelectedIndex = 0;
        }

        private void TraCuuUngVienForm_Load(object sender, EventArgs e)
        {
            gvDSUV.DataSource = BLL.UngVien.HienThiUngVien(connect);
        }

        private void btnSearchUV_Click(object sender, EventArgs e)
        {
            gvDSUV.DataSource = BLL.UngVien.TraCuuUngVien(connect, cbbSearchFilterUV.Text, txtSearchUV.Text);
        }

        private void uvRefresh_Click(object sender, EventArgs e)
        {
            gvDSUV.DataSource = BLL.UngVien.HienThiUngVien(connect);
        }
    }
}
