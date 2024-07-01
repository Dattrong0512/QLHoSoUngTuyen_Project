using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DTO
{
    public class TaiKhoan
    {
        public string MaTK { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }

        public OracleConnection TKconn { get; set; }
        public TaiKhoan(string maTK, string matKhau, string vaiTro)
        {
            this.MaTK = maTK;
            this.MatKhau = matKhau;
            this.VaiTro = vaiTro;
        }
    }
}
