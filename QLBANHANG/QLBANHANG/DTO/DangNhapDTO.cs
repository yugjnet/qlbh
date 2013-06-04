using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBANHANG.DTO
{
    class DangNhapDTO : EventArgs
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string TenNV { get; set; }
        public string TenDN { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
    }
}
