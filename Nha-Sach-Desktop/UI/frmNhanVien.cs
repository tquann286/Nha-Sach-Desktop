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

        }
    }
}
