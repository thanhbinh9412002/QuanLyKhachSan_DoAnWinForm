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

        public DataTable Lay_Data_Bang()
        {
            const string sql = "select * from chitietthuephong";
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
            const string sql = "select maphong from chitietthuephong where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public string Lay_Ma_Dich_Vu(string maphieuthue)
        {
            const string sql = "select madichvu from chitietthuephong where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }
        public string Lay_Ngay(string maphieuthue)
        {
            const string sql = "select ngay from chitietthuephong where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }
        public string Lay_So_Luong(string maphieuthue)
        {
            const string sql = "select soluong from chitietthuephong where maphieuthue=@maphieuthue";
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

        public void Them_DV_Phong(string maphieuthue, string maphong, string madichvu, string ngay, string soluong)
        {
            const string sql = "insert into chitietthuephong(maphieuthue, maphong, ngay, madichvu, soluong) values(@maphieuthue, @maphong, @ngay, @madichvu, @soluong)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);

            sqlParameters[1] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maphong);

            sqlParameters[2] = new SqlParameter("@ngay", System.Data.SqlDbType.Date);
            sqlParameters[2].Value = Convert.ToString(ngay);

            sqlParameters[3] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(madichvu);

            sqlParameters[4] = new SqlParameter("@soluong", System.Data.SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(soluong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_DV_Phong(string maphieuthue, string maphong, string madichvu, string ngay, string soluong)
        {
            const string sql = "update chitietthuephong set maphong=@maphong, ngay=@ngay, madichvu=@madichvu, soluong=@soluong where maphieuthue=@maphieuthue and maphong=@maphong2";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            
            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);

            sqlParameters[1] = new SqlParameter("@ngay", System.Data.SqlDbType.Date);
            sqlParameters[1].Value = Convert.ToString(ngay);

            sqlParameters[2] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(madichvu);

            sqlParameters[3] = new SqlParameter("@soluong", System.Data.SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(soluong);

            sqlParameters[4] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(maphieuthue);

            sqlParameters[5] = new SqlParameter("@maphong2", System.Data.SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_DV_Phong(string maphieuthue, string maphong)
        {
            const string sql = "delete from chitietthuephong where maphieuthue=@maphieuthue and maphong=@maphong";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieuthue);

            sqlParameters[1] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maphong);

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
