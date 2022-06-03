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
    internal class Thue_Phong_DAO
    {
        private DBConnection conn;
        public Thue_Phong_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Tim_Phong_Trong()
        {
            string sql = "select * from phong where danhan='khong'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
