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
        void InsertHD()
        {
            if (txtMaMoi.Text == "" || txtMaKH2.Text == "" || dtpNgayLapHD.Value.Date.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            //using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            //{
            //    HoaDon hd = new HoaDon();
            //    if(txtMaSach.Text != hd.MaSach.ToString() || txtMaKH2.Text != hd.MaKH.ToString())
            //    {
            //        MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng nhập");
            //    }    
            //}    
            string mahd = txtMaMoi.Text;
            string makh = txtMaKH2.Text;
            string tenkh = txtTenKH2.Text;
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            int tongtien = 0;
            DateTime ngaynhap = dtpNgayLapHD.Value.Date;
            BUSHoaDon.InsertHD(mahd, makh, tenkh, ngaynhap,masach, tensach, soluong, tongtien);
            MessageBox.Show("Thêm hoá đơn thành công");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertHD();
            frmHoaDon_Load(sender, e);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDS();
            txtTongTien.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtTongTien.Text == "0")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá hoá đơn này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BUSHoaDon.DeleteHD(txtMaMoi.Text);
                    MessageBox.Show("Xoá thành công!");
                    loadDS();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng xoá hết sách ra khỏi hoá đơn.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void timKiem(string tk)
        {
            List<DTOHoaDon> dsKH = BUSHoaDon.TimKiem(tk);
            dgvDSHD.DataSource = dsKH;
            for (int i = 0; i < dgvDSHD.Rows.Count; i++)
            {
                dgvDSHD.Rows[i].Cells[0].Value = i + 1;
            }
        }


        void UpdateHD()
        {
            if (txtMaMoi.Text == "" || txtMaKH2.Text == "" || dtpNgayLapHD.Value.Date.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string mahd = txtMaMoi.Text;
            string makh = txtMaKH2.Text;
            string tenkh = txtTenKH2.Text;
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            int tongtien = 0;

            DateTime ngaynhap = dtpNgayLapHD.Value.Date;
            BUSHoaDon.UpdateHD(mahd, makh, tenkh, ngaynhap, masach, tensach, soluong, tongtien);
            MessageBox.Show("Sửa thông tin thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaMoi.Enabled = false;
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentRow.Index; //dòng chọn

                txtMaMoi.Text = dgvDSHD.Rows[index].Cells[1].Value.ToString();
                txtMaKH2.Text = dgvDSHD.Rows[index].Cells[2].Value.ToString();//1
                txtTenKH2.Text = dgvDSHD.Rows[index].Cells[3].Value.ToString();
                txtMaSach.Text = dgvDSHD.Rows[index].Cells[4].Value.ToString();
                txtTenSach.Text = dgvDSHD.Rows[index].Cells[5].Value.ToString();
                txtTongTien.Text = dgvDSHD.Rows[index].Cells[8].Value.ToString();
                txtSoLuong.Text = dgvDSHD.Rows[index].Cells[7].Value.ToString();
                dtpNgayLapHD.Text = dgvDSHD.Rows[index].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UpdateHD();
            loadDS();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string thongtin = txtMaKH.Text;
            timKiem(thongtin);
        }
    }
}
