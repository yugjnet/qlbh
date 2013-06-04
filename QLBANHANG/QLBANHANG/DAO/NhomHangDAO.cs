using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DTO;
using System.Data.SqlClient;

namespace QLBANHANG.DAO
{
    class NhomHangDAO
    {
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public bool Insert(NhomHangDTO nhomHangDTO)
        {
            var lenh = "Insert into NhomHang values('" + nhomHangDTO.MaNhom + "','" + nhomHangDTO.TenNhom + "')";
            var cmd = new SqlCommand(lenh,Connection.Cnn);
            try
            {
                Connection.Open();
                int kq = cmd.ExecuteNonQuery();
                Connection.Close();
                if (kq <= 0) return false;
            }
            catch (Exception e)
            {
                _error = e.Message;
                return false;
            }
            return true;
        }


    }
}
