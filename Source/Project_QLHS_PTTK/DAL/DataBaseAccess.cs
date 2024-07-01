using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public static class Account
    {
        public static OracleConnection ADconn { get; private set; }

        static Account()
        {
            // Khởi tạo kết nối OracleConnection
            var connection = new Connection("ADMIN", "ADMIN");
            ADconn = connection.conn;
        }
    }

    public class Connection
    {
        public OracleConnection conn { get; private set; }

        public Connection(string username, string password)
        {
            string connectionString = $@"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id={username};Password={password};";
            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        // Phương thức để đóng kết nối
        public void Close()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
    public class DataBaseAccess
    {
        public static string CheckLogic(TaiKhoan taikhoan)
        {
            string user = null;
            OracleConnection mycon = null;
            string stringsqlVaiTro;
            if (taikhoan.VaiTro == "DN")
            {
                stringsqlVaiTro = "SELECT * FROM ADMIN.DoanhNghiep WHERE MaCongTy = :username AND MatKhau = :password";
            }
            else if(taikhoan.VaiTro == "NV")
            {
                stringsqlVaiTro = "SELECT * FROM ADMIN.NhanVien WHERE MaNhanVien = :username AND MatKhau = :password";
            }    
            else
            {
                stringsqlVaiTro = "SELECT * FROM ADMIN.UngVien WHERE MaUngVien = :username AND MatKhau = :password";
            }    
            try
            {
                // Sử dụng kết nối của admin
                mycon = Account.ADconn;
                mycon.Open();

                using (OracleCommand cmd = new OracleCommand(stringsqlVaiTro, mycon))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.Add(new OracleParameter("username", taikhoan.MaTK));
                    cmd.Parameters.Add(new OracleParameter("password", taikhoan.MatKhau));
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                user = reader.GetString(0); // Lấy giá trị từ cột đầu tiên của hàng
                                return "Thành công";
                            }
                            
                        }
                        else
                        {
                            return "Tài khoản hoặc mật khẩu không chính xác";
                        }
                    }
                }
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException ex)
            {
                if (ex.Number == 1017)
                {
                    return "Tài khoản hoặc mật khẩu sai, bạn vui lòng nhập lại";
                }
                else
                {
                    return $"Lỗi kết nối: {ex.Message}";
                }
            }
            catch (Exception ex)
            {
                return $"Đã xảy ra lỗi: {ex.Message}";
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng
                if (mycon != null)
                {
                    mycon.Close();
                }
            }
            return user;
        }
    }
}

