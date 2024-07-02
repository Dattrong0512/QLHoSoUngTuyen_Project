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
        public NhanVienForm()
        {
            InitializeComponent();
         
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm tt";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
 
}
