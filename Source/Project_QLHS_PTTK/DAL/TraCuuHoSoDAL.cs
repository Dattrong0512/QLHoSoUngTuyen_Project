using System.Data;
using System;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public static class HoSoDAL
    {
        public static DataTable TraCuuHoSo(OracleConnection conn, string condition)
        {
            string sql = "SELECT MaHoSo, NgayNopHoSo, TinhTrangHS FROM ADMIN.HoSoUngTuyen " + condition;
            DataTable dataTable = new DataTable();
            try
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }
    }
}
