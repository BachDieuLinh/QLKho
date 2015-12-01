using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLKho_TTN
{
    class objPhieuNhap
    {

        public DataTable HienThiPhieuNhap()
        {
            string str = "Sho_PN";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void GhiPhieuNhap(string MaPhieuNhap, string MaNV, string MaNCC, string NgayNhap, string TongNhap)
        {
            string str = "ADD_PN";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
            cmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
            cmd.Parameters.AddWithValue("@TongNhap", TongNhap);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
