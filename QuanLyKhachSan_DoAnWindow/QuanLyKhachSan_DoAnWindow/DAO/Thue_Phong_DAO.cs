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

        public DataTable Hien_Thi_Danh_Sach()
        {
            string sql = "select chitietthuephong.maphieuthue, phieuthuephong.maphong, makhachhang, ngaythuephong, sotiencoc, songuoi from  chitietthuephong, phieuthuephong where chitietthuephong.maphieuthue = phieuthuephong.maphieuthue;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public int Dem_Ma_Phieu_Dat()
        {
            string query = "select count(*) from phieudatphong";
            return conn.executeCount(query);
        }

        public int Dem_Ma_Phieu_Thue()
        {
            string query = "select count(*) from phieuthuephong";
            return conn.executeCount(query);
        }
    }
}
