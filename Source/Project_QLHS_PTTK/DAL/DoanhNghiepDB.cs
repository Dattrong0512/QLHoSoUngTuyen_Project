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
        public static DataTable TraCuuDn(OracleConnection connnv, string condition)
        {
            // Khởi tạo DataTable
            DataTable dtdn = new DataTable();
            // Mở kết nối
            try
            {
                // Xây dựng câu lệnh SQL với điều kiện
                string query = "SELECT * FROM ADMIN.DoanhNghiep";
                if (!string.IsNullOrEmpty(condition))
                {
                    query += " WHERE " + condition;
                }

                using (OracleCommand cmd = new OracleCommand(query, connnv))
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
