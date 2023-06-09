﻿using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nha_Sach_Desktop.DAO;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSPhieuNhap
    {
        public static List<DTOPhieuNhap> GetDSPN()
        {
            return DAOPhieuNhap.GetPN();
        }
        public static PhieuNhap getThongTinPhieuNhap(string mapn)
        {
            return DAOPhieuNhap.getThongTinPhieuNhap(mapn);
        }
        public static void UpdateTongtien(string mapn, int tongTien, string masach)
        {
            DAOPhieuNhap.UpdateTongtien(mapn, tongTien, masach);
        }
        public static void InsertCTPhieuNhap(string mapn, string masach, int soluong, int dongia, int tongtien)
        {
            DAOPhieuNhap.InsertPhieuNhap(mapn, masach, soluong, dongia, tongtien);
        }

        public static void UpdatePhieuNhap(string mapn, string masach, int soluong, int dongia, int tongtien)
        {
            DAOPhieuNhap.UpdatePhieuNhap(mapn, masach, soluong, dongia, tongtien);
        }
        public static void DeleteCTPhieuNhap(string mapn, string masach)
        {
            DAOPhieuNhap.DeleteCTPhieuNhap(mapn, masach);
        }

        public static bool checkTrung(string mapn, string masach)
        {
            return DAOPhieuNhap.checkTrung(mapn, masach);
        }
    }
}
