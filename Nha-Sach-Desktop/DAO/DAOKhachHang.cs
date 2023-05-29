using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAOKhachHang
    {
        public static List<DTOKhachHang> GetDSKH()
        {
            List<DTOKhachHang> DSKhachHang = new List<DTOKhachHang>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.KhachHangs select p;
                foreach (var row in query)
                {
                    DTOKhachHang nv = new DTOKhachHang();
                    nv.MaKH = row.MaKH;
                    nv.Hoten = row.HoTen;
                    nv.Sdt = row.Sdt;
                    nv.Diachi = row.DiaChi;
                    nv.Email = row.Email;
                    DSKhachHang.Add(nv);
                }
            }
            return DSKhachHang;
        }
        public static List<DTOKhachHang> TimKhachHang(string strKH)
        {
            List<DTOKhachHang> DSKhachHang = new List<DTOKhachHang>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.KhachHangs where p.MaKH.Contains(strKH) || p.HoTen.Contains(strKH) select p;
                foreach (var row in query)
                {
                    DTOKhachHang nv = new DTOKhachHang();
                    nv.MaKH = row.MaKH;
                    nv.Hoten = row.HoTen;
                    nv.Sdt = row.Sdt;
                    nv.Diachi = row.DiaChi;
                    nv.Email = row.Email;
                    DSKhachHang.Add(nv);
                }
            }
            return DSKhachHang;
        
        }
        public static void InsertKhachHang(string makh, string hoten, string sdt, string diachi, string email)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = makh;
                kh.HoTen = hoten;
                kh.Sdt = sdt;
                kh.DiaChi = diachi;
                kh.Email = email;             

                dbMain.KhachHangs.InsertOnSubmit(kh);
                dbMain.SubmitChanges();

            }
        }
       
        public static void ChangeKhachHang(string makh, string hoten, string sdt, string diachi, string email)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                KhachHang kh = dbMain.KhachHangs.SingleOrDefault(p => p.MaKH ==
               makh);
                kh.MaKH = makh;
                kh.HoTen = hoten;
                kh.Sdt = sdt;
                kh.DiaChi = diachi;
                kh.Email = email;
                dbMain.SubmitChanges();
            }
        }
        public static void DeleteKhachHang(string makh)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                KhachHang kh = dbMain.KhachHangs.SingleOrDefault(p => p.MaKH ==
                makh);

                dbMain.KhachHangs.DeleteOnSubmit(kh);
                dbMain.SubmitChanges();


            }
        }
        public static bool checkTrung(string makh)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.KhachHangs where p.MaKH == makh select p;
                if (query.Count() > 0)
                    return false;
            }
            return true;
        }
    }
}
