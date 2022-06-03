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

        public string Lay_SDT_KH(string makhachhang)
        {
            const string sql = "select sodienthoai from khachhang where khachhang.makhachhang = @makhachhang";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@makhachhang", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(makhachhang);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
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

        public DataTable Hien_Thi_Phong(string maphong)
        {
            string sql = "select phong.maphong, loaiphong.maloai, loaiphong.songuoi, loaiphong.gia from phong, loaiphong where phong.maloai = loaiphong.maloai and phong.maphong = '" + maphong + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Hien_Thi_Danh_Sach(string maphieu)
        {
            string sql = "select chitietthuephong.maphieuthue, phieuthuephong.maphong, makhachhang, ngaythuephong, sotiencoc, songuoi from  chitietthuephong, phieuthuephong where chitietthuephong.maphieuthue = phieuthuephong.maphieuthue and phieuthuephong.maphieuthue like '%" + maphieu + "%'";
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
