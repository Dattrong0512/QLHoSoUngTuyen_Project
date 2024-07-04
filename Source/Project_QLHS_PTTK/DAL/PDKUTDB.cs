using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public static class PDKUTDB
    {
        public static DataTable traCuuPUTDB(OracleConnection connnv, string condition)
        {
            string sql = "select * from ADMIN.PhieuUngTuyen " + condition;
            //Debug.WriteLine(sql);
            DataTable dataTable = new DataTable();
            try
            {
                using (OracleCommand cmd = new OracleCommand(sql, connnv))
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
            finally
            {
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
            return dataTable;
        }
    }
}
