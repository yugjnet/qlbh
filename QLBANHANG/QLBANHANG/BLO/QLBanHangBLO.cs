using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLBANHANG.DAO;

namespace QLBANHANG.BLO
{
    class QLBanHangBLO
    {
        private QLBanHangDAO qlBanHangDAO;

        public QLBanHangBLO()
        {
            qlBanHangDAO = new QLBanHangDAO();
        }

        public void UpdateHH(DataTable bangHH)
        {
            qlBanHangDAO.UpdateHH(bangHH);
        }


        public DataTable Doc_dl_HH()
        {
            
            return qlBanHangDAO.Doc_dl_HH();
        }

        public void UpdateNCC(DataTable bangNCC)
        {
            qlBanHangDAO.UpdateNCC(bangNCC);
        }


        public DataTable Doc_dl_NCC()
        {

            return qlBanHangDAO.Doc_dl_NCC();
        }

        public DataTable Doc_dl_NH()
        {
            
            return qlBanHangDAO.Doc_dl_NH();
        }
    }
}
