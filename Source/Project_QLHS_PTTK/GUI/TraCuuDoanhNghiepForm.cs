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

    }
}
