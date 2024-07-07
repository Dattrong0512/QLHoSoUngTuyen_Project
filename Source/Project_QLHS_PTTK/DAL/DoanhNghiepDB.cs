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
                string query = "SELECT MACONGTY, TENCONGTY, MASOTHUE, NGUOIDAIDIEN, DIACHI, EMAIl FROM ADMIN.DoanhNghiep";
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

        public static bool KiemTraDNTonTai(OracleConnection connnv, string masothue)
        {
            bool exists = false;
            try
            {
                string query = "SELECT COUNT(*) FROM ADMIN.DoanhNghiep WHERE MASOTHUE = :masothue";
                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    cmd.Parameters.Add(new OracleParameter("masothue", masothue));

                    if (connnv.State != ConnectionState.Open)
                    {
                        connnv.Open();
                    }
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    exists = (count > 0);
                }
            }
            finally
            {
                if (connnv != null && connnv.State == ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
            return exists;
        }

        public static bool ThemDoanhNghiepDB(OracleConnection connnv, string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email, string matkhau)
        {
            try
            {
                if (connnv.State != ConnectionState.Open)
                {
                    connnv.Open();
                }
                string query = "INSERT INTO ADMIN.DoanhNghiep (TENCONGTY, MASOTHUE, NGUOIDAIDIEN, DIACHI, EMAIL, MATKHAU) VALUES (:tenCongTy, :maSoThue, :nguoiDaiDien, :diaChi, :email, :matKhau)";

                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    cmd.Parameters.Add(new OracleParameter("tenCongTy", tenCongTy));
                    cmd.Parameters.Add(new OracleParameter("maSoThue", maSoThue));
                    cmd.Parameters.Add(new OracleParameter("nguoiDaiDien", nguoiDaiDien));
                    cmd.Parameters.Add(new OracleParameter("diaChi", diaChi));
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("matKhau", matkhau));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected >= 0) { return true; }
                    else { return false; }
                }
            }
            finally
            {
                if (connnv != null && connnv.State == ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
        }
    }
}
