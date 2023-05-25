using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAODoanhThu
    {
        public static List<DTODoanhThu> GetDSDT()
        {
            List<DTODoanhThu> DSDoanhThu = new List<DTODoanhThu>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.HoaDons orderby p.NgayLap ascending select p;
                
                Dictionary<string, int> doanhThuTheoThang = new Dictionary<string, int>();

                // Duyệt qua danh sách DTODoanhThu và tính tổng số tiền theo tháng
                foreach (var doanhThu in query)
                {
                    string thangNam = doanhThu.NgayLap.ToString("MM/yyyy"); 
                    if (doanhThuTheoThang.ContainsKey(thangNam))
                    {
                        doanhThuTheoThang[thangNam] += (int)doanhThu.TongTien;
                    }
                    else
                    {
                        doanhThuTheoThang[thangNam] = (int)doanhThu.TongTien;
                    }
                }

                List<string> uniqueMonths = new List<string>();
                foreach (var item in query)
                {
                    string monthYear = item.NgayLap.ToString("MM/yyyy");
                    if (!uniqueMonths.Contains(monthYear))
                    {
                        uniqueMonths.Add(monthYear);
                    }
                }

                foreach (var month in doanhThuTheoThang)
                {
                    DTODoanhThu dt = new DTODoanhThu();
                    dt.Thang = month.Key;
                    dt.DoanhThu = month.Value;

                    DSDoanhThu.Add(dt);
                }
            }
            return DSDoanhThu;
        }
    }
}
