using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nha_Sach_Desktop.DAO
{
    internal class DAOPhieuNhap
    {
        public static List<DTOPhieuNhap> GetCTPN()
        {
            List<DTOPhieuNhap> PN = new List<DTOPhieuNhap>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.PhieuNhaps select p;

                foreach (var row in query)
                {
                    DTOPhieuNhap ctpn = new DTOPhieuNhap();
                    ctpn.Mapn = row.MaPhieuNhap;
                    ctpn.Masachnhap = row.MaSach;
                    var getSach = from d in dbMain.Saches where d.MaSach == row.MaSach select d;
                    foreach (var row3 in getSach)
                    {
                        ctpn.Tensach = row3.TenSach;
                    }
                    ctpn.Soluongnhap = row.SoLuong.ToString();
                    ctpn.Dongianhap = row.DonGia.ToString();
                    ctpn.Tongtien = (int)row.TongTien;
                    PN.Add(ctpn);
                }
            }
            return PN;
        }
        public static PhieuNhap getThongTinPhieuNhap(string mapn)
        {
            PhieuNhap pn = new PhieuNhap();
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {

                var query = from p in dbMain.PhieuNhaps where p.MaPhieuNhap == mapn select p;
                foreach (var row in query)
                {
                    pn.TongTien = row.TongTien;

                }

            }   
            return pn;
        }
        public static void UpdateTongtien(string mapn, int tongTien, string masach)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {

                PhieuNhap pn = dbMain.PhieuNhaps
                     .Where(p => p.MaPhieuNhap == mapn && p.MaSach == masach)
                     .Select(p => p)
                     .FirstOrDefault();
                pn.TongTien = tongTien;
                dbMain.SubmitChanges();
            }
        }
        public static void InsertPhieuNhap(string mapn, string masach, int soluong, int dongia, int tongtien)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = mapn;
                pn.MaSach = masach;
                pn.SoLuong = soluong;
                pn.DonGia = dongia;
                pn.TongTien = tongtien;
                dbMain.PhieuNhaps.InsertOnSubmit(pn);
                dbMain.SubmitChanges();

            }
        }

        public static void UpdatePhieuNhap(string mapn, string masach, int soluong, int dongia, int tongtien)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from h in dbMain.PhieuNhaps where h.MaPhieuNhap == mapn && h.MaSach == masach select h;

                PhieuNhap ctpn = query.SingleOrDefault();
                // ctpn.MaPhieuNhap = mapn;
                // ctpn.MaSach = masach;
                ctpn.SoLuong = soluong;
                ctpn.DonGia = dongia;
                ctpn.TongTien = tongtien;
                dbMain.SubmitChanges();
            }
        }
        public static void DeleteCTPhieuNhap(string mapn, string masach)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {

                var query = from h in dbMain.PhieuNhaps where h.MaPhieuNhap == mapn && h.MaSach == masach select h;
                //ChiTietPhieuNhap ctpn = dbMain.ChiTietPhieuNhaps.SingleOrDefault(p => p.MaPhieuNhap ==
                //mapn and p=> p.MaSach == masach);
                PhieuNhap ctpn = query.SingleOrDefault();
                dbMain.PhieuNhaps.DeleteOnSubmit(ctpn);
                dbMain.SubmitChanges();


            }
        }
        public static bool checkTrung(string mapn, string masach)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from h in dbMain.PhieuNhaps where h.MaPhieuNhap == mapn || h.MaSach == masach select h;
                if (query.Count() > 0)
                    return false;
            }
            return true;
        }
    }
}
