using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    internal class DTODoanhThu
    {
        private string thang;
        private int doanhThu;

        public string Thang { get => thang; set => thang = value; }
        public int DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
