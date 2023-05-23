using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    public class DTOBaoCaoDoanhThu
    {
        private string thang;
        private int soluong;
        private int tongdoanhthu;

        public string Thang
        {
            get
            {
                return thang;
            }
            set { thang = value; }
        }
        public int Soluong
        {
            get
            {
                return soluong;
            }
            set { soluong = value; }
        }
        public int Tongdoanhthu
        {
            get
            {
                return tongdoanhthu;
            }
            set { tongdoanhthu = value; }
        }
    }
}
