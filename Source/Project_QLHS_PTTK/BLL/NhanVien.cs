using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public static class NhanVien
    {
        public static string HienThiTenNhanVien(OracleConnection connect,string manv)
        {
            string Condition = "";
            string condition = "MANHANVIEN = '" + manv + "'";
            return DAL.NhanVienDB.TraCuuHoTenNV(connect, Condition);

        }


    }
}
