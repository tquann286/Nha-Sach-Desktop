using Nha_Sach_Desktop.DAO;
using Nha_Sach_Desktop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nha_Sach_Desktop.BUS
{
    public class BUSChiTietDoanhThu
    {
        public static List<DTOChiTietDoanhThu> GetCTDoanhThu(string thangNam)
        {
            return DAOChiTietDoanhThu.GetCTDT(thangNam);
        }
    }
}
