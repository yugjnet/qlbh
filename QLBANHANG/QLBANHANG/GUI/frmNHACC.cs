using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BLO;
using QLBANHANG.DTO;

namespace QLBANHANG.GUI
{
    public partial class frmNHACC : Form
    {
        private NhaCCDTO _nhaCCDTO;
        private NhaCCBLO _nhaCCBLO;
        private DataTable _bangNCC;
        public frmNHACC()
        {
            InitializeComponent();
            _nhaCCBLO = new NhaCCBLO();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _nhaCCDTO = new NhaCCDTO { MaNCC = txtMaNCC.Text,TenNCC = txtNhaCC.Text,DiaChi = txtDiaChi.Text,DienThoai = txtDienThoai.Text,Fax = txtFax.Text,Email = txtEmail.Text};
            _nhaCCBLO.nhaCCDTO = _nhaCCDTO;
            if (!_nhaCCBLO.Insert())
                MessageBox.Show(_nhaCCBLO.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Đã thêm thành công nhà cung cấp","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtNhaCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtMaNCC.Focus();
        }

        private void tcNhomhang_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                _bangNCC = _nhaCCBLO.DocNCC();
                lbNhaCC.DisplayMember = "TenNCC";
                lbNhaCC.ValueMember = "MaNCC";
                lbNhaCC.DataSource = _bangNCC;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vi_tri_xoa = lbNhaCC.SelectedIndex;
            _bangNCC.Rows[vi_tri_xoa].Delete();
            _nhaCCBLO.Update(_bangNCC);
            _bangNCC.AcceptChanges();
        }


    }
}
