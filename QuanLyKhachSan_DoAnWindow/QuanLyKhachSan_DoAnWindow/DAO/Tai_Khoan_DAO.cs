using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Tai_Khoan_DAO
    {
        private DBConnection conn;
        public Tai_Khoan_DAO()
        {
            conn = new DBConnection();
        }
        // them tai khoan
        public void Them_tai_khoan(string ma, string user, string pass, string cv)
        {
            const string sql = "insert into hethong(passwordtk, manhanvien, username, machucvu )" +
                " values(@pass, @ma, @user, @cv)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[3] = new SqlParameter("@cv", SqlDbType.Char);
            sqlParameters[3].Value = cv;

            sqlParameters[2] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[2].Value = user;

            sqlParameters[1] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[1].Value = ma;

            sqlParameters[0] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[0].Value = pass;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        //Cap nhat tai khoan
        public void Cap_nhat_tai_khoan(string ma, string user, string pass, string cv)
        {
            const string sql = "update hethong set username = @user, passwordtk = @pass, machucvu = @cv where manhanvien = @ma";

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[3] = new SqlParameter("@cv", SqlDbType.Char);
            sqlParameters[3].Value = cv;

            sqlParameters[2] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[2].Value = user;

            sqlParameters[1] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[1].Value = ma;

            sqlParameters[0] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[0].Value = pass;


            conn.executeInsertQuery(sql, sqlParameters);
        }
        //xoa tai khoan
        public void Xoa_tai_khoan(string ma)
        {
            string sql = "delete from hethong where manhanvien = @ma";
            SqlParameter[] sqlParameter = new SqlParameter[1];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = ma;

            conn.executeInsertQuery(sql, sqlParameter);
        }
        //lay du lieu - tim kiem theo ten
        public DataTable Loadbanghethong(string user)
        {
            string query = "select * from hethong where username like '%" + user + "%'";
            return conn.executeLoadData(query);
        }
        //lây ma chuc vu
        public DataTable machucvu()
        {
            string query = "select DISTINCT machucvu from hethong";
            return conn.executeLoadData(query);
        }
        //lay ma nhan vien
        public DataTable manhanvien()
        {
            string query = "select DISTINCT manhanvien from hethong";
            return conn.executeLoadData(query);
        }
    }
}
