using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANHANG.GUI
{
    public partial class frmQUANLYHOADON : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=(local);Initial Catalog=qlbh;Persist Security Info=True;User ID=sa;Password=anhtuan");
        public frmQUANLYHOADON()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            sc.Open();
            string query = "select HoaDon.MaHD, count(HoaDonChiTiet.MaHD) as TongSoMatHang, HoaDon.MaNV, HoaDon.TongTien,HoaDon.NgayTao from HoaDon, HoaDonChiTiet where HoaDon.MaHD = HoaDonChiTiet.MaHD and NgayTao between '" + dtFromDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtEndDate.Value.ToString("yyyy-MM-dd") + "' group by HoaDon.MaHD, HoaDon.MaNV, HoaDon.TongTien, HoaDon.NgayTao";

            SqlDataAdapter dataadapter = new SqlDataAdapter(query, sc);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "HoaDon");

            dgBill.DataSource = ds;
            dgBill.DataMember = "HoaDon";
            sc.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
