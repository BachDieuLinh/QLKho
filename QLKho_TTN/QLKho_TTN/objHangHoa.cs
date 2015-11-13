using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKho_TTN
{
    class objHangHoa
    {

        public DataTable HienThiHangHoa()
        {
            string str = "Sho_HH";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable TimKiemMaHH(string MaHH)
        {
            string str = "Sea_MaHH";
             DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.ExecuteNonQuery();
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
             ad.Fill(dt);
          
            cmd.Dispose();
            con.Close();
            return 
        }
    }
}
