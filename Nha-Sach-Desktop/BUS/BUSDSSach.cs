using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.BUS
{
    internal class BUSDSSach
    {
        public static List<DTODSSach> GetDSSach()
        {
            return DAODSSach.GetDSSach();   
        }
    }
}
