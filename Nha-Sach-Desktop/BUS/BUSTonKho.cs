using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSTonKho
    {
        public static List<DTOTonKho> GetDSTonKho()
        {
            return DAOTonKho.GetDSTK();
        }

    }
}
