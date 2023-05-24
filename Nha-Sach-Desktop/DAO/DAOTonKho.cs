using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DAO
{
    internal class DAOTonKho
    {
        public static List<DTOTonKho> GetDSTK()
        {
            List<DTOTonKho> DSTonKho = new List<DTOTonKho>();

            using (NhaSachBatOnDataContext dbMain = new NhaSachBatOnDataContext())
            {
                var query = from p in dbMain.Saches select p;
                foreach (var row in query)
                {
                    DTOTonKho tk = new DTOTonKho();
                    tk.MaSach = row.MaSach;
                    tk.TenSach = row.TenSach;
                    tk.TonDau = (int)row.TonDau;
                    tk.TongNhap = (int)row.TongNhap;
                    tk.TongBan = (int)row.TongBan;
                    tk.TonCuoi = (int)row.TonCuoi;
                    DSTonKho.Add(tk);
                }
            }
            return DSTonKho;
        }
    }
}
