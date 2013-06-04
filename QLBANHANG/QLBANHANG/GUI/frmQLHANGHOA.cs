using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BLO;

namespace QLBANHANG.GUI
{
    public partial class frmQLHANGHOA : Form
    {
        private QLBanHangBLO qlBanHangBLO;
        private DataTable bangNCC;
        private DataTable bangHH;
        private BindingManagerBase bindingHH;

        public frmQLHANGHOA()
        {
            InitializeComponent();
            qlBanHangBLO = new QLBanHangBLO();
        }

        private void tao_nhom_hang()
        {
            var bangNH = qlBanHangBLO.Doc_dl_NH();
            cbNhomHang.DisplayMember = "TenNhom";
            cbNhomHang.ValueMember = "MaNhom";
            cbNhomHang.DataSource = bangNH;
        }

        private void tao_mat_hang()
        {
            bangHH = qlBanHangBLO.Doc_dl_HH();
            lbMatHang.DisplayMember = "TenHH";
            lbMatHang.ValueMember = "MaHH";
            lbMatHang.DataSource = bangHH;

            bindingHH = BindingContext[bangHH];
            bindingHH.PositionChanged += new EventHandler(bindingHH_PositionChanged);
        }
        private void doc_bangNCC()
        {
            bangNCC = qlBanHangBLO.Doc_dl_NCC();
        }

        private void frmQLHANGHOA_Load(object sender, EventArgs e)
        {
            doc_bangNCC();
            tao_mat_hang();
            tao_nhom_hang();
        }

        private void bindingHH_PositionChanged(object sender, EventArgs e)
        {
            if (typeof(DataRowView) == bindingHH.Current.GetType())
            {
                var row_current = (DataRowView)bindingHH.Current;
                txtMaHangHoa.Text = row_current["MaHH"].ToString();
                txtTenHangHoa.Text = row_current["TenHH"].ToString();

                bangNCC.DefaultView.RowFilter = "MaNCC='" + row_current["MaNCC"] + "'";
                var row_view = bangNCC.DefaultView[0];
                txtNCC.Text = row_view["TenNCC"].ToString();
                txtDiaChi.Text = row_view["DiaChi"].ToString();

                txtSoLuong.Text = row_current["SoLuong"].ToString();
                txtDonGia.Text = row_current["DonGia"].ToString();
            }
        }

        private void cbNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            bangHH.DefaultView.RowFilter = "MaNhom='" + cbNhomHang.SelectedValue + "'";
            bindingHH_PositionChanged(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (typeof(DataRowView) == bindingHH.Current.GetType())
            {
                try
                {
                    var row_current = (DataRowView)bindingHH.Current;
                    row_current["MaHH"] = txtMaHangHoa.Text;
                    row_current["TenHH"] = txtTenHangHoa.Text;

                    var row_view = bangNCC.DefaultView[0];
                    row_view["TenNCC"] = txtNCC.Text;
                    row_view["DiaChi"] = txtDiaChi.Text;
                    row_view.EndEdit();

                    row_current["SoLuong"] = txtSoLuong.Text;
                    row_current["DonGia"] = txtDonGia.Text;
                    bindingHH.EndCurrentEdit();
                
                    qlBanHangBLO.UpdateHH(bangHH);
                    qlBanHangBLO.UpdateNCC(bangNCC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Đã chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            bindingHH_PositionChanged(sender, e);
        }
    }
}
