using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void bÁOCÁOTỒNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho frmBaoCaoTon = new frmBaoCaoTonKho();
            this.Hide();
            frmBaoCaoTon.ShowDialog();
            this.Show();
        }

        private void bÁOCÁONỢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frmBaoCaoDT = new frmBaoCaoDoanhThu();
            this.Hide();
            frmBaoCaoDT.ShowDialog();
            this.Show();
        }

        private void nHẬPSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPhieuNhapSach = new frmPhieuNhap();
            this.Hide();
            frmPhieuNhapSach.ShowDialog();
            this.Show();
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoadon = new frmHoaDon();
            this.Hide();
            frmHoadon.ShowDialog();
            this.Show(); 
        }

        private void sÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSach frmSach = new frmDSSach();
            this.Hide();
            frmSach.ShowDialog();
            this.Show();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachhang = new frmKhachHang();
            this.Hide();
            frmKhachhang.ShowDialog();
            this.Show();
        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanvien = new frmNhanVien();
            this.Hide();
            frmNhanvien.ShowDialog();
            this.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();            
            frmLogin.ShowDialog();

            this.Close();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
