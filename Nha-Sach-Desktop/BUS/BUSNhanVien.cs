using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System.Collections.Generic;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSNhanVien
    {
        public static List<DTONhanVien> GetDSNhanVien()
        {
            return DAONhanVien.GetDSNV();
        }

        public static List<DTONhanVien> TimDSNV(string strNV)
        {
            return DAONhanVien.TimNhanVien(strNV);
        }
    }
}
