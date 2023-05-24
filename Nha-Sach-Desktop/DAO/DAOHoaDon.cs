using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.DAO
{
    public class DAOHoaDon
    {
        public static List<DTOHoaDon> GetDSHD()
        {
            List<DTOHoaDon> DSHD = new List<DTOHoaDon>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.HoaDons select p;

                foreach (var row in query)
                {
                    DTOHoaDon hd = new DTOHoaDon();

                    hd.Mahd = row.MaHD;
                    hd.Makh = row.MaKH;
                    hd.Tenkh = row.TenKH;
                    hd.Tensach = row.TenSach;
                    hd.Masach = row.MaSach;
                    hd.Soluong = row.SoLuong.ToString();
                    hd.Ngaylap = row.NgayLap.ToString();
                    hd.Tongtien = row.TongTien.ToString();
                    DSHD.Add(hd);
                }
            }
            return DSHD;
        }
        public static void InsertHD(string mahd, string makh, string tenkh, DateTime ngaynhap, string masach, string tensach, int soluong, int tongtien)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaKH = makh;
                hd.TenKH = tenkh;
                hd.NgayLap = ngaynhap;
                hd.TongTien = tongtien;
                hd.MaSach = masach;
                hd.TenSach = tensach;
                hd.SoLuong = soluong;
                hd.TongTien = tongtien;
                dbMain.HoaDons.InsertOnSubmit(hd);
                dbMain.SubmitChanges();

            }
        }
        public static void UpdateHD(string mahd, string makh, string tenkh, DateTime ngaynhap, string masach, string tensach, int soluong, int tongtien)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {


                HoaDon hd = dbMain.HoaDons.SingleOrDefault(p => p.MaHD ==
                 mahd);
                hd.MaKH = makh;
                hd.TenKH = tenkh;
                hd.NgayLap = ngaynhap;
                hd.TongTien = tongtien;
                hd.MaSach = masach;
                hd.TenSach = tensach;
                hd.SoLuong = soluong;
                hd.TongTien = tongtien;

                dbMain.SubmitChanges();
            }
        }
        public static bool checkTrung(string mahd)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.HoaDons where p.MaHD == mahd select p;
                if (query.Count() > 0)
                    return false;
            }
            return true;
        }
        public static void DeleteHoaDon(string mahd)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                HoaDon hd = dbMain.HoaDons.SingleOrDefault(p => p.MaHD ==
                mahd);

                dbMain.HoaDons.DeleteOnSubmit(hd);
                dbMain.SubmitChanges();
            }
        }
        public static void UpdateTongtien(string mahd, int soluong)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                HoaDon hd = dbMain.HoaDons.SingleOrDefault(p => p.MaHD ==
                 mahd);
                hd.TongTien = soluong;
                dbMain.SubmitChanges();
            }
        }
        public static HoaDon getThongTinHD(string mahd)
        {
            HoaDon hd = new HoaDon();
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {

                var query = from p in dbMain.HoaDons where p.MaHD == mahd select p;
                foreach (var row in query)
                {
                    hd.TongTien = row.TongTien;

                }

            }
            return hd;
        }
        public static List<DTOHoaDon> TimKiem(string ten)
        {
            List<DTOHoaDon> ListKH = new List<DTOHoaDon>();
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from s in dbMain.HoaDons
                            where s.MaKH.Contains(ten) || s.TenKH.Contains(ten)//Chọn những thành viên nào có tên gần giống 
                            select s;
                foreach (var row in query)
                {
                    DTOHoaDon kh = new DTOHoaDon();

                    kh.Mahd = row.MaHD;
                    kh.Makh = row.MaKH;
                    kh.Tenkh = row.TenKH;
                    kh.Masach= row.MaSach;
                    kh.Tensach = row.TenSach;
                    kh.Soluong = row.SoLuong.ToString();
                    kh.Tongtien = row.TongTien.ToString();
                    kh.Ngaylap = row.NgayLap.ToString();

                    ListKH.Add(kh);
                }
            }
            return ListKH;
        }
    }
}
