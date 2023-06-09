﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;
using Nha_Sach_Desktop.DAO;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSDSSach
    {
        public static List<DTODSSach> GetDsSach()
        {
            return DAODSSach.GetDSSach();
        }
        public static List<DTODSSach> LocDSSach(string timKiem, string theLoai)
        {
            return DAODSSach.LocDSSach(timKiem, theLoai);
        }
        public static Sach getThongTinSach(string masach)
        {
            return DAODSSach.getThongTinSach(masach);
        }
        public static void UpdateSoLuongSach(string masach, int toncuoi, int tongnhap, int tongban)
        {
            DAODSSach.UpdateSoLuongSach(masach, toncuoi, tongnhap, tongban);
        }
        public static void InsertSach(string masach, string tensach, string theloai, string tacgia, int dongia)
        {
            DAODSSach.InsertSach(masach, tensach, theloai, tacgia, dongia);
        }
        public static void ChangeSach(string masach, string tensach, string theloai, string tacgia, int dongia)
        {
            DAODSSach.ChangeSach(masach, tensach, theloai, tacgia, dongia);
        }
        public static void DeleteSach(string masach)
        {
            DAODSSach.DeleteSach(masach);
        }
        public static bool checkTrung(string masach)
        {
            return DAODSSach.checkTrung(masach);
        }
       
    }
}
