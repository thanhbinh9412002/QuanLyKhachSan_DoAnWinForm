using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
    }
}
