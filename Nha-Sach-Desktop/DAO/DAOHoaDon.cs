using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.DAO
{
    public class DAOHoaDon
    {
        public bool InsertHoaDon(DTOHoaDon dTOHoaDon)
        {
            try
            {
                NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext();
                HOADON hd = new HOADON();
                hd.mahd = dTOHoaDon.Mahd;
                hd.makh = dTOHoaDon.Makh;
                hd.tenkh = dTOHoaDon.Tenkh;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
