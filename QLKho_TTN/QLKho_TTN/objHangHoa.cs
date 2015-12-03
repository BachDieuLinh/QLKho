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

        

        public DataTable SXHangHoa_SL()
        {
            string str = "SELECT * FROM HANGHOA ORDER BY SoLuong dESC";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }


        public DataTable SXHangHoa_GN()
        {
            string str = "SELECT * FROM HANGHOA ORDER BY GiaNhap dESC";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable SXHangHoa_GB()
        {
            string str = "SELECT * FROM HANGHOA ORDER BY GiaBan dESC";
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
            DataTable dt = new DataTable();
            string sql = "Sea_MaHH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
        public DataTable TimKiemTenHH(string TenHH)
        {
            DataTable dt = new DataTable();
            string sql = "Sea_TenHH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenHH", TenHH);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
        public void ThemHangHoa(string MaHH ,string TenHH, string DVT, int SoLuong, float GiaNhap, float GiaBan)
        {
            string str = "ADD_HH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            cmd.Parameters.AddWithValue("@TenHH",TenHH);
            cmd.Parameters.AddWithValue("@DVT", DVT);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", GiaNhap);
            cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaHangHoa(string MaHH, string TenHH, string DVT, int SoLuong, float GiaNhap, float GiaBan)
        {
            string str = "Upd_HH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            cmd.Parameters.AddWithValue("@TenHH", TenHH);
            cmd.Parameters.AddWithValue("@DVT", DVT);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", GiaNhap);
            cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public void XoaHangHoa(string MaHH)
        {
            string str = "Del_HH";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHH", MaHH);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
