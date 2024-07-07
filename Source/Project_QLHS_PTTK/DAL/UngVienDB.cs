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
    public static class UngVienDB
    {
        public static DataTable DocTTUV(OracleConnection connnv, string condition)
        {
            DataTable dtuv = new DataTable();
            try
            {
                string query = "SELECT MAUNGVIEN, HOTEN, SDT, EMAIL, DIACHI FROM ADMIN.UngVien";
                if (!string.IsNullOrEmpty(condition))
                {
                    query += " WHERE " + condition;
                }

                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dtuv);
                    }
                }
            }
            finally
            {
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
            return dtuv;
        }



        // Phương thức kiểm tra tài khoản đã tồn tại
        public static bool IsAccountExists(OracleConnection connection, string hovaten)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM Candidates WHERE HoVaTen = :HoVaTen", connection))
                {
                    command.Parameters.Add(new OracleParameter("HoVaTen", hovaten));
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra tài khoản: " + ex.Message);
            }
        }

        // Phương thức thêm ứng viên vào cơ sở dữ liệu
        public static void AddCandidate(OracleConnection connection, string hovaten, DateTime ngaysinh, string diachi, string sodienthoai, string password)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("INSERT INTO Candidates (HoVaTen, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (:HoVaTen, :NgaySinh, :DiaChi, :SoDienThoai, :MatKhau)", connection))
                {
                    command.Parameters.Add(new OracleParameter("HoVaTen", hovaten));
                    command.Parameters.Add(new OracleParameter("NgaySinh", ngaysinh));
                    command.Parameters.Add(new OracleParameter("DiaChi", diachi));
                    command.Parameters.Add(new OracleParameter("SoDienThoai", sodienthoai));
                    command.Parameters.Add(new OracleParameter("MatKhau", password));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm ứng viên: " + ex.Message);
            }
        }
    }
}
  
