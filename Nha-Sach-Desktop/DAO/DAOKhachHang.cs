using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
                    nv.MaKhachHang = row.MaKH;
                    nv.HoTen = row.HoTen;
                    nv.Sdt = row.Sdt;
                    nv.DiaChi = row.DiaChi;
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
                    nv.MaKhachHang = row.MaKH;
                    nv.HoTen = row.HoTen;
                    nv.Sdt = row.Sdt;
                    nv.DiaChi = row.DiaChi;
                    nv.Email = row.Email;
                    DSKhachHang.Add(nv);
                }
            }
            return DSKhachHang;
        }
    }
}
