using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BLL
{
    public static class HoSoBLL
    {
        public static DataTable TraCuuHoSo(OracleConnection conn, string maHoSo = "")
        {
            string condition = "";
            if (!string.IsNullOrEmpty(maHoSo))
            {
                condition = $" WHERE MaHoSo LIKE N'%{maHoSo}%'";
            }

            return DAL.HoSoDAL.TraCuuHoSo(conn, condition);
        }
    }
}
