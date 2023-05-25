﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nha_Sach_Desktop.DTO;
using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.BUS;
using static Nha_Sach_Desktop.UI.frmDSSach;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmPhieuNhap : Form
    {
        public static int SO_LUONG_NHAP_TOI_THIEU = 100;
        public static int TongTienNhap;
        int flag = -1;
        bool isClicked = false;
       
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvCTPN.CurrentRow.Index; //dòng chọn

                txtMaPN.Text = dgvCTPN.Rows[index].Cells[0].Value.ToString();
                txtMaSach.Text = dgvCTPN.Rows[index].Cells[1].Value.ToString();//1
                txtDonGia.Text = dgvCTPN.Rows[index].Cells[3].Value.ToString();
                txtSLnhap.Text = dgvCTPN.Rows[index].Cells[2].Value.ToString();
                txtTongTien.Text = dgvCTPN.Rows[index].Cells[4].Value.ToString();
                txtTenSach.Text = dgvCTPN.Rows[index].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
        void loadPN()
        {

            List<DTOPhieuNhap> CTPN = BUSPhieuNhap.GetCTPN();
            dgvCTPN.DataSource = CTPN;

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadPN();
        }

        void UpdateSoLuongTon()
        {
            // txtMaSach.Text = GetMaSach.getMaSach;
            Sach s = BUSDSSach.getThongTinSach(txtMaSach.Text);
            int sl = int.Parse(txtSLnhap.Text);
            BUSDSSach.UpdateSoLuongSach(txtMaSach.Text, sl, sl, 0);

        }
        public void UpdateTongTien()
        {
            //Sach s = BUSDSSach.getThongTinSach(txtMaSach.Text);
            PhieuNhap pn = BUSPhieuNhap.getThongTinPhieuNhap(txtMaPN.Text);
            if (isClicked)
            {
                TongTienNhap =0;
            }
            else
            {
                TongTienNhap = int.Parse(txtTongTien.Text);
            }
             BUSPhieuNhap.UpdateTongtien(txtMaPN.Text, TongTienNhap, txtMaSach.Text);
           
        }
    
         
        void UpdateSoLuongTon_Xoa_Sua()
        {
            // txtMaSach.Text = GetMaSach.getMaSach;
            int tn = 0;
           int tongban =0;
            int toncuoi = 0;
            Sach s = BUSDSSach.getThongTinSach(txtMaSach.Text);   
            tongban = int.Parse(s.TongBan.ToString());
            if (isClicked)
            {
                tn = 0;

            }
            else { tn = int.Parse(txtSLnhap.Text);
                toncuoi = tn - tongban;
            }
            BUSDSSach.UpdateSoLuongSach(txtMaSach.Text, toncuoi, tn, tongban);

        }
        //------------------------------------------------------------------
        void InsertCT()
        {
            if (txtMaPN.Text == "" || txtMaSach.Text == "" || txtDonGia.Text == "" || txtSLnhap.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (IsNumber(txtSLnhap.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }

            string mapn = txtMaPN.Text;
            string masach = txtMaSach.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSLnhap.Text);
            int tongtien = int.Parse(txtTongTien.Text);
            //Sach s = BUSDSSach.getThongTinSach(masach);
           // QuyDinh qd = QuyDinhBUS.GetQD();

            //if (s.TonCuoi > Int32.Parse(qd.TonNhapToiThieu))
            //{
            //    MessageBox.Show("Chỉ được nhập sách có số lượng tồn ít hơn " + qd.TonNhapToiThieu);
            //    return;
            //}
            if (soluong < SO_LUONG_NHAP_TOI_THIEU)
            {
                MessageBox.Show("Số lượng nhập tối thiểu là " + SO_LUONG_NHAP_TOI_THIEU);
                return;
            }
            if (BUSPhieuNhap.checkTrung(txtMaPN.Text, txtMaSach.Text) == false)
            {
                MessageBox.Show("Sách này đã có trong phiếu nhập");
                return;
            }
           BUSPhieuNhap.InsertPhieuNhap(mapn, masach, soluong, dongia, tongtien);
           UpdateSoLuongTon();
           UpdateTongTien();
            MessageBox.Show("Thêm sách vào phiếu nhập thành công!");
        }

        public void hienthimaSach()
        {

            txtMaSach.Text = GetMaSach.getMaSach;
            Sach s = BUSDSSach.getThongTinSach(txtMaSach.Text);
            txtTenSach.Text = s.TenSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            flag = 0;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtDonGia.Text != "" && txtSLnhap.Text != "")
            {
                int tongtien = int.Parse(txtSLnhap.Text) * int.Parse(txtDonGia.Text);
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void txtSLnhap_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSLnhap.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            if (txtDonGia.Text != "" && txtSLnhap.Text != "")
            {
                int tongtien = int.Parse(txtSLnhap.Text) * int.Parse(txtDonGia.Text);
                txtTongTien.Text = tongtien.ToString();
            }
        }

      

        private void btnMaSach_Click(object sender, EventArgs e)
        {
            frmDSSach frmS = new frmDSSach();
            frmS.SetButtonEnabled(true);
            frmS.ShowDialog();
            hienthimaSach();
        }
        //-----------------------------------------------------------
        void UpdatePhieuNhap()
        {

            if (txtMaPN.Text == "" || txtMaSach.Text == "" || txtDonGia.Text == "" || txtSLnhap.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (IsNumber(txtSLnhap.Text) == false)
            {
                MessageBox.Show("Số lượng phải là số và không được âm", "Thông báo");
                return;
            }
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }


            string mapn = txtMaPN.Text;
            string masach = txtMaSach.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int tongtien = int.Parse(txtTongTien.Text);          
            int soluong = int.Parse(txtSLnhap.Text);
            //Sach s = TimSachBUS.getThongTinSach(masach);
            //QuyDinh qd = QuyDinhBUS.GetQD();

            if (soluong < SO_LUONG_NHAP_TOI_THIEU)
            {
                MessageBox.Show("Số lượng nhập tối thiểu là " + SO_LUONG_NHAP_TOI_THIEU);
                return;
            }
            BUSPhieuNhap.UpdatePhieuNhap(mapn, masach, soluong, dongia, tongtien);
            // nếu tong ban bang không thì mới sửa lại so luong 
            UpdateSoLuongTon_Xoa_Sua();
            UpdateTongTien();
            MessageBox.Show("Cập nhật thông tin thành công!");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {    
            txtMaPN.ReadOnly = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            flag = 1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertCT();
                loadPN();
            }
            if (flag == 1)
            {
                UpdatePhieuNhap();
                loadPN();
            }
        }
   
        private void btnXoa_Click(object sender, EventArgs e)
        {
            isClicked = true;

            MessageBox.Show("Bạn có chắc muốn xoá sách này ra khỏi phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel);
            UpdateTongTien();
            UpdateSoLuongTon_Xoa_Sua();
            BUSPhieuNhap.DeleteCTPhieuNhap(txtMaPN.Text, txtMaSach.Text);
            MessageBox.Show("Xoá thành công!");
            loadPN();

           // isClicked = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                MessageBox.Show("Vui lòng lưu thông tin trước khi thoát.");
                return;
            }
            else this.Close();
        }
    }
}
