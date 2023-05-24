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
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells[0].Value = i + 1;
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            //  btnLuu.Enabled = false;

        }
        /*public class GetMaSach
        {
            public static string getMaSach;
        }*/
        void LoadDsSachTTL(string theLoai)
        {


            List<DTODSSach> dsSachTTL = BUSDSSach.GetDSSachTheoTheLoai(theLoai);

            dgvKetQua.DataSource = dsSachTTL;
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells[0].Value = i + 1;
            }


        }
        void LoadDsSachTTG(string tacGia)
        {


            List<DTODSSach> dsSachTTG = BUSDSSach.GetDSSachTheoTacGia(tacGia);

            dgvKetQua.DataSource = dsSachTTG;
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells[0].Value = i + 1;
            }


        }
        void LoadDsSachTTS(string tenSach)
        {


            List<DTODSSach> dsSachTTG = BUSDSSach.GetDSSachTheoTenSach(tenSach);

            dgvKetQua.DataSource = dsSachTTG;
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells[0].Value = i + 1;
            }


        }
        private void frmDSSach_Load(object sender, EventArgs e)
        {
            cbTimTheLoai.DataSource = DAODSSach.GetDSSach();
            cbTimTheLoai.DisplayMember = "TheLoai";
            // cbTimTheLoai.ValueMember = "MaSach";
            cbTimTheLoai.SelectedIndex = 0;

            LoadDSSach();
        }

        private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theloai = cbTimTheLoai.Text.ToString();
            LoadDsSachTTL(theloai);
        }

        private void radTenSach_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenSach.Checked == true)
            {
                string tenSach = txtTimKiem.Text;
                LoadDsSachTTS(tenSach);
            }
        }

        private void radTacGia_CheckedChanged(object sender, EventArgs e)
        {
            if (radTacGia.Checked == true)
            {
                string TacGia = txtTimKiem.Text;

                LoadDsSachTTG(TacGia);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radTenSach.Checked == true)
            {
                string tenSach = txtTimKiem.Text;
                LoadDsSachTTS(tenSach);
            }
            if (radTacGia.Checked == true)
            {
                string TacGia = txtTimKiem.Text;

                LoadDsSachTTG(TacGia);
            }
            if (radTatCa.Checked == true)
                LoadDSSach();
        }

     

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvKetQua.CurrentRow.Index; //dòng chọn
                txtMaSach.Text = dgvKetQua.Rows[index].Cells[1].Value.ToString();
                txtTenSach.Text = dgvKetQua.Rows[index].Cells[2].Value.ToString();//1
                txtTheLoai.Text = dgvKetQua.Rows[index].Cells[3].Value.ToString();
                txtTacGia.Text = dgvKetQua.Rows[index].Cells[4].Value.ToString();
                txtDonGia.Text = dgvKetQua.Rows[index].Cells[5].Value.ToString();
                txtLuongton.Text = dgvKetQua.Rows[index].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }
        void InsertSach()
        {
            if (IsNumber(txtLuongton.Text) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số và không được âm", "Thông báo");
                return;
            }
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
           // int luongton = txtLuongton.Text == "" ? 0 : int.Parse(txtLuongton.Text);

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
            if (IsNumber(txtLuongton.Text) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số và không được âm", "Thông báo");
                return;
            }
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
           // int luongton = txtLuongton.Text == "" ? 0 : int.Parse(txtLuongton.Text);

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
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDSSach();
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
