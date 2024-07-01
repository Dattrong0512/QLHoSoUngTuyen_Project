using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class TaiKhoanNV : TaiKhoan
    {
        public TaiKhoanNV(string maTK, string matKhau, string vaiTro)
            : base(maTK, matKhau, vaiTro) // Gọi phương thức khởi tạo của lớp cha
        {
        }
    }
}
