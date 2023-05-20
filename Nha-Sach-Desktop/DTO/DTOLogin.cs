using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nha_Sach_Desktop.DTO
{
    public class DTOLogin
    {
        private string _taiKhoan;
        private string _matKhau;
        public string taiKhoan
        {
            get
            {
                return _taiKhoan;
            }

            set
            {
                _taiKhoan = value;
            }
        }
        public string matKhau
        {
            get
            {
                return _matKhau;
            }

            set
            {
                _matKhau = value;
            }
        }
    }
}
