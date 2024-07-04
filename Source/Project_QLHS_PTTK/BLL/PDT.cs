using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public static class PDT
    {

        public static DataTable traCuuPDT(OracleConnection connnv, string filter, string context)
        {
            string condition = "";
            List<string> schemas = new List<string> { "pdt", "dn", "hd"};
            string schema = "";
            DataTable dataTable = new DataTable();

            switch (filter)
            {
                case "Mã phiếu đăng tuyển":
                    filter = "MAPHIEUDANGTUYEN";
                    schema = "pdt";
                    break;
                case "Mã công ty":
                    filter = "MACONGTY";
                    schema = "dn";
                    break;
                case "Tên công ty":
                    filter = "TENCONGTY";
                    schema = "dn";
                    break;
                case "Vị trí ứng tuyển":
                    filter = "VITRIUNGTUYEN";
                    schema = "pdt";
                    break;
                case "Số lượng tuyển dụng":
                    filter = "SOLUONGTUYENDUNG";
                    schema = "pdt";
                    break;
                case "Khoảng thời gian đăng tuyển":
                    filter = "KHOANGTHOIGIANDANGTUYEN";
                    schema = "pdt";
                    break;
                case "Tiêu chí":
                    filter = "TIEUCHI";
                    schema = "pdt";
                    break;
                case "Tổng tiền đã thanh toán":
                    filter = "TONGTIENDATHANHTOAN";
                    schema = "hd";
                    break;

                default:
                    filter = "";
                    schema = "";
                    break;

            }

            if (filter != "")
            {
                condition = $" WHERE {schema}.{filter} LIKE N'%{context}%' ";
            }

            dataTable = DAL.PDTDB.traCuuPDTDB(connnv, condition);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin về phiếu đăng tuyển bạn tìm.");
            }

            return dataTable;
        }

    }
}
