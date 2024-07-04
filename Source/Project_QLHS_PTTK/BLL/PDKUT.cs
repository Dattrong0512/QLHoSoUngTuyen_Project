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
    public static class PDKUT
    {
        public static DataTable traCuuPUT(OracleConnection connnv, string filter, string context)
        {
            string condition = "";
            DataTable dataTable = new DataTable();

            switch (filter)
            {
                case "Mã ứng viên":
                    filter = "MAUNGVIEN";
                    break;
                case "Mã phiếu ứng tuyển":
                    filter = "MAPHIEUUNGTUYEN";
                    break;
                case "Vị trí ứng tuyển":
                    filter = "VITRIUNGTUYEN";
                    break;
                case "Tình trạng phiếu":
                    filter = "TINHTRANGPHIEU";
                    break;
                default:
                    filter = "";
                    break;

            }

            if (filter != "")
            {
                condition = $" WHERE {filter} LIKE N'%{context}%' " ;
            }   
            
            dataTable = DAL.PDKUTDB.traCuuPUTDB(connnv, condition);

            if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin về phiếu ứng tuyển bạn tìm.");
            }

            return dataTable;
        }
    }
}
