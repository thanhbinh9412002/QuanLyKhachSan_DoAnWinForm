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

        public int Count_Ma_Phieu()
        {
            string query = "select count(*) from phieudatphong";
            return conn.executeCount(query);
        }

        public DataTable Tim_Phong_Trong()
        {
            string sql = "select * from phong where dadat='khong'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Hien_Thi_DS()
        {
            string sql = "select maphieudat, makhachhang, ngayden, ngaydi from phieudatphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
