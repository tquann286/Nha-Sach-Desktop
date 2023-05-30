using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;

namespace Nha_Sach_Desktop.BUS
{
    public class BUSHoaDon
    {
        public static List<DTOHoaDon> GetDSHD()
        {
            return DAOHoaDon.GetDSHD();
        }
        public static void InsertHD(string mahd, string makh, string tenkh, DateTime ngaynhap, string masach, string tensach, int soluong, int tongtien)
        {
            DAOHoaDon.InsertHD(mahd, makh, tenkh, ngaynhap, masach, tensach, soluong, tongtien);
        }
        public static void DeleteHD(string mahd)
        {
            DAOHoaDon.DeleteHoaDon(mahd);
        }
        public static void UpdateHD(string mahd, string makh, string tenkh, DateTime ngaynhap, string masach, string tensach, int soluong, int tongtien)
        {
            DAOHoaDon.UpdateHD(mahd, makh, tenkh, ngaynhap, masach, tensach, soluong, tongtien);
        }
        public static void UpdateTongtien(string mahd, int soluong)
        {
            DAOHoaDon.UpdateTongtien(mahd, soluong);
        }
        public static HoaDon getThongTinHD(string mahd)
        {
            return DAOHoaDon.getThongTinHD(mahd);
        }
        public static List<DTOHoaDon> TimKiem(string ten)
        {
            return DAOHoaDon.TimKiem(ten);
        }
        public static bool checkTrung(string mahd)
        {
            return DAOHoaDon.checkTrung(mahd);
        }
        public static bool checkMaSach(string maSach)
        {
            return DAOHoaDon.checkMaSach(maSach);
        }
    }
}
