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
    public partial class frmDANGNHAP : Form
    {
        private event EventHandler<DangNhapDTO> _onDangNhapThanhCong;

        internal event EventHandler<DangNhapDTO> OnDangNhapThanhCong
        {
            add { _onDangNhapThanhCong += value; }
            remove { _onDangNhapThanhCong -= value; }
        }

        public frmDANGNHAP()
        {
            InitializeComponent();
            _onDangNhapThanhCong = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var user = txtTen.Text;
            var pwd = txtMatKhau.Text;
            DangNhapBLO dangNhapBLO = new DangNhapBLO();
            if (dangNhapBLO.Doc_dl(user, pwd))
            {
                if(_onDangNhapThanhCong != null)_onDangNhapThanhCong(this,dangNhapBLO.DangNhapDTO);
                this.Close();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị sai","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
