using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DTO;
namespace QLBANHANG.DAO
{
    class NhaCCDAO
    {
        private string _error;
        private SqlDataAdapter adapter;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public NhaCCDAO()
        {
            _error = "";
            adapter = null;
        }

        public bool Insert(NhaCCDTO nhaCCDTO)
        {
            var lenh = "insert into NhaCungCap values("+ 
                        "N'" + nhaCCDTO.MaNCC.Trim() + "'," +
                        "N'" + nhaCCDTO.TenNCC.Trim() + "'," +
                        "N'" + nhaCCDTO.DiaChi.Trim() + "'," +
                        "N'" + nhaCCDTO.DienThoai.Trim() + "'," +
                        "N'" + nhaCCDTO.Fax.Trim() + "'," +
                        "N'" + nhaCCDTO.Email.Trim() + "'" +
                        ")";
            try
            {
                var cmd = new SqlCommand(lenh, Connection.Cnn);
                Connection.Open();
                int kq = cmd.ExecuteNonQuery();
                Connection.Close();
                if (kq <= 0) return false;
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }

        public DataTable DocNCC()
        {
            var bangNCC = new DataTable("NHACC");
            adapter = new SqlDataAdapter("select * from NhaCungCap",Connection.Cnn);
            adapter.FillSchema(bangNCC,SchemaType.Mapped);
            adapter.Fill(bangNCC);
            var cmdb = new SqlCommandBuilder(adapter);
            return bangNCC;
        }

        public void Update(DataTable bangNCC)
        {
            if (adapter != null)
            {
                adapter.Update(bangNCC);
                bangNCC.AcceptChanges();
            }
        }
    }
}
