using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DAO;
using System.Data.SqlClient;
using Nha_Sach_Desktop.DTO;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DAO
{
    class DAOLogin
    {
        public static bool KiemTraTaiKhoan(DTOLogin user)
        {
            NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext();

            var svt = (from a in dbMain.DangNhaps
                       where a.TaiKhoan == user.taiKhoan && a.MatKhau == user.matKhau
                       select a);
            if (svt.Count() > 0)
            {
                return true;
                
            }
            else return false;
        }

        
    }
}
