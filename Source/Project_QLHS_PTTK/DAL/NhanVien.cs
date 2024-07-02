using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DAL
{
    public static class NhanVienDB
    {
        public static string TraCuuHoTenNV(OracleConnection connnv, string condition)
        {
            try
            {
                if (connnv.State != System.Data.ConnectionState.Open)
                {
                    connnv.Open();
                }

                string hoTenNV = "";
                // Xây dựng câu lệnh SQL với điều kiện
                string query = "SELECT * FROM ADMIN.NhanVien";
                if (!string.IsNullOrEmpty(condition))
                {
                    query += " WHERE " + condition;
                }

                Console.WriteLine("Executing query: " + query);
                using (OracleCommand cmd = new OracleCommand(query, connnv))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hoTenNV = reader["TENNHANVIEN"].ToString();
                            return hoTenNV;
                        }
                        else { return ""; }
                    }
                }
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException ex)
            {
                Console.WriteLine("Oracle Error: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng
                if (connnv != null && connnv.State == System.Data.ConnectionState.Open)
                {
                    connnv.Close();
                }
            }
        }
    }
}
