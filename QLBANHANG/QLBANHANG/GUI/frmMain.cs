using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.DTO;

namespace QLBANHANG.GUI
{
    public partial class frmMain : Form
    {
        private DangNhapDTO dangNhapDTO;
        public frmMain()
        {
            InitializeComponent();
            dangNhapDTO = null;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmDANGNHAP frm = new frmDANGNHAP();
            frm.OnDangNhapThanhCong += new EventHandler<DangNhapDTO>(frm_OnDangNhapThanhCong);
            frm.ShowDialog();
            phan_quyen();
        }

        private void phan_quyen()
        {
            if (dangNhapDTO != null)
            {
                reset_all_tooltip();
                if (dangNhapDTO.MaCV.Trim() == "NH")
                    phan_quyen_nhap_hang();
                else if (dangNhapDTO.MaCV.Trim() == "XH")
                    phan_quyen_xuat_hang();
                else if (dangNhapDTO.MaCV.Trim() == "BH")
                    phan_quyen_ban_hang();
                else if (dangNhapDTO.MaCV.Trim() == "KK")
                    phan_quyen_kiem_ke();
                else if (dangNhapDTO.MaCV.Trim() == "TH")
                    phan_quyen_tin_hoc();

            }
            else
                menuStrip1.Enabled = false;
            Common.tenDangNhap = dangNhapDTO.TenDN;
            Common.MaNV = dangNhapDTO.MaNV;
        }

        private void reset_all_tooltip()
        {
            foreach (ToolStripItem tooltip in menuStrip1.Items)
                tooltip.Enabled = true;
        }

        private void phan_quyen_nhap_hang()
        {
            TaoUserMoiToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
            KiemKeToolStripMenuItem.Enabled = false;
            BaoCaoThongKeToolStripMenuItem.Enabled = false;
        }

        private void phan_quyen_xuat_hang()
        {
            TaoUserMoiToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            NhapHangToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
            KiemKeToolStripMenuItem.Enabled = false;
            BaoCaoThongKeToolStripMenuItem.Enabled = false;
        }

        private void phan_quyen_ban_hang()
        {
            TaoUserMoiToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            NhapHangToolStripMenuItem.Enabled = false;
            KiemKeToolStripMenuItem.Enabled = false;
            BaoCaoThongKeToolStripMenuItem.Enabled = false;
        }

        private void phan_quyen_kiem_ke()
        {
            TaoUserMoiToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            NhapHangToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
            BaoCaoThongKeToolStripMenuItem.Enabled = false;
        }

        private void phan_quyen_tin_hoc()
        {
            TaoUserMoiToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            NhapHangToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
        }

        void frm_OnDangNhapThanhCong(object sender, DangNhapDTO e)
        {
            if (e != null) dangNhapDTO = e;
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDANGNHAP frm = new frmDANGNHAP();
            frm.OnDangNhapThanhCong += new EventHandler<DangNhapDTO>(frm_OnDangNhapThanhCong);
            frm.ShowDialog();
            phan_quyen();
        }

        private void NhomHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNHOMHANG frm = new frmQLNHOMHANG();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLAPHOADONBANHANG frm = new frmLAPHOADONBANHANG();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQLHANGHOA frm = new frmQLHANGHOA();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQLNHOMHANG frm = new frmQLNHOMHANG();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmNHACC frm = new frmNHACC();
            frm.ShowDialog();
        }
      
    }
}
