using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBANHANG.DAO
{
    class Connection
    {
        private static SqlConnection cnn;
       
        public static SqlConnection Cnn
        {
            get { return Connection.cnn; }
            set { Connection.cnn = value; }
        }

        static Connection()
        {
            var chuoi_kn = ConfigurationManager.ConnectionStrings["connectionString"];
            cnn = new SqlConnection(chuoi_kn.ConnectionString);
        }

        public static bool Open()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static void Close()
        {
            if (cnn.State != System.Data.ConnectionState.Closed)
                cnn.Close();
        }

    }
}
