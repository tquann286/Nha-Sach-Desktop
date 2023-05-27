using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSKhachHang
    {
        public static List<DTOKhachHang> GetDSKhachHang()
        {
            return DAOKhachHang.GetDSKH();
        }
        public static List<DTOKhachHang> TimDSKH(string strKH)
        {
            return DAOKhachHang.TimKhachHang(strKH);
        }
    }
}
