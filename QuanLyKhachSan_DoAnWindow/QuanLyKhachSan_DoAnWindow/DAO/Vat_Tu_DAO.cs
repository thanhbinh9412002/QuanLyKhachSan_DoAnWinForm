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
    internal class Vat_Tu_DAO
    {
        private DBConnection conn;
        public Vat_Tu_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Lay_Du_lieu()
        {
            const string sql = "select maloai from loaiphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable loaiphong = new DataTable();
            loaiphong = conn.executeReader(sql, sqlParameters);
            return loaiphong;
        }

        public DataTable Tim_Vat_Tu(string maloaiphong, string mavattu)
        {
            string sql = "select chitietvattu.mavattu,tenvattu,soluong from vattu,chitietvattu where vattu.mavattu = chitietvattu.mavattu and chitietvattu.maloaiphong=@maloaiphong  and vattu.mavattu like '%" + mavattu + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maloaiphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloaiphong);
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public void Them_Vat_Tu(string maloaiphong, string mavattu, string tenvattu, string soluong)
        {
            const string sql = "insert into vattu(mavattu,tenvattu) values (@mavattu,@tenvattu); insert into chitietvattu(maloaiphong, mavattu, soluong) values(@maloaiphong, @mavattu, @soluong)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@mavattu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mavattu);

            sqlParameters[1] = new SqlParameter("@tenvattu", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(tenvattu);

            sqlParameters[2] = new SqlParameter("@maloaiphong", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(maloaiphong);

            sqlParameters[3] = new SqlParameter("@soluong", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(soluong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_Vat_Tu(string maloaiphong, string mavattu, string tenvattu, string soluong)
        {
            const string sql = "update vattu set tenvattu=@tenvattu where mavattu=@mavattu; update chitietvattu set soluong=@soluong where maloaiphong=@maloaiphong and mavattu=@mavattu";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@tenvattu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tenvattu);

            sqlParameters[1] = new SqlParameter("@mavattu", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(mavattu);

            sqlParameters[2] = new SqlParameter("@soluong", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(soluong);

            sqlParameters[3] = new SqlParameter("@maloaiphong", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(maloaiphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_Vat_Tu(string mavattu, string maloaiphong)
        {
            const string sql = "delete from chitietvattu where mavattu=@mavattu and maloaiphong=@maloaiphong; " +
                               "delete from vattu where mavattu=@mavattu; ";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@mavattu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mavattu);
            sqlParameters[1] = new SqlParameter("@maloaiphong", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maloaiphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }
    }
}
