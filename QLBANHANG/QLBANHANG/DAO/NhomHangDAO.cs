using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DTO;
using System.Data.SqlClient;
using System.Data;

namespace QLBANHANG.DAO
{
    class NhomHangDAO
    {
        private static SqlDataAdapter adapter;

        private string _error="";

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public bool Insert(NhomHangDTO nhomHangDTO)
        {
            var lenh = "Insert into NhomHang values(N'" + nhomHangDTO.MaNhom.Trim() + "',N'" + nhomHangDTO.TenNhom.Trim() + "')";
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

        public void Delete(DataTable bangNH)
        {
            if (adapter != null)
            {
                adapter.Update(bangNH);
                bangNH.AcceptChanges();
            }
        }

        public DataTable Doc_dl()
        {
            var bangNH = new DataTable("NHOMHANG");
            var lenh = "select * from NhomHang";
            adapter = new SqlDataAdapter(lenh, Connection.Cnn);
            adapter.FillSchema(bangNH, SchemaType.Mapped);
            adapter.Fill(bangNH);
            var cmdb = new SqlCommandBuilder(adapter);
            return bangNH;
        }
    }
}
