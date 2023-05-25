using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTOTonKho
    {
        private string maSach;
        private string tenSach;
        private int tonDau;
        private int tongNhap;
        private int tongBan;
        private int tonCuoi;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int TonDau { get => tonDau; set => tonDau = value; }
        public int TongNhap { get => tongNhap; set => tongNhap = value; }
        public int TongBan { get => tongBan; set => tongBan = value; }
        public int TonCuoi { get => tonCuoi; set => tonCuoi = value; }
    }
}
