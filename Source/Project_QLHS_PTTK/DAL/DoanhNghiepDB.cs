using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;
namespace DAL
{
    public static class DoanhNghiepDB
    {
        public static DataTable TraCuuDn(OracleConnection connnv)
        {
            // Khởi tạo DataTable
            DataTable dtdn = new DataTable();

            // Mở kết nối
            try
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.DoanhNghiep", connnv))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        // Điền dữ liệu vào DataTable
                        da.Fill(dtdn);
                    }
                }
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }

            // Trả về DataTable chứa dữ liệu
            return dtdn;
        }
    }
}
