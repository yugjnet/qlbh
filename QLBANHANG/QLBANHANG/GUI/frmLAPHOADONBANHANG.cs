using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBANHANG.DTO;

namespace QLBANHANG.GUI
{
    public partial class frmLAPHOADONBANHANG : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=(local);Initial Catalog=qlbh;Persist Security Info=True;User ID=sa;Password=anhtuan");
        SqlCommand cmd;

        public frmLAPHOADONBANHANG()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHangHoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa");
                return;
            }

            if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                return;
            }

            sc.Open();
            string query = "select * from HangHoa where MaHH=@ten";
            cmd = new SqlCommand(query, sc);
            SqlParameter name = cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 15);
            name.Value = txtHangHoa.Text;
            SqlDataReader rdr = cmd.ExecuteReader();

            if (!rdr.Read())
            {
                MessageBox.Show("Mã hàng không tồn tại");
                sc.Close();
                return;
            }

            DataGridViewRow row = (DataGridViewRow)dgHangHoa.Rows[0].Clone();
            row.Cells[0].Value = txtHangHoa.Text;
            row.Cells[1].Value = rdr.GetString(3);
            row.Cells[2].Value = "vnd";
            row.Cells[3].Value = txtSoluong.Text;
            row.Cells[4].Value = rdr.GetDecimal(5);
            row.Cells[5].Value = txtTongCong.Text;
            row.Cells[6].Value = "0%";
            dgHangHoa.Rows.Add(row);
            Decimal total_bill = this.total_billing();
            txtTongTienHD.Text = total_bill.ToString();
            sc.Close();
        }

        private void txtHangHoa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoluong.Text))
            {
                sc.Open();
                string query = "select * from HangHoa where MaHH=@ten";
                cmd = new SqlCommand(query, sc);
                SqlParameter name = cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 15);
                name.Value = txtHangHoa.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                
                if (rdr.Read())
                {
                    Decimal soluong = Decimal.Parse(txtSoluong.Text);
                    Decimal tong = rdr.GetDecimal(5) * soluong;
                    txtTongCong.Text = tong.ToString();
                }
                sc.Close();
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHangHoa.Text))
            {
                sc.Open();
                string query = "select * from HangHoa where MaHH=@ten";
                cmd = new SqlCommand(query, sc);
                SqlParameter name = cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 15);
                name.Value = txtHangHoa.Text;
                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {
                    Decimal soluong = Decimal.Parse(txtSoluong.Text);
                    Decimal tong = rdr.GetDecimal(5) * soluong;
                    txtTongCong.Text = tong.ToString();
                }
                sc.Close();
            }
        }

        private Decimal total_billing()
        {
            Decimal total_bill = 0;
            foreach (DataGridViewRow row in this.dgHangHoa.Rows)
            {
                if (!row.IsNewRow)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex.Equals(5))
                    {
                        Decimal amount = Decimal.Parse(cell.Value.ToString());
                        total_bill = total_bill + amount;
                    }
                }
            }
            return total_bill;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoaDon.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn");
                return;
            }

            if (dgHangHoa.RowCount == 1)
            {
                MessageBox.Show("Chưa có mặt hàng nào được thêm vào hóa đơn");
                return;
            }
            sc.Open();
            SqlTransaction transaction;
            transaction = sc.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "Insert into HoaDon(MaHD, MaNV, TongTien, NgayTao) values('" + txtHoaDon.Text + "', '" + Common.MaNV + "', '" + txtTongTienHD.Text + "', '" + DateTime.Today+ "')";
                cmd.ExecuteNonQuery();

                foreach (DataGridViewRow row in this.dgHangHoa.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cmd.CommandText = "Insert into HoaDonChiTiet(MaHD, MaHH, DonGia, SoLuong, ChietKhau, ThoiGianCapNhat) values('" + txtHoaDon.Text + "', '" + row.Cells[0].Value + "', '" + row.Cells[4].Value + "', '" + row.Cells[3].Value + "', 0,'" + DateTime.Today + "')";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "Update HangHoa Set Soluong=Soluong-" + row.Cells[3].Value+" where MaHH = '"+txtHangHoa.Text+"'";
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
            sc.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            dgHangHoa.Rows.Clear();
            txtHoaDon.Text = "";
            txtHangHoa.Text = "";
            txtSoluong.Text = "";
            txtTongCong.Text = "";
            txtTongTienHD.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
