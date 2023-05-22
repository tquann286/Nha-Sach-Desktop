using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    nv.Password = row.Password;
                    DSNhanVien.Add(nv);
                }
            }
            return DSNhanVien;
        }
    }
}
