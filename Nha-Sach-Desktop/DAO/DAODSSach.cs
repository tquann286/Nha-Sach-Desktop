using System;
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
                var query = from p in dbMain.SACHes select p;

                foreach (var row in query)
                {
                    DTODSSach sach = new DTODSSach();

                    sach.MaSach = row.masach;
                    sach.TenSach = row.tensach;
                    sach.TheLoai = row.theloai;
                    sach.TacGia = row.tacgia;
                    sach.DonGia = row.dongia.ToString("###,###,###' 'VNĐ");
                    sach.Luongton = row.toncuoi.ToString();
                    DsSach.Add(sach);
                }
            }
            return DsSach;
        }
    }
}
