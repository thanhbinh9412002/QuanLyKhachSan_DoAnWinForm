using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Dich_Vu_DAO
    {
        private DBConnection conn;
        public Dich_Vu_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Lay_Du_lieu()
        {
            const string sql = "select maphieuthue from phieuthuephong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable phieuthue = new DataTable();
            phieuthue = conn.executeReader(sql, sqlParameters);
            return phieuthue;
        }

        public DataTable Lay_Du_lieu_2()
        {
            const string sql = "select madichvu from dichvu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dichvu = new DataTable();
            dichvu = conn.executeReader(sql, sqlParameters);
            return dichvu;
        }

        public DataTable Tim_Phieu_Thue_Phong(string maphieuthue)
        {
            string sql = "select * from chitietdichvu where maphieuthue like '%" + maphieuthue + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Tim_Dich_Vu(string madichvu)
        {
            string sql = "select * from dichvu where madichvu like '%" + madichvu + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Lay_Data_Bang_2()
        {
            const string sql = "select * from dichvu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public string Lay_Ma_Phong(string maphieuthue)
        {
            const string sql = "select maphong from phieuthuephong where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public string Lay_Ma_Dich_Vu(string maphieuthue)
        {
            const string sql = "select madichvu from chitietdichvu where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }
        
        public string Lay_So_Luong(string maphieuthue)
        {
            const string sql = "select soluong from chitietdichvu where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public string Lay_Ten_DV(string madichvu)
        {
            const string sql = "select tendichvu from dichvu where madichvu=@madichvu";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public void Them_DV_Phong(string maphieuthue, string mahoadon, string madichvu, string soluong)
        {
            const string sql = "insert into chitietdichvu(maphieuthue, mahoadon, madichvu, soluong) values(@maphieuthue, @mahoadon, @madichvu, @soluong)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);

            sqlParameters[1] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(mahoadon);

            sqlParameters[2] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(madichvu);

            sqlParameters[3] = new SqlParameter("@soluong", System.Data.SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(soluong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_DV_Phong(string maphieuthue, string mahodon, string madichvu, string soluong)
        {
            const string sql = "update chitietdichvu set madichvu=@madichvu, soluong=@soluong where maphieuthue=@maphieuthue and mahoadon=@mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahodon);

            sqlParameters[1] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(madichvu);

            sqlParameters[2] = new SqlParameter("@soluong", System.Data.SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(soluong);

            sqlParameters[3] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(maphieuthue);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_DV_Phong(string maphieuthue)
        {
            const string sql = "delete from chitietdichvu where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Them_DV(string madichvu, string tendichvu, string gia, string donvitinh)
        {
            const string sql = "insert into dichvu(madichvu, tendichvu, gia, donvitinh) values(@madichvu, @tendichvu, @gia, @donvitinh)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);

            sqlParameters[1] = new SqlParameter("@tendichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(tendichvu);

            sqlParameters[2] = new SqlParameter("@gia", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(gia);

            sqlParameters[3] = new SqlParameter("@donvitinh", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(donvitinh);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_DV(string madichvu, string tendichvu, string gia, string donvitinh)
        {
            const string sql = "update dichvu set tendichvu=@tendichvu, gia=@gia, donvitinh=@donvitinh where madichvu=@madichvu";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@tendichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tendichvu);

            sqlParameters[1] = new SqlParameter("@gia", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(gia);

            sqlParameters[2] = new SqlParameter("@donvitinh", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(donvitinh);

            sqlParameters[3] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(madichvu);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_DV(string madichvu)
        {
            const string sql = "delete from dichvu where madichvu=@madichvu";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);

            conn.executeInsertQuery(sql, sqlParameters);
        }
    }
}
