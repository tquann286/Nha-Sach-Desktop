using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.DAO
{
    class DAOHoaDon
    {
        public static bool InsertHoaDon(DTOHoaDon dTOHoaDon)
        {
            try
            {
                NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext();
                HOADON hd = new HOADON();
                hd.mahd = dTOHoaDon.Mahd;
                hd.makh = dTOHoaDon.Makh;
                hd.tenkh = dTOHoaDon.Tenkh;
                hd.tongtien = dTOHoaDon.Tongtien;
                dbMain.HOADONs.InsertOnSubmit(hd);

                PHIEUBAN pb = new PHIEUBAN();
                pb.maphieuban = dTOHoaDon.Mahd;
                pb.masach = dTOHoaDon.Makh;
                pb.soluong = dTOHoaDon.Soluong;
                dbMain.PHIEUBANs.InsertOnSubmit(pb);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
