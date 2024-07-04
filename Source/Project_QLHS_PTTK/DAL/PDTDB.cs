using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class PDTDB
    {
        public static DataTable traCuuPDTDB(OracleConnection connnv, string condition)
        {
            string sql = "select pdt.MAPHIEUDANGTUYEN, pdt.MACONGTY, TENCONGTY, VITRIUNGTUYEN," +
                " SOLUONGTUYENDUNG, KHOANGTHOIGIANDANGTUYEN, TIEUCHI, hd.TONGTIENDATHANHTOAN" +
                " from admin.PhieuDangTuyen pdt join admin.DoanhNghiep dn on pdt.macongty = dn.macongty" +
                " join admin.HoaDon hd on hd.maphieudangtuyen = pdt.maphieudangtuyen " + condition;
            Debug.WriteLine(sql);
            DataTable dataTable = new DataTable();
            try
            {
                using (OracleCommand cmd = new OracleCommand(sql, connnv))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
            return dataTable;
        }
    }
}
