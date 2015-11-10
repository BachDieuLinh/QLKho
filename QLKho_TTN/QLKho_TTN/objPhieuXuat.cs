using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLKho_TTN
{
    class objPhieuXuat
    {
        public DataTable HienThiPhieuXuat()
        {
            string str = "Sho_PX";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void GhiPhieuXuat(string MaPhieuXuat, string MaNV, string MaKH, string NgayXuat, string TongXuat)
        {
            string str = "ADD_PX";
         
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuXuat", MaPhieuXuat);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@NgayXuat", NgayXuat);
            cmd.Parameters.AddWithValue("@TongXuat", TongXuat);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
