using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DAO
{
    public class DAOBaoCaoDoanhThu
    {
        public static List<DTOBaoCaoDoanhThu> GetBCDT()
        {
            List<DTOBaoCaoDoanhThu> CTDT = new List<DTOBaoCaoDoanhThu>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.Saches select p;
                foreach (var row in query)
                {
                    DTOBaoCaoDoanhThu s = new DTOBaoCaoDoanhThu();
                    s.Masach = row.MaSach;
                    s.Tensach = row.TenSach;
                    s.Soluong = row.TongBan;
                    s.Dongia = row.DonGia;
                    s.Tongtien = row.DonGia * row.TongBan;
                    CTDT.Add(s);
                }
            }
            return CTDT;
        }
    }
}
