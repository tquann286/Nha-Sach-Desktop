using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTONhanVien
    {
        private string email;
        private string hoTen;
        private string diaChi;
        private string sdt;
        private string password;

        public string Email { get => email; set => email = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Password { get => password; set => password = value; }
    }
}
