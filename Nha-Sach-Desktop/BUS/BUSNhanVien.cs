using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSNhanVien
    {
        public static List<DTONhanVien> GetDSNhanVien()
        {
            return DAONhanVien.GetDSNV();
        }
    }
}
