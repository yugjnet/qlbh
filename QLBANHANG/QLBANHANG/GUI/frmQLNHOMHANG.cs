using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.DTO;
using QLBANHANG.BLO;

namespace QLBANHANG.GUI
{
    public partial class frmQLNHOMHANG : Form
    {
        private NhomHangDTO nhomHangDTO;
        private NhomHangBLO nhomHangBLO;
        private string error;
        private DataTable bangNH;
        
        public frmQLNHOMHANG()
        {
            InitializeComponent();
            nhomHangBLO = new NhomHangBLO();
            nhomHangDTO = new NhomHangDTO();
            error = "";
        }

        private void doc_bang_xuat_luoi()
        {
            
            bangNH = nhomHangBLO.Doc_dl();
            lbNhomHang.DisplayMember = "TenNhom";
            lbNhomHang.ValueMember = "MaNhom";
            lbNhomHang.DataSource = bangNH;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            nhomHangDTO = new NhomHangDTO(txtMaNhom.Text,txtTenNhom.Text);
            if (!nhomHangBLO.Insert(nhomHangDTO))
            {
                error = nhomHangBLO.Error;
                MessageBox.Show(error,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Đã thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtMaNhom.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vi_tri_xoa = lbNhomHang.SelectedIndex;
            bangNH.Rows[vi_tri_xoa].Delete();
            nhomHangBLO.Delete(bangNH);
            bangNH.AcceptChanges();
        }

        private void tcNhomhang_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                doc_bang_xuat_luoi();
            }
        }

    }
}
