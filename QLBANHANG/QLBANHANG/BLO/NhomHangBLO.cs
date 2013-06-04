using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DTO;
using QLBANHANG.DAO;
using System.Data;

namespace QLBANHANG.BLO
{
    class NhomHangBLO
    {
        private string _error="";
        private NhomHangDAO nhomHangDAO;
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public NhomHangBLO()
        {
            nhomHangDAO = new NhomHangDAO();
            _error = "";
        }

        public bool Insert(NhomHangDTO nhomHangDTO)
        {
            if (!nhomHangDAO.Insert(nhomHangDTO))
            {
                _error = nhomHangDAO.Error;
                return false;
            }
            return true;
        }

        public void Delete(DataTable bangNH)
        {
            nhomHangDAO.Delete(bangNH);    
        }

        public DataTable Doc_dl()
        {
            return nhomHangDAO.Doc_dl();
        }
    }
}
