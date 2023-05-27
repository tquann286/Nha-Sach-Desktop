using Nha_Sach_Desktop.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nha_Sach_Desktop.UI.frmLogin;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
           // txtMKcu.Focus();
            txtUser.Text = GetTK.getTK;
        }
        void ChangeMatKhau()
        {

            string user = txtUser.Text;
            string mkcu = txtMKcu.Text;
            string mkmoi = txtMKmoi.Text;
            string mkremoi = txtReMKmoi.Text;
            if (user == "" || mkcu == "" || mkmoi == "" || mkremoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (mkmoi != mkremoi)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                BUSLogin.ChangeMK(user, mkcu, mkmoi);
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            ChangeMatKhau();
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMKcu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtReMKmoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKcu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtReMKmoi.UseSystemPasswordChar = true;
            }
        }
       
    }
}
