using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public static class UngVienDB
    {
        public static DataTable TraCuuUv(OracleConnection connnv, string condition)
        {
            DataTable dtuv = new DataTable();
            try
            {
                string query = "SELECT MAUNGVIEN, HOTEN, SDT, EMAIL, DIACHI FROM ADMIN.UngVien";
                if (!string.IsNullOrEmpty(condition))
                {
                    query += " WHERE " + condition;
                }

                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dtuv);
                    }
                }
            }
            finally
            {
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
            return dtuv;
        }
    }
}
