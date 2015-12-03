using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLKho_TTN
{
    class objKhachHang
    {
        public DataTable HienThiKhachHang()
        {
            string str = "Sho_KH";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }


        public void ThemKhachHang(string MaKH, string TenKH, string DiaChi, string Sdt, String GhiChu)
        {
            string str = "Ins_KH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT",Sdt);
            cmd.Parameters.AddWithValue("@GhiCHu", GhiChu);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaKhachHang(string MaKH, string TenKH, string DiaChi, string Sdt, String GhiChu)
        {
            string str = "Upd_KH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", Sdt);
            cmd.Parameters.AddWithValue("@GhiCHu", GhiChu);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public void XoaKhachHang(string MaKH)
        {
            string str = "Del_KH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
