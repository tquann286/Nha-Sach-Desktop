using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    public class DTOHoaDon
    {
        private string maHD;
        private string maKH;
        private string tenKH;
        private string maSach;
        private string tenSach;
        private string soLuong;
        private string tongTien;
        private string ngayLap;


        public string Mahd
        {
            get
            {
                return maHD;
            }

            set
            {
                maHD = value;
            }
        }

        public string Makh
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }
        public string Tenkh
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }
        public string Masach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string Tensach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public string Soluong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string Tongtien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public string Ngaylap { get => ngayLap; set => ngayLap = value; }
    }
}
