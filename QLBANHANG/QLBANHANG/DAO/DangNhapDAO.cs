using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLBANHANG.DAO
{
    class DangNhapDAO
    {
        private DangNhapDTO _dangNhapDTO = null;

        public DangNhapDTO DangNhapDTO
        {
          get { return _dangNhapDTO; }
          set { _dangNhapDTO = value; }
        }

        public bool Doc_dl(string user, string pwd)
        {
            var lenh = "select * from NhanVien where TenDangNhap='" + user.Trim() +
                "' AND MatKhau='" + pwd.Trim() + "'";
            var bo_doc = new SqlDataAdapter(lenh,Connection.Cnn);
            var bang = new DataTable();
            bo_doc.Fill(bang);
            if (bang.Rows.Count <= 0)
                return false;
            var row = bang.Rows[0];
            _dangNhapDTO = new DangNhapDTO() { 
                                                MaNV = row["MaNV"].ToString(),
                                                MaCV = row["MaCV"].ToString(),
                                                TenNV = row["TenNV"].ToString(),
                                                TenDN = row["TenDangNhap"].ToString(),
                                                GioiTinh = row["GioiTinh"].ToString(),
                                                NgaySinh = (DateTime)row["NgaySinh"],
                                                SoDT = row["SoDienThoai"].ToString(),
                                                DiaChi = row["DiaChi"].ToString()
                                             };
            return true;
        }
    }
}
