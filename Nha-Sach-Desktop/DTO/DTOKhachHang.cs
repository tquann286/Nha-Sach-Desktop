using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTOKhachHang
    {
        private string email;
        private string hoten;
        private string diachi;
        private string sdt;
        private int doanhthu;
        private string MaKH;

        public string Email { get => email; set => email = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaKhachHang { get => MaKH; set => MaKH = value; }
        public int DoanhThu { get => doanhthu; set => doanhthu = value;}
    }
}
