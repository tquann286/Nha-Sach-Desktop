using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTODSSach
    {
        private string maSach;
        private string tenSach;
        private string theLoai;
        private string tacGia;
        private string donGia;
        private string luongton;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string Luongton { get => luongton; set => luongton = value; }
    }
}
