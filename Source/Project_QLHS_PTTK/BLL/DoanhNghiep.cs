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
using System.Text.RegularExpressions;

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

        public static int ValidateInputs(string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email, OracleConnection connect)
        {
            if (IsPlaceholderOrEmpty(tenCongTy, "Tên công ty") ||
                IsPlaceholderOrEmpty(maSoThue, "Mã số thuế") ||
                IsPlaceholderOrEmpty(nguoiDaiDien, "Người đại diện") ||
                IsPlaceholderOrEmpty(diaChi, "Địa chỉ") ||
                IsPlaceholderOrEmpty(email, "Email"))
            {
                return 0;
            }

            if (!IsValidTaxId(maSoThue))
            {
                MessageBox.Show("Mã số thuế phải là chuỗi 10 ký tự số.");
                return 2;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return 3;
            }
            bool exists = KiemTraDoanhNghiepTonTai(connect, maSoThue);

            if (exists)
            {
                MessageBox.Show("Thông tin doanh nghiệp đã tồn tại.");
                return 4;
            }
            //bool exists = KiemTraDoanhNghiepTonTai(connect, maSoThue);
            //return !exists;
            return 1;
        }

        private static bool IsValidTaxId(string taxId)
        {
            // Check if the tax ID is a 10-digit number
            return Regex.IsMatch(taxId, @"^\d{10}$");
        }

        private static bool IsValidEmail(string email)
        {
            // Basic email validation pattern
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private static bool IsPlaceholderOrEmpty(string text, string placeholder)
        {
            return string.IsNullOrWhiteSpace(text) || text == placeholder;
        }

        public static bool KiemTraDoanhNghiepTonTai(OracleConnection connect, string masothue)
        {
            bool check = false;
             check= DAL.DoanhNghiepDB.KiemTraDNTonTai(connect, masothue);
            return check;
        }

        public static bool ThemDoanhNghiep(OracleConnection connect, string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email, string matkhau)
        {
            return DAL.DoanhNghiepDB.ThemDoanhNghiepDB(connect, tenCongTy, maSoThue, nguoiDaiDien, diaChi, email, matkhau);
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
