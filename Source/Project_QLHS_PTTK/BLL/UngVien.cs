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
            dt = DAL.UngVienDB.TraCuuUv(connect, "");
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
                    dt = DAL.UngVienDB.TraCuuUv(connect, value);
                    break;
                case "Mã Ứng Viên":
                    value += "MAUNGVIEN LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.UngVienDB.TraCuuUv(connect, value);
                    break;
                case "Địa chỉ":
                    value += "DIACHI LIKE '%";
                    value += valueText;
                    value += "%'";
                    dt = DAL.UngVienDB.TraCuuUv(connect, value);
                    break;
            }
            //if (dt.Rows.Count == 0)
            //{
            //    lblNoData.Visible
            //    MessageBox.Show("Không có thông tin về ứng viên bạn tìm.");
            //}
            return new DataResult
            {
                DataTable = dt,
                HasData = dt.Rows.Count > 0
            };
        }
    }
}
