using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTOKhachHang
    {
        private string MaKh;
        private string hoten;
        private string sdt;
        private string diachi;
        private string email;

        public string MaKH { get => MaKh; set => MaKh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        // private int doanhthu;


        // public int DoanhThu { get => doanhthu; set => doanhthu = value; }
    }
}
