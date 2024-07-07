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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class TraCuuTTPhieuDangTuyenForm : Form
    {
        private OracleConnection connect { get; set; }

        public TraCuuTTPhieuDangTuyenForm( OracleConnection conn)
        {
            InitializeComponent();
            connect = conn;
            initCombobox();
        }

        private void initCombobox()
        {
            filterCBB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void TraCuuTTPhieuDangTuyenForm_Load(object sender, EventArgs e)
        {
            TraCuuPDT.DataSource = BLL.PDT.traCuuPDT(connect,
                filterCBB.SelectedItem == null ? "" : filterCBB.SelectedItem.ToString(), textBoxSearch.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void uvRefresh_Click(object sender, EventArgs e)
        {
            filterCBB.SelectedItem = null;
            textBoxSearch.Text = "";

            TraCuuPDT.DataSource = BLL.PDT.traCuuPDT(connect,
                filterCBB.SelectedItem == null ? "" : filterCBB.SelectedItem.ToString(), textBoxSearch.Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TraCuuPDT.DataSource = BLL.PDT.traCuuPDT(connect,
                filterCBB.SelectedItem == null ? "" : filterCBB.SelectedItem.ToString(), textBoxSearch.Text);
        }
    }
}
