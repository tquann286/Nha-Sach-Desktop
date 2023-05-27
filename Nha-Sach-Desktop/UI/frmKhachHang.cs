using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;
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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadDSKhachHang()
        {
            List<DTOKhachHang> dsKH = BUSKhachHang.GetDSKhachHang();
            dgvkhachhang.DataSource = dsKH;
            btnLuuKhachHang.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTim.Enabled = true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
        }
        private void timKiem(string strKhachHang)
        {
            List<DTOKhachHang> dsKH = BUSKhachHang.TimDSKH(strKhachHang);
            dgvkhachhang.DataSource = dsKH;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            timKiem(txtTenKhachHang.Text);
            timKiem(txtMaKH.Text);
        }
  
    }
}
