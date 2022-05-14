using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data.SqlClient;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Vat_Tu_DAO
    {
        private DBConnection conn;
        public Vat_Tu_DAO()
        {
            conn = new DBConnection();
        }

        public void Xoa_Vat_Tu(string mavattu)
        {
            const string sql = "delete from chitietvattu where mavattu=@mavattu; " +
                               "delete from vattu where mavattu=@mavattu; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@mavattu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mavattu);

            conn.executeInsertQuery(sql, sqlParameters);
        }
    }
}
