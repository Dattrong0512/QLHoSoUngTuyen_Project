using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DTO
{
    public class TaiKhoanDN : TaiKhoan
    {
        public TaiKhoanDN(string maTK, string matKhau, string vaiTro)
            : base(maTK, matKhau, vaiTro) // Gọi phương thức khởi tạo của lớp cha
        {
        }
    }
}
