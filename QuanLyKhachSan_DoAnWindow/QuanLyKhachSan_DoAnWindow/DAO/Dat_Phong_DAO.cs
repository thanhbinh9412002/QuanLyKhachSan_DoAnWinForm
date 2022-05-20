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
    internal class Dat_Phong_DAO
    {
        private DBConnection conn;
        public Dat_Phong_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Tim_Phong_Trong()
        {
            string sql = "select * from phong where dadat='khong'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
