using System;
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
using System.Reflection;


namespace Nha_Sach_Desktop.UI
{
    public partial class frmDSSach : Form
    {
        public frmDSSach()
        {
            InitializeComponent();
            

        }
        int flag = -1;
        public class GetMaSach
        {
            public static string getMaSach;
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
        void LoadDSSach()
        {

            List<DTODSSach> dsSach = BUSDSSach.GetDsSach();

            dgvKetQua.DataSource = dsSach;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            //  btnLuu.Enabled = false;

        }
        private void LocDSSach(string timKiem, string theLoai)
        {
            List<DTODSSach> dsSach = BUSDSSach.LocDSSach(timKiem, theLoai);

            dgvKetQua.DataSource = dsSach;
        }
        private void frmDSSach_Load(object sender, EventArgs e)
        {
            // Lấy danh sách sách từ cơ sở dữ liệu
            var data = DAODSSach.GetDSSach();

            // Chuyển đổi kiểu dữ liệu sang List<Sach>
            List<Sach> danhSachSach = data.Select(item => new Sach { TheLoai = item.TheLoai }).Distinct().ToList();

            Sach externalSach = new Sach { TheLoai = "Tất cả" };
          
            danhSachSach.Insert(0, externalSach);
          

            cbTimTheLoai.DataSource = danhSachSach;


            cbTimTheLoai.DisplayMember = "TheLoai";

            cbTimTheLoai.SelectedIndex = 0;

            LoadDSSach();

        }

        private void dgvKetQua_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = dgvKetQua.CurrentRow.Index; //dòng chọn
                txtMaSach.Text = dgvKetQua.Rows[index].Cells[0].Value.ToString();
                txtTenSach.Text = dgvKetQua.Rows[index].Cells[1].Value.ToString();//1
                txtTheLoai.Text = dgvKetQua.Rows[index].Cells[2].Value.ToString();
                txtTacGia.Text = dgvKetQua.Rows[index].Cells[3].Value.ToString();
                txtDonGia.Text = dgvKetQua.Rows[index].Cells[4].Value.ToString();
                txtMaSach.Enabled = false;
            }
            catch
            {

            }
        }
        void InsertSach()
        {
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            string theloai = txtTheLoai.Text;
            string tacgia = txtTacGia.Text;
            int dongia = txtDonGia.Text == "" ? 0 : int.Parse(txtDonGia.Text);

            if (masach == "" || tensach == "" || theloai == "" || tacgia == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (BUSDSSach.checkTrung(txtMaSach.Text) == false)
            {
                MessageBox.Show("Mã sách không được trùng");
                return;
            }
            BUSDSSach.InsertSach(masach, tensach, theloai, tacgia, dongia);
            MessageBox.Show("Thêm sách thành công!");

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtLuongton.Text = "0";
            flag = 0;
        }
        void ChangeSach()
        {
            if (IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Đơn giá phải là số và không được âm", "Thông báo");
                return;
            }
            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            string theloai = txtTheLoai.Text;
            string tacgia = txtTacGia.Text;
            int dongia = txtDonGia.Text == "" ? 0 : int.Parse(txtDonGia.Text);

            if (masach == "" || tensach == "" || theloai == "" || tacgia == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            BUSDSSach.ChangeSach(masach, tensach, theloai, tacgia, dongia);
            MessageBox.Show("Sửa thông tin sách thành công!");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá sách này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BUSDSSach.DeleteSach(txtMaSach.Text);
                MessageBox.Show("Xoá sách thành công!");
                LoadDSSach();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                InsertSach();
                LoadDSSach();

            }
            else if (flag == 1)
            {
                ChangeSach();
                LoadDSSach();
                txtMaSach.Enabled = true;
            }
            var data = DAODSSach.GetDSSach();

            Sach externalSach = new Sach { TheLoai = "Tất cả" };

            cbTimTheLoai.DataSource = data;
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
            txtTacGia.Text = "";
            txtDonGia.Text = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LocDSSach(txtTimKiem.Text, cbTimTheLoai.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            int index = dgvKetQua.CurrentRow.Index;
            GetMaSach.getMaSach = dgvKetQua.Rows[index].Cells[1].Value.ToString();

            this.Close();
        }
    }
}
