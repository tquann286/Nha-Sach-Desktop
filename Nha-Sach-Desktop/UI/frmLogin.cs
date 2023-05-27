using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public class GetTK
        {
            public static string getTK;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BUSLogin lg = new BUSLogin();
            DTOLogin acc = new DTOLogin();
            acc.taiKhoan = txtTaiKhoan.Text;
            acc.matKhau = txtMatKhau.Text;
            GetTK.getTK = txtTaiKhoan.Text;

            if (lg.BLLKTraTKhoan(acc) == true)
            {
                this.Hide();
                frmTrangChu frmTrangChu = new frmTrangChu();
                frmTrangChu.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                return;
            }
            txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
