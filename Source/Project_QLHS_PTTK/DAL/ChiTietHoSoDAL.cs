using System.Data;
using System;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public static class ChiTietHoSoDAL
    {
        public static DataTable TraCuuChiTietHoSo(OracleConnection conn, string condition)
        {
            string sql = @"
                SELECT STT, LoaiHoSo, TenHoSo
                FROM ADMIN.ChiTietHoSo"
                + condition;

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

