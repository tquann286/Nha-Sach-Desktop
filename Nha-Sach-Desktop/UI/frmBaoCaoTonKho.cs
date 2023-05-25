using DemoDataGridView;
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
    public partial class frmBaoCaoTonKho : Form
    {
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }
        void LoadBCTonKho()
        {
            List<DTOTonKho> dsTK = BUSTonKho.GetDSTonKho();
            dgvBaoCaoTon.DataSource = dsTK;
        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            LoadBCTonKho();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            ExportToExcel excel = new ExportToExcel();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                excel.ToExcel(dgvBaoCaoTon, saveFileDialog.FileName);
            }
        }
    }
}
