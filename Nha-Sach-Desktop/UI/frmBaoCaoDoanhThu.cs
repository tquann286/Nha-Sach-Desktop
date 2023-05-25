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
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietDoanhThu frmCTDoanhthu = new frmChiTietDoanhThu();
            this.Hide();
            frmCTDoanhthu.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadDSDoanhThu()
        {
            List<DTODoanhThu> dsDT = BUSDoanhThu.GetDSDoanhThu();
            dgvDSDT.DataSource = dsDT;
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDSDoanhThu();
        }
    }
}
