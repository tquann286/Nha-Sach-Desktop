﻿using DemoDataGridView;
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
    public partial class frmChiTietDoanhThu : Form
    {
        private string thangNam;
        public frmChiTietDoanhThu(string _thangNam)
        {
            InitializeComponent();
            thangNam = _thangNam;
        }
        void LoadCTDT()
        {
            List<DTOChiTietDoanhThu> ctdt = BUSChiTietDoanhThu.GetCTDoanhThu(thangNam);
            dgvCTDT.DataSource = ctdt;
            lblThang.Text = "Tháng " + thangNam + ":";
        }

        private void frmChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            LoadCTDT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            excel.XuatExcel(dgvCTDT);
        }
    }
}
