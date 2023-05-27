using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nha_Sach_Desktop.DAO;
using System.Data.SqlClient;
using Nha_Sach_Desktop.DTO;
using System.Windows.Forms;
using System.Security.Principal;

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
        public static void ChangeMK(string user, string mkcu, string mkmoi)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                DangNhap doi = dbMain.DangNhaps.SingleOrDefault(p => p.TaiKhoan ==
                 user);
                
                if (doi.MatKhau == mkmoi)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ !", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((doi.MatKhau == mkcu) && (doi.MatKhau != mkmoi || doi.TaiKhoan == user))
                {
                    doi.MatKhau = mkmoi;
                    dbMain.SubmitChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không hợp lệ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
