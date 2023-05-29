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
        public static void InsertKhachHang(string makh, string hoten, string sdt, string diachi, string email)
        {
            DAOKhachHang.InsertKhachHang(makh, hoten, sdt, diachi, email);
        }
        public static void ChangeKhachHang(string makh, string hoten, string sdt, string diachi, string email)
        {
            DAOKhachHang.ChangeKhachHang(makh, hoten, sdt, diachi, email);
        }
        public static void DeleteKhachHang(string makh)
        {
            DAOKhachHang.DeleteKhachHang(makh);
        }
        public static bool checkTrung(string makh)
        {
            return DAOKhachHang.checkTrung(makh);
        }
    }
}
