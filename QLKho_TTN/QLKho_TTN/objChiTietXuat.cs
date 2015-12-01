using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLKho_TTN
{
    class objChiTietXuat
    {
        public DataTable HienThiChiTietXuat()
        {
            string str = "Sho_CTX";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void GhiChiTietXuat(string MaPhieuXuat, string MaHH, string SoLuong, string DonGiaXuat, string ThanhTien)
        {
            string str = "ADD_CTX";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuXuat", MaPhieuXuat);
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@DonGiaXuat", DonGiaXuat);
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
