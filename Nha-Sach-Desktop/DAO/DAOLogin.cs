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

            var svt = (from a in dbMain.DANGNHAPs
                       where a.taikhoan == user.taiKoan && a.matkhau == user.matKhau
                       select a);
            if (svt.Count() > 0)
            {
                MessageBox.Show("Đăng nhập thành công" + svt.ToString());
                return true;
                
            }
            else return false;
        }

        
    }
}
