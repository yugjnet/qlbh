using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace QLBANHANG.DAO
{
    class QLBanHangDAO
    {
        private SqlDataAdapter adapter_HH;
        private SqlDataAdapter adapter_NCC;

        public void UpdateHH(DataTable bangHH)
        {
            if (adapter_HH != null)
            {
                adapter_HH.Update(bangHH);
                bangHH.AcceptChanges();
            }
        }


        public DataTable Doc_dl_HH()
        {
            var bangHH = new DataTable("HANGHOA");
            var lenh = "select * from HangHoa";
            adapter_HH = new SqlDataAdapter(lenh, Connection.Cnn);
            adapter_HH.FillSchema(bangHH, SchemaType.Mapped);
            adapter_HH.Fill(bangHH);
            var cmdb = new SqlCommandBuilder(adapter_HH);
            return bangHH;
        }

        public void UpdateNCC(DataTable bangNCC)
        {
            if (adapter_NCC != null)
            {
                adapter_NCC.Update(bangNCC);
                bangNCC.AcceptChanges();
            }
        }


        public DataTable Doc_dl_NCC()
        {
            var bangNCC = new DataTable("NHACC");
            var lenh = "select * from NhaCungCap";
            adapter_NCC = new SqlDataAdapter(lenh, Connection.Cnn);
            adapter_NCC.FillSchema(bangNCC, SchemaType.Mapped);
            adapter_NCC.Fill(bangNCC);
            var cmdb = new SqlCommandBuilder(adapter_NCC);
            return bangNCC;
        }

        public DataTable Doc_dl_NH()
        {
            var bangNH = new DataTable("NHOMHANG");
            var lenh = "select * from NhomHang";
            var adapter_NH = new SqlDataAdapter(lenh, Connection.Cnn);
            adapter_NH.FillSchema(bangNH, SchemaType.Mapped);
            adapter_NH.Fill(bangNH);
            return bangNH;
        }
    }
}
