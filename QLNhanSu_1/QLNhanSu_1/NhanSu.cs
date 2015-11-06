using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhanSu_1
{
    public class NhanSu
    {
        string strcon = @"Data Source=HOA_LONG\SQLEXPRESS; Initial Catalog=QLCT; Integrated Security=true;";
        public DataTable Show()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblNhanVien", con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Update(string manv, string hodem, string ten, DateTime  NS,string GT,int LUONG,string DC,string Ma_NQL,string MaDV,string ChucVu,int DT)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@HoDem", hodem);
            cmd.Parameters.AddWithValue("@TenNV", ten);
            cmd.Parameters.AddWithValue("@NS", NS);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@Luong", LUONG);
            cmd.Parameters.AddWithValue("@DC", DC);
            cmd.Parameters.AddWithValue("@Ma_NQL", Ma_NQL);
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
            cmd.Parameters.AddWithValue("@DT", DT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        // xóa nhân viên
        public DataTable Delete(string MaNV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        // Tìm kiếm
        public DataTable Search_Ma(string MaNV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("TK_MaNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public DataTable Search_Ten(string TenNV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("TK_TenNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
