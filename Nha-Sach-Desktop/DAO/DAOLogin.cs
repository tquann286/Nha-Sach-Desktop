using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DAO;
using System.Data.SqlClient;
using Nha_Sach_Desktop.DTO;
using System.Linq;

namespace Nha_Sach_Desktop.DAO
{
    class DAOLogin
    {
        public static bool KiemTraTaiKhoan(DTOLogin user)
        {
            dbMainDataContext dbMain = new dbMainDataContext();

            var svt = (from a in dbMain.Accounts
                       where a.UserName == user.taiKoan && a.PassWord == user.matKhau
                       select a);
            if (svt.Count() > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
