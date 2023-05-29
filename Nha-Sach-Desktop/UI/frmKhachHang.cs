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
using static Nha_Sach_Desktop.UI.frmDSSach;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        int flag = -1;
        void LoadDSKhachHang()
        {
            List<DTOKhachHang> dsKH = BUSKhachHang.GetDSKhachHang();
            dgvDSKH.DataSource = dsKH;
            btnLuu.Enabled = false;
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
            dgvDSKH.DataSource = dsKH;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            timKiem(txtTimKiem.Text);
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvDSKH.CurrentRow.Index; //dòng chọn
                txtMaKH.Text = dgvDSKH.Rows[index].Cells[0].Value.ToString();
                txtSDT.Text = dgvDSKH.Rows[index].Cells[2].Value.ToString();//1
                txtEmail.Text = dgvDSKH.Rows[index].Cells[4].Value.ToString();
                txtTen.Text = dgvDSKH.Rows[index].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDSKH.Rows[index].Cells[3].Value.ToString();              
            }
            catch
            {

            }
        }
        void InsertKhachHang()
        {
            string makh = txtMaKH.Text;
            string hoten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            // string tongno = txtTongNo.Text;
            long checkSDT;
            try
            {
                checkSDT = Int64.Parse(txtSDT.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
           
            if (makh == "" || hoten == "" || diachi == "" || sdt == "" || email == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (BUSKhachHang.checkTrung(txtMaKH.Text) == false)
            {
                MessageBox.Show("Mã khách hàng không được trùng");
                return;
            }
            BUSKhachHang.InsertKhachHang(makh, hoten, sdt, diachi, email);
            MessageBox.Show("Thêm khách hàng thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;            
            flag = 0;
        }

        void ChangeKhachHang()
        {
            string makh = txtMaKH.Text;
            string hoten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            //string tongno = txtTongNo.Text;
            long checkSDT;
            try
            {
                checkSDT = Int64.Parse(txtSDT.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            

            if (makh == "" || hoten == "" || diachi == "" || sdt == "" || email == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            BUSKhachHang.ChangeKhachHang(makh, hoten, sdt, diachi, email);
            MessageBox.Show("Sửa thông tin khách hàng thành công!");

        }       

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            flag = 1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertKhachHang();
                LoadDSKhachHang();

            }
            if (flag == 1)
            {
                ChangeKhachHang();
                LoadDSKhachHang();

            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BUSKhachHang.DeleteKhachHang(txtMaKH.Text);
                MessageBox.Show("Xoá khách hàng thành công!");
                LoadDSKhachHang();

                txtMaKH.Text = "";
                txtTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
            }
           
        }
    }
}
