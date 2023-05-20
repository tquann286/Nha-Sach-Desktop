using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DAO
{
    public class DAOChiTietDoanhThu
    {
        public static List<DTOChiTietDoanhThu> GetCTDT()
        {
            List<DTOChiTietDoanhThu> CTDT = new List<DTOChiTietDoanhThu>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.SACHes select p;
                foreach (var row in query)
                {
                    DTOChiTietDoanhThu s = new DTOChiTietDoanhThu();
                    s.Masach = row.masach;
                    s.Tensach = row.tensach;
                    s.Soluong = row.tongban;
                    s.Dongia = row.dongia;
                    s.Tongtien = row.dongia * row.tongban;
                    CTDT.Add(s);
                }
            }
            return CTDT;
        }

    }
}
