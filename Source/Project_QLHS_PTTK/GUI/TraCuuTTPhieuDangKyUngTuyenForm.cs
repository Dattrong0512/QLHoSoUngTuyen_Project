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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
            comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString(), textBox1.Text);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuTTPhieuDangKyUngTuyenForm_Load(object sender, EventArgs e)
        {
            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
            comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString(), textBox1.Text);
        }

        private void uvRefresh_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            textBox1.Text = "";

            TraCuuPUT.DataSource = BLL.PDKUT.traCuuPUT(connect,
            comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString(), textBox1.Text);
        }
    }
}
