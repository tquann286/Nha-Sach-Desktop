using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System.Collections.Generic;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSDoanhThu
    {
        public static List<DTODoanhThu> GetDSDoanhThu()
        {
            return DAODoanhThu.GetDSDT();
        }
    }
}
