using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nha_Sach_Desktop.UI.frmHoaDon;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
        }
        public class GetMaHD
        {
            public static string getMaHD;
        }
        public void hienthimaKH()
        {
            txtMaKH2.Text = GetMaKH.getMaKH;
            KhachHang kh = KhachHangBUS.GetTenKH(txtMaKH2.Text);
            txtTenKH2.Text = kh.HoTen;
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            hienthimaKH();
        }

        void loadDS()
        {
            List<DTOHoaDon> dsHD = BUSHoaDon.GetDSHD();
            dgvDSHD.DataSource = dsHD;

            for (int i = 0; i < dgvDSHD.Rows.Count; i++)
            {
                dgvDSHD.Rows[i].Cells[0].Value = i + 1;
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            txtMaMoi.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            if (txtMaMoi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
                return;
            }
            for (int i = 0; i < dgvDSHD.Rows.Count; i++)
            {
                if ((string)dgvDSHD.Rows[i].Cells[1].Value == (string)txtMaMoi.Text)
                {
                    GetMaHD.getMaHD = txtMaMoi.Text;
                    GetMaKH.getMaKH = txtMaKH2.Text;
                    frmBanSach frmBS = new frmBanSach();
                    frmBS.ShowDialog();
                    loadDS();
                }
            }
        }
        void InsertHD()
        {
            if (txtMaMoi.Text == "" || txtMaKH2.Text == "" || dtpNgayLapHD.Value.Date.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaMoi.Text;
            string makh = txtMaKH2.Text;
            string tenkh = txtTenKH2.Text;
            int tongtien = 0;
            DateTime ngaynhap = dtpNgayLapHD.Value.Date;
            BUSHoaDon.InsertHD(mahd, makh, tenkh, ngaynhap, tongtien);
            MessageBox.Show("Thêm hoá đơn thành công");

        }
    }
}
