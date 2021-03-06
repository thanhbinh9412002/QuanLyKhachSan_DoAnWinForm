using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyKhachSan_DoAnWindow.DataProvider;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class He_Thong_DAO
    {
        private DBConnection conn;
        public He_Thong_DAO()
        {
            conn = new DBConnection();
        }

        public string Check_Tai_Khoan(string username)
        {
            const string sql = "select passwordtk from hethong where username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            object password = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(password);
        }

        public string Lay_Ten_Nhan_Vien(string username)
        {
            const string sql = "select nhanvien.tennhanvien from nhanvien, hethong where hethong.username = @username and hethong.manhanvien = nhanvien.manhanvien";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            object fullname = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(fullname);
        }

        public void Doi_Mat_Khau(string username, string password)
        {
            const string sql = "update hethong set passwordtk = @password where username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@password", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(password);
            sqlParameters[1] = new SqlParameter("@username", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(username);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public string Dem_Phong_Trong()
        {
            const string sql = "select count(maphong) from phong where dadat = 'khong'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            object emptyroom = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(emptyroom);
        }

        public string Dem_Phong_Dat()
        {
            const string sql = "select count(maphong) from phong where dadat = 'co'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            object room = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(room);
        }

        public string Dem_Phong_Thue()
        {
            const string sql = "select count(maphong) from phong where dathue = 'co'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            object room = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(room);
        }

        public DataTable Lay_Data_Phong()
        {
            const string sql = "select * from phong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = new DataTable();
            dt = conn.executeReader(sql, sqlParameters);
            return dt;
        }
    }
}
