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

        public static bool KiemTraDoanhNghiepTonTai(OracleConnection connect, string masothue)
        {
            return DAL.DoanhNghiepDB.KiemTraDNTonTai(connect, masothue);
        }

        public static bool ThemDoanhNghiep(OracleConnection connect, string tenCongTy, string maSoThue, string nguoiDaiDien, string diaChi, string email)
        {
            return DAL.DoanhNghiepDB.ThemDoanhNghiepDB(connect, tenCongTy, maSoThue, nguoiDaiDien, diaChi, email);
        }

    }
}
