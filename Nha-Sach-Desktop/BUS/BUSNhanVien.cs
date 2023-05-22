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
        public static bool checkEmailExist(string manv)
        {
            return DAONhanVien.checkEmailExist(manv);
        }
        public static void InsertNhanVien(string email, string hoten, string diachi, string sdt, string password)
        {
            DAONhanVien.InsertNhanVien(email, hoten, diachi, sdt, password);
        }
        public static void DeleteNhanVien(string email)
        {
            DAONhanVien.DeleteNhanVien(email.Trim());
        }
        public static NhanVien FillNhanVien(string email)
        {
            return DAONhanVien.FillNhanVien(email.Trim());
        }
        public static void UpdateNhanVien(string email, string hoten, string diachi, string sdt)
        {
            DAONhanVien.UpdateNhanVien(email, hoten, diachi, sdt);
        }
    }
}
