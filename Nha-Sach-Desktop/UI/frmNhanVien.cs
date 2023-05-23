using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadDSNhanVien()
        {
            List<DTONhanVien> dsNV = BUSNhanVien.GetDSNhanVien();
            dgvDSNV.DataSource = dsNV;
            btnLuuNhanVien.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDSNhanVien();
        }
        private void timKiem(string strNhanVien)
        {
            List<DTONhanVien> dsNV = BUSNhanVien.TimDSNV(strNhanVien);
            dgvDSNV.DataSource = dsNV;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            timKiem(txtTenNV.Text);
        }
        void InsertNhanVien()
        {
            string email = txtEmailNV.Text;
            string hoten = txtHoTenNV.Text;
            string diachi = txtDiaChiNV.Text;
            string sdt = txtSDTNV.Text;
            string password = txtMatKhau.Text;
            long check;
            try
            {
                check = Int64.Parse(txtSDTNV.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            if (email == "" || hoten == "" || diachi == "" || sdt == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin.");
                return;
            }
            if (BUSNhanVien.checkEmailExist(txtEmailNV.Text) == false)
            {
                MessageBox.Show("Email đã được sử dụng", "Thông báo");
                return;
            }
            BUSNhanVien.InsertNhanVien(email, hoten, diachi, sdt, password);
            ResetForm();
            LoadDSNhanVien();
            MessageBox.Show("Thêm nhân viên thành công");

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertNhanVien();
        }
        private void ResetForm()
        {
            txtEmailNV.Text = "";
            txtHoTenNV.Text = "";
            txtDiaChiNV.Text = "";
            txtSDTNV.Text = "";
            txtMatKhau.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUSNhanVien.DeleteNhanVien(txtEmailNV.Text);
            LoadDSNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = BUSNhanVien.FillNhanVien(txtEmailNV.Text);
            
            if (nv != null)
            {
                txtEmailNV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMatKhau.Enabled = false;
                btnLuuNhanVien.Enabled = true;
                FillNhanVien(nv);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên cần sửa", "Thông báo");
            }
        }
        private void FillNhanVien(NhanVien nv)
        {
            txtHoTenNV.Text = nv.HoTen;
            txtDiaChiNV.Text = nv.DiaChi;
            txtSDTNV.Text = nv.Sdt;
        }
        private void btnLuuNhanVien_Click(object sender, EventArgs e)
        {
            UpdateNhanVien();
            LoadDSNhanVien();
            ResetForm();
            txtEmailNV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMatKhau.Enabled = true;
            btnLuuNhanVien.Enabled = false;
        }
        private void UpdateNhanVien()
        {
            string email = txtEmailNV.Text;
            string hoten = txtHoTenNV.Text;
            string diachi = txtDiaChiNV.Text;
            string sdt = txtSDTNV.Text;
            long check;
            try
            {
                check = Int64.Parse(txtSDTNV.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            if (email == "" || hoten == "" || diachi == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin.");
                return;
            }
            BUSNhanVien.UpdateNhanVien(email, hoten, diachi, sdt);
        }
    }
}
