using Oracle.ManagedDataAccess.Client;
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
    public partial class TraCuuTTPhieuDangKyUngTuyenForm : Form
    {
        private OracleConnection connect { get; set; }

        public TraCuuTTPhieuDangKyUngTuyenForm(OracleConnection conn)
        {
            InitializeComponent();
            initCombobox();
            connect = conn;
        }

        private void initCombobox()
        {
            CBBFilter.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuTTPhieuDangKyUngTuyenForm_Load(object sender, EventArgs e)
        {
            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
            CBBFilter.SelectedItem == null ? "" : CBBFilter.SelectedItem.ToString(), textBoxSearch.Text);
        }

        private void uvRefresh_Click(object sender, EventArgs e)
        {
            CBBFilter.SelectedItem = null;
            textBoxSearch.Text = "";

            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
            CBBFilter.SelectedItem == null ? "" : CBBFilter.SelectedItem.ToString(), textBoxSearch.Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
           CBBFilter.SelectedItem == null ? "" : CBBFilter.SelectedItem.ToString(), textBoxSearch.Text);
        }
    }
}
