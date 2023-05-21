using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    public class DTOHoaDon
    {
        private string mahd;
        private string makh;
        private string tenkh;
        private string masach;
        private string tensach;
        private string dongia;
        private int soluong;
        private int tongtien;

        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
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

        public string Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
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
        public string Mahd
        {
            get
            {
                return mahd;
            }

            set
            {
                mahd = value;
            }
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }
        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }
        public int Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }
    }
}
