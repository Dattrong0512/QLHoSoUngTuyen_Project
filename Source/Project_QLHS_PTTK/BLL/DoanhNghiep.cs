using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace BLL
{
    public static class DoanhNghiep
    {
        public static DataTable HienThiDoanhNghiep(OracleConnection connect)
        {
            DataTable dt = new DataTable();
            dt = DAL.DoanhNghiepDB.TraCuuDn(connect,"");
            return dt;
        }

        public static DataTable TraCuuDoanhNghiep(OracleConnection connect,string ValueCBB, string valueText)
        {
            DataTable dt = new DataTable();
            string value = "";
            
            switch (ValueCBB)
            {
                case "Tên Doanh Nghiệp":
                    value += "TENCONGTY LIKE '%";
                    value += valueText;                    
                    value += "%'";
                    dt = DAL.DoanhNghiepDB.TraCuuDn(connect, value);
                    break;
                case "Mã Doanh Nghiệp":
                    value += "MACONGTY LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.DoanhNghiepDB.TraCuuDn(connect, value);
                    break;
                case "Mã số thuế":
                    value += "MASOTHUE LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.DoanhNghiepDB.TraCuuDn(connect, value);
                    break;
                case "Địa chỉ":
                    value += "DIACHI LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.DoanhNghiepDB.TraCuuDn(connect, value);
                    break;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin về công ty bạn tìm.");
            }
            return dt;
        }

        public static bool ValidateInputs(string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email, OracleConnection connect)
        {
            if (IsPlaceholderOrEmpty(tenCongTy, "Tên công ty") ||
                IsPlaceholderOrEmpty(maSoThue, "Mã số thuế") ||
                IsPlaceholderOrEmpty(nguoiDaiDien, "Người đại diện") ||
                IsPlaceholderOrEmpty(diaChi, "Địa chỉ") ||
                IsPlaceholderOrEmpty(email, "Email"))
            {
                return false;
            }

            bool exists = KiemTraDoanhNghiepTonTai(connect, maSoThue);
            return !exists;
        }

        private static bool IsPlaceholderOrEmpty(string text, string placeholder)
        {
            return string.IsNullOrWhiteSpace(text) || text == placeholder;
        }

        public static bool KiemTraDoanhNghiepTonTai(OracleConnection connect, string masothue)
        {
            return DAL.DoanhNghiepDB.KiemTraDNTonTai(connect, masothue);
        }

        public static bool ThemDoanhNghiep(OracleConnection connect, string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email, string matkhau, string maCongTy)
        {
            bool isUnique;
            do
            {
                maCongTy = GenerateRandomString(10);
                isUnique = !MaCongTyExists(connect, maCongTy);
            } while (!isUnique);
            return DAL.DoanhNghiepDB.ThemDoanhNghiepDB(connect, tenCongTy, maSoThue, nguoiDaiDien, diaChi, email, matkhau, maCongTy);
        }

        private static bool MaCongTyExists(OracleConnection connnv, string maCongTy)
        {
            string query = "SELECT COUNT(*) FROM ADMIN.DoanhNghiep WHERE MACONGTY = :maCongTy";

            using (OracleCommand cmd = new OracleCommand(query, connnv))
            {
                cmd.Parameters.Add(new OracleParameter("maCongTy", maCongTy));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
