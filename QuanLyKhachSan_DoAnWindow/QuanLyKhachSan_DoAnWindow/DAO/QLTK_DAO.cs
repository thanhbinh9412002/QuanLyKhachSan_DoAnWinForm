using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class QLTK_DAO
    {
        private DBConnection conn;

        public QLTK_DAO()
        {
            conn = new DBConnection();
        }

        //them tai khoan
        public void themTaiKhoan(string user, string pass, string maNV)
        {
            string sql = "insert into hethong(username, manhanvien, passwordtk)" +
                "values(@user, @manv, @pass)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[0].Value = user;

            sqlParameters[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[1].Value = pass;

            sqlParameters[2] = new SqlParameter("@manv", SqlDbType.Char);
            sqlParameters[2].Value = maNV;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        //sua tai khoan
        public void suaTaiKhoan(string user, string pass, string maNV)
        {
            string query = "update hethong set username = @user, passwordtk = @pass" +
                " where manhanvien = @manv";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[0].Value = user;

            sqlParameters[1] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[1].Value = pass;

            sqlParameters[2] = new SqlParameter("@manv", SqlDbType.Char);
            sqlParameters[2].Value = maNV;

            conn.executeInsertQuery(query, sqlParameters);
        }

        //xoa tai khoan
        public void xoataikhoan(string maNV)
        {
            string query = "delete from hethong where manhanvien = @manv";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@manv", SqlDbType.Char);
            sqlParameters[0].Value = maNV;

            conn.executeInsertQuery(query, sqlParameters);
        }
        
        public DataTable LoadbangQL(string maNV)
        {
            string query = "select * from hethong where manhanvien like '%" + maNV + "%'";
            return conn.executeLoadData(query);
        }

        public int CountMa()
        {
            string query = "select count(*) from hethong";
            return conn.executeCount(query);
        }
    }
}
