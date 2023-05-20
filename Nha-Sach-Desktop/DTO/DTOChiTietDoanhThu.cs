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
        private string masach;
        private string tensach;
        private int soluong;
        private int dongia;
        private int tongtien;
        
        public string Masach
        {
            get
            {
                return masach; 
            }
            set { masach = value;}
        }
        public string Tensach
        {
            get
            {
                return tensach;
            }
            set
            {
                tensach = value;
            }
        }
        public int Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public int Dongia
        {
            get
            {
                return dongia;
            }
            set { dongia = value; }
        }
        public int Tongtien
        {
            get
            {
                return tongtien;
            }

            set { tongtien = value; }
        }
    }
}
