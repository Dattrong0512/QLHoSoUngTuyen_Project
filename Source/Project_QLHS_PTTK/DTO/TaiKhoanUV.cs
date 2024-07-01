using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanUV : TaiKhoan
    {
        public TaiKhoanUV(string maTK, string matKhau, string vaiTro)
            : base(maTK, matKhau, vaiTro) // Gọi phương thức khởi tạo của lớp cha
        {
        }
    }
}
