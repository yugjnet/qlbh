using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBANHANG.DTO
{
    class NhaCCDTO
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public NhaCCDTO()
        {
            MaNCC = "";
            TenNCC = "";
            DiaChi = "";
            DienThoai = "";
            Fax = "";
            Email = "";
        }

        public NhaCCDTO(string MaNCC,string TenNCC ,string DiaChi ,
            string DienThoai ,string Fax,string Email)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
            this.Fax = Fax;
            this.Email = Email;
        }
    }
}
