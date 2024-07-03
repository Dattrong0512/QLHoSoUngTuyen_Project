using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PDKUT
    {
        public static DataTable traCuuPUT(OracleConnection connnv, string filter, string context)
        {
            string condition = "";

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
                condition = $" WHERE {filter} LIKE '%{context}%' " ;
            }     
            
            return DAL.PDKUTDB.traCuuPUTDB(connnv, condition);
        }
    }
}
