using Nha_Sach_Desktop.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAODoanhThu
    {
        public static List<DTODoanhThu> GetDSDT()
        {
            List<DTODoanhThu> DSDoanhThu = new List<DTODoanhThu>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.HoaDons select p;
                foreach (var row in query)
                {
                    DTODoanhThu dt = new DTODoanhThu();
                    //dt.Email = row.Email;
                    //dt.HoTen = row.HoTen;
                    //dt.DiaChi = row.DiaChi;
                    //dt.Sdt = row.Sdt;
                    DSDoanhThu.Add(dt);
                }
            }
            return DSDoanhThu;
        }
    }
}
