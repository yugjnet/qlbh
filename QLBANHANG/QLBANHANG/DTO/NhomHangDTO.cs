using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBANHANG.DTO
{
    class NhomHangDTO
    {
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }

        public NhomHangDTO()
        {
            MaNhom = "";
            TenNhom = "";

        }

        public NhomHangDTO(string maNhom, string tenNhom)
        {
            MaNhom = maNhom;
            TenNhom = tenNhom;

        }
    }
}
