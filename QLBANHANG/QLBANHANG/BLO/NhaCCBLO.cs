using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBANHANG.DTO;
using QLBANHANG.DAO;
using System.Data;

namespace QLBANHANG.BLO
{
    class NhaCCBLO
    {
        private string _error;
        private NhaCCDTO _nhaCCDTO;
        private NhaCCDAO _nhaCCDAO;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public NhaCCDTO nhaCCDTO
        {
            get { return _nhaCCDTO; }
            set { _nhaCCDTO = value; }
        }

        public NhaCCBLO()
        {
            _error = "";
            _nhaCCDTO = new NhaCCDTO();
            _nhaCCDAO = new NhaCCDAO();
        }

        public bool Insert()
        {
            if (!_nhaCCDAO.Insert(_nhaCCDTO))
            {
                _error = _nhaCCDAO.Error;
                return false;
            }
            return true;
        }

        public DataTable DocNCC()
        {
            return _nhaCCDAO.DocNCC();
        }

        public void Update(DataTable bangNCC)
        {
            _nhaCCDAO.Update(bangNCC);
        }
    }
}
