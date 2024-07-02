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
            dt = DAL.DoanhNghiepDB.TraCuuDn(connect);
            return dt;

        }
        public static DataTable HienThiDoanhNghiep(string comboBox, string value)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
