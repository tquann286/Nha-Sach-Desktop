using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DTO;
using Nha_Sach_Desktop.DAO;

namespace Nha_Sach_Desktop.BUS
{
    public class BUSLogin
    {
        public bool BLLKTraTKhoan(DTOLogin account)
        {
            return DAOLogin.KiemTraTaiKhoan(account);
        }
        public static void ChangeMK(string user, string mkcu, string mkmoi)
        {
            DAOLogin.ChangeMK(user, mkcu, mkmoi);
        }
    }
}
