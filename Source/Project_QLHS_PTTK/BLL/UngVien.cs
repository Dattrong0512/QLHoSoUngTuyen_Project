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
    public class DataResult
    {
        public DataTable DataTable { get; set; }
        public bool HasData { get; set; }
    }
    public static class UngVien
    {
        public static DataTable HienThiUngVien(OracleConnection connect)
        {
            DataTable dt = new DataTable();
            dt = DAL.UngVienDB.DocTTUV(connect, "");
            return dt;
        }

        public static DataResult TraCuuUngVien(OracleConnection connect, string ValueCBB, string valueText)
        {
            DataTable dt = new DataTable();
            string value = "";
            switch (ValueCBB)
            {
                case "Họ Tên Ứng Viên":
                    value += "HOTEN LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.UngVienDB.DocTTUV(connect, value);
                    break;
                case "Mã Ứng Viên":
                    value += "MAUNGVIEN LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.UngVienDB.DocTTUV(connect, value);
                    break;
                case "Địa chỉ":
                    value += "DIACHI LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.UngVienDB.DocTTUV(connect, value);
                    break;
            }
            return new DataResult
            {
                DataTable = dt,
                HasData = dt.Rows.Count > 0
            };
        }


        // Phương thức kiểm tra tài khoản đã tồn tại
        public static bool IsAccountExists(OracleConnection connection, string hovaten)
        {
            return DAL.UngVienDB.IsAccountExists(connection, hovaten);
        }

        // Phương thức thêm ứng viên vào cơ sở dữ liệu
        public static void AddCandidate(OracleConnection connection, string hovaten, DateTime ngaysinh, string diachi, string sodienthoai, string password)
        {
            DAL.UngVienDB.AddCandidate(connection, hovaten, ngaysinh, diachi, sodienthoai, password);
        }

        // Phương thức tạo mật khẩu ngẫu nhiên
        public static string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
