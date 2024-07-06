using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
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
            OracleConnection mycon = null;
            string message = "";
            string stringsqlVaiTro;
            if (taikhoan.VaiTro == "DN")
            {
                stringsqlVaiTro = "SELECT * FROM ADMIN.DoanhNghiep WHERE MaCongTy = :username AND MatKhau = :password";
            }
            else if (taikhoan.VaiTro == "NV")
            {
                stringsqlVaiTro = "check_password_NV";
            }
            else
            {
                stringsqlVaiTro = "SELECT * FROM ADMIN.UngVien WHERE MaUngVien = :username AND MatKhau = :password";
            }

            try
            {
                // Sử dụng kết nối của admin
                mycon = Account.ADconn;
                if (mycon.State == System.Data.ConnectionState.Closed || mycon.State == System.Data.ConnectionState.Broken)
                {
                    mycon.Open();
                }

                if (taikhoan.VaiTro == "NV")
                {
                    using (OracleCommand cmd = new OracleCommand(stringsqlVaiTro, mycon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào câu lệnh SQL
                        var resultParam = new OracleParameter("result", OracleDbType.Int32);
                        resultParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(resultParam);

                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = taikhoan.MaTK;
                        cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = taikhoan.MatKhau;

                        cmd.ExecuteNonQuery();

                        var returnValue = cmd.Parameters["result"].Value;

                        if (returnValue != null && int.TryParse(returnValue.ToString(), out int result))
                        {
                            message = (result == 1) ? "Thành công" : "Tài khoản hoặc mật khẩu không chính xác";
                        }
                    }
                }
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException ex)
            {
                if (ex.Number == 1017)
                {
                    message = "Tài khoản hoặc mật khẩu sai, bạn vui lòng nhập lại";
                }
                else
                {
                    message = $"Lỗi kết nối: {ex.Message}";
                }
            }
            finally
            {
                if (mycon != null && mycon.State == System.Data.ConnectionState.Open)
                {
                    mycon.Close();
                }
            }
            return message;
        }
    }

}

