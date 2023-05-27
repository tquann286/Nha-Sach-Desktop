using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DTO
{
    public class DTOChiTietDoanhThu
    {
        private string tenKH;
        private string tenSach;
        private int soLuong;
        private int tongTien;

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
