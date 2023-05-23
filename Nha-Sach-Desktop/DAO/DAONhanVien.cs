using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAONhanVien
    {
        public static List<DTONhanVien> GetDSNV()
        {
            List<DTONhanVien> DSNhanVien = new List<DTONhanVien>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.NhanViens select p;
                foreach (var row in query)
                {
                    DTONhanVien nv = new DTONhanVien();
                    nv.Email = row.Email;
                    nv.HoTen = row.HoTen;
                    nv.DiaChi = row.DiaChi;
                    nv.Sdt = row.Sdt;
                    DSNhanVien.Add(nv);
                }
            }
            return DSNhanVien;
        }
        public static List<DTONhanVien> TimNhanVien(string strNV)
        {
            List<DTONhanVien> DSNhanVien = new List<DTONhanVien>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.NhanViens where p.Email.Contains(strNV) || p.HoTen.Contains(strNV) select p;
                foreach (var row in query)
                {
                    DTONhanVien nv = new DTONhanVien();
                    nv.Email = row.Email;
                    nv.HoTen = row.HoTen;
                    nv.DiaChi = row.DiaChi;
                    nv.Sdt = row.Sdt;
                    DSNhanVien.Add(nv);
                }
            }
            return DSNhanVien;
        }
        public static bool checkEmailExist(string email)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.NhanViens where p.Email == email select p;
                if (query.Count() > 0)
                    return false;
            }
            return true;
        }
        public static void InsertNhanVien(string email, string hoten, string diachi, string sdt, string password)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                NhanVien nv = new NhanVien();
                nv.Email = email;
                nv.HoTen = hoten;
                nv.DiaChi = diachi;
                nv.Sdt = sdt;
                nv.Password = password;
                dbMain.NhanViens.InsertOnSubmit(nv);
                dbMain.SubmitChanges();
            }
        }
        public static void DeleteNhanVien(string email)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                NhanVien nv = dbMain.NhanViens.Where(p => p.Email == email).FirstOrDefault();
                if (nv != null)
                {
                    dbMain.NhanViens.DeleteOnSubmit(nv);
                    dbMain.SubmitChanges();
                    MessageBox.Show("Xoá nhân viên thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xoá", "Thông báo");
                }
            }
        }
        public static NhanVien FillNhanVien(string email)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                NhanVien nv = dbMain.NhanViens.Where(p => p.Email == email).FirstOrDefault();
                return nv;
            }
        }
        public static void UpdateNhanVien(string email, string hoten, string diachi, string sdt)
        {
            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var nv = (from h in dbMain.NhanViens where h.Email == email select h).FirstOrDefault();
                nv.Email = email;
                nv.HoTen = hoten;
                nv.DiaChi = diachi;
                nv.Sdt = sdt;

                dbMain.SubmitChanges();
            }

        }
    }
}
