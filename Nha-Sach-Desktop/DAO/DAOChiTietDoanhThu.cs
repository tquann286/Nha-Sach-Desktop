using Nha_Sach_Desktop.DTO;
using Nha_Sach_Desktop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DAO
{
    public class DAOChiTietDoanhThu
    {
        public static List<DTOChiTietDoanhThu> GetCTDT(string thangNam)
        {
            if (!IsValidMonthYearFormat(thangNam))
            {
                MessageBox.Show("Thời gian không hợp lệ.", "Thông báo");
                return null;
            }

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                int month = GetMonthFromThangNam(thangNam);
                int year = GetYearFromThangNam(thangNam);

                var query = from p in dbMain.HoaDons
                            where p.NgayLap.Month == month && p.NgayLap.Year == year
                            select new DTOChiTietDoanhThu
                            {
                                TenKH = p.TenKH,
                                TenSach = p.TenSach,
                                SoLuong = (int)p.SoLuong,
                                TongTien = (int)p.TongTien
                            };

                return query.ToList();
            }
        }

        private static bool IsValidMonthYearFormat(string thangNam)
        {
            return DateTime.TryParseExact(thangNam, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _);
        }

        private static int GetMonthFromThangNam(string thangNam)
        {
            return int.Parse(thangNam.Substring(0, 2));
        }

        private static int GetYearFromThangNam(string thangNam)
        {
            return int.Parse(thangNam.Substring(3, 4));
        }
    }
}