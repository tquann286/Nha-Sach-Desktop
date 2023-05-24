using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTOPhieuNhap
    {
        private string mapn;
        private string masachnhap;
        private string soluongnhap;
        private string dongianhap;
        private int tongtien;
        private string tensach;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Masachnhap { get => masachnhap; set => masachnhap = value; }
        public string Soluongnhap { get => soluongnhap; set => soluongnhap = value; }
        public string Dongianhap { get => dongianhap; set => dongianhap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Tensach { get => tensach; set => tensach = value; }
    }
}
