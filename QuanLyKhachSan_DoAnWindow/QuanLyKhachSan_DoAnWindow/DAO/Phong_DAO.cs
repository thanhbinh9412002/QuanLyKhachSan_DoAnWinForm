using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Phong_DAO
    {
        private DBConnection conn;
        public Phong_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Lay_Ma_Loai()
        {
            const string sql = "select maloai from loaiphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable phieuthue = new DataTable();
            phieuthue = conn.executeReader(sql, sqlParameters);
            return phieuthue;
        }

        public void Them_Phong(string maphong, string maloai)
        {
            const string sql = "insert into phong(maphong, maloai, dadat, danhan) values(@maphong, @maloai, 'khong', 'khong')";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);

            sqlParameters[1] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maloai);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_Phong(string maphong, string maloai, string dadat, string danhan)
        {
            const string sql = "update phong set  maloai=@maloai, dadat=@dadat, danhan=@danhan where maphong=@maphong";
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);

            sqlParameters[1] = new SqlParameter("@dadat", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(dadat);

            sqlParameters[2] = new SqlParameter("@danhan", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(danhan);

            sqlParameters[3] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_Phong(string maphong)
        {
            const string sql = "delete from chitietthuephong where maphong=@maphong; " +
                               "delete from chitietdatphong where maphong = @maphong; " +
                               "delete from trangthaiphong where maphong = @maphong;" +
                               "delete from phong where maphong = @maphong; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable Tim_Phong(string maphong)
        {
            const string sql = "select * from phong where maphong=@maphong";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);
            DataTable bang= new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
