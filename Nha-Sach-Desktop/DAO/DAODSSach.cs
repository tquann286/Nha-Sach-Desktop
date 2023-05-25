﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAODSSach
    {
        public static List<DTODSSach> GetDSSach()
        {
            List<DTODSSach> DsSach = new List<DTODSSach>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.Saches select p;

                foreach (var row in query)
                {
                    DTODSSach sach = new DTODSSach();

                    sach.MaSach = row.MaSach;
                    sach.TenSach = row.TenSach;
                    sach.TheLoai = row.TheLoai;
                    sach.TacGia = row.TacGia;
                    sach.DonGia = row.DonGia.ToString();
                    sach.Luongton = row.TonCuoi.ToString();
                    DsSach.Add(sach);
                }
            }
            return DsSach;
        }
        public static List<DTODSSach> LocDSSach(string timKiem, string _theLoai)
        {
            List<DTODSSach> DsSach = new List<DTODSSach>();
            string theLoai = _theLoai == "Tất cả" ? "" : _theLoai;

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var sachs = from p in dbMain.Saches where (p.TacGia.Contains(timKiem) || p.TenSach.Contains(timKiem)) && p.TheLoai.Contains(timKiem) select p;
                foreach (var row in sachs)
                {
                    DTODSSach sach = new DTODSSach();

                    sach.MaSach = row.MaSach;
                    sach.TenSach = row.TenSach;
                    sach.TheLoai = row.TheLoai;
                    sach.TacGia = row.TacGia;
                    sach.DonGia = row.DonGia.ToString();
                    sach.Luongton = row.TonCuoi.ToString();
                    DsSach.Add(sach);
                }
            }
            return DsSach;
        }
        public static List<DTODSSach> GetSachLikeTheLoai(string strLoai)
        {
            List<DTODSSach> DsSachTTL = new List<DTODSSach>();
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var tk = from p in dbMain.Saches where p.TheLoai.Contains(strLoai) select p;
                foreach (var row in tk)
                {
                    DTODSSach sach = new DTODSSach();

                    sach.MaSach = row.MaSach;
                    sach.TenSach = row.TenSach;
                    sach.TheLoai = row.TheLoai;
                    sach.TacGia = row.TacGia;
                    sach.DonGia = row.DonGia.ToString();
                    DsSachTTL.Add(sach);
                }
            }
            return DsSachTTL;
        }
        public static Sach getThongTinSach(string masach)
        {
            Sach s = new Sach();
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {

                var query = from p in dbMain.Saches where p.MaSach == masach select p;
                foreach (var row in query)
                {
                    s.TenSach = row.TenSach;
                    s.DonGia = row.DonGia;
                    s.TonCuoi = row.TonCuoi;
                    s.TonDau = row.TonDau;
                    s.TongBan = row.TongBan;
                    s.TongNhap = row.TongNhap;
                }

            }
            return s;
        }
        public static void UpdateSoLuongSach(string masach, int toncuoi, int tongnhap, int tongban)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                Sach s = dbMain.Saches.SingleOrDefault(p => p.MaSach ==
                 masach);
                s.TonCuoi = toncuoi;              
                s.TongNhap = tongnhap;
                s.TongBan = tongban;
                // s.PhatSinh = phatsinh;
                dbMain.SubmitChanges();
            }
        }
        public static void InsertSach(string masach, string tensach, string theloai, string tacgia, int dongia)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                Sach s = new Sach();
                s.MaSach = masach;
                s.TenSach = tensach;
                s.TheLoai = theloai;
                s.TacGia = tacgia;
                s.DonGia = dongia;
                s.TonDau = 0;
                s.TongBan = 0;
                s.TongNhap = 0;
                s.TonCuoi = 0;
                //  s.TonCuoi = luongton;
                dbMain.Saches.InsertOnSubmit(s);
                dbMain.SubmitChanges();

            }

        }
        public static void ChangeSach(string masach, string tensach, string theloai, string tacgia, int dongia)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {


                Sach s = dbMain.Saches.SingleOrDefault(p => p.MaSach ==
                 masach);
                s.MaSach = masach;
                s.TenSach = tensach;
                s.TheLoai = theloai;
                s.TacGia = tacgia;
                s.DonGia = dongia;
               //  s.TonCuoi = luongton;
                dbMain.SubmitChanges();



            }
        }
        public static void DeleteSach(string masach)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                Sach s = dbMain.Saches.SingleOrDefault(p => p.MaSach ==
                masach);

                dbMain.Saches.DeleteOnSubmit(s);
                dbMain.SubmitChanges();


            }
        }
        public static bool checkTrung(string masach)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.Saches where p.MaSach == masach select p;
                if (query.Count() > 0)
                    return false;
            }
            return true;
        }
    }
}
