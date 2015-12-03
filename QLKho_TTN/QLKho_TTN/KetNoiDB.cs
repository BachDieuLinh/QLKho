using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKho_TTN
{
    class KetNoiDB
    {
        SqlConnection cn = new SqlConnection();
        static public String KetNoi()
        {
            return (@"Data Source=HOME;Initial Catalog=QLKho;Integrated Security=True");
        }
    }
}
