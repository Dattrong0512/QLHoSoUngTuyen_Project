using Oracle.ManagedDataAccess.Client;
using System.Data;
using System;

namespace BLL
{
    public static class ChiTietHoSoBLL
    {
        public static DataTable TraCuuChiTietHoSo(OracleConnection conn, string maHoSo)
        {
            string condition = $" WHERE MaHoSo = '{maHoSo}'";
            return DAL.ChiTietHoSoDAL.TraCuuChiTietHoSo(conn, condition);
        }
    }
}

