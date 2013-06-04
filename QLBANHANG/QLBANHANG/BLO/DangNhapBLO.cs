using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DAO;
using QLBANHANG.DTO;

namespace QLBANHANG.BLO
{
    class DangNhapBLO
    {
        private DangNhapDTO _dangNhapDTO = null;

        internal DangNhapDTO DangNhapDTO
        {
            get { return _dangNhapDTO; }
            set { _dangNhapDTO = value; }
        }
        public bool Doc_dl(string user, string pwd)
        {
            DangNhapDAO dangNhapDAO = new DangNhapDAO();
            if (dangNhapDAO.Doc_dl(user, pwd))
            {
                _dangNhapDTO = dangNhapDAO.DangNhapDTO;
                return true;
            }
            return false;
        }
    }
}
