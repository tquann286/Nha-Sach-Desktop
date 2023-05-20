using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Nha_Sach_Desktop.DAO
{
    public class Connect
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1TEJ4NIL;Initial Catalog=BatOnBookStore;Integrated Security=True");
    }
}
