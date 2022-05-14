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

        public DataTable Lay_Data_Bang()
        {
            const string sql = "select * from chitietthuephong";
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
    }
}
