using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM UNGVIEN WHERE HOTEN = :HoVaTen", connection))
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
        public static bool AddCandidateDB(OracleConnection connection, string hovaten, string email, string diachi, string sodienthoai, string password)
        {
            //if (!long.TryParse(sodienthoai, out long sdt))
            //{
            //    throw new Exception("Số điện thoại không hợp lệ");
            //}
           
            try
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("INSERT INTO UNGVIEN (HOTEN, SDT,EMAIL, DIACHI, MATKHAU) VALUES (:HoVaTen,:SoDienThoai, :Email, :DiaChi, :MatKhau)", connection))
                {
                    command.BindByName = true;
                    double sdt = long.Parse(sodienthoai);
                    command.Parameters.Add(new OracleParameter("SoDienThoai", sdt));
                    //command.Parameters.Add(new OracleParameter("SoDienThoai", OracleDbType.Int64)).Value = sdt;
                    command.Parameters.Add(new OracleParameter("HoVaTen", hovaten));
                    command.Parameters.Add(new OracleParameter("Email", email));
                    command.Parameters.Add(new OracleParameter("DiaChi", diachi));
                    command.Parameters.Add(new OracleParameter("MatKhau", password));
                    
                    command.ExecuteNonQuery();
                    
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm ứng viên: " + ex.Message);
                
            }
            
        }
        public static bool KiemTraTaiKhoanTonTaiDB(OracleConnection connnv, string email)
        {
            try
            {
                if (connnv.State != ConnectionState.Open)
                {
                    connnv.Open();
                }
                
                string query = "SELECT COUNT(*) FROM ADMIN.UngVien WHERE EMAIL = :email";

                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    cmd.Parameters.Add(new OracleParameter(":email", email));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
  
