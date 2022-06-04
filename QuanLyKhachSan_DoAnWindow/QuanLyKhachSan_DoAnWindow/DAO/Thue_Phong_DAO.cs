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

        public string Lay_MaKH_SDT(string sodienthoai)
        {
            const string sql = "select makhachhang from khachhang where sodienthoai = @sodienthoai";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sodienthoai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(sodienthoai);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public void Them_Phieu_Thue(string maphieu, string maphong, string username)
        {
            const string sql = "insert into phieuthuephong(maphieuthue, maphong, username) values (@maphieuthue, @maphong, @username)";
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieu);

            sqlParameters[1] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maphong);

            sqlParameters[2] = new SqlParameter("@username", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(username);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_Phieu_Thue(string maphieu, string maphong)
        {
            const string sql = "update phieuthuephong set maphong=@maphong where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieu);

            sqlParameters[1] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Them_Phieu_Thue_Chi_Tiet(string maphieu, string makhachhang, string ngaythuephong, string sotiencoc, string songuoi)
        {
            const string sql = "insert into chitietthuephong(maphieuthue, makhachhang, ngaythuephong, sotiencoc, songuoi) values (@maphieuthue, @makhachhang, @ngaythuephong, @sotiencoc, @songuoi)";
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieu);

            sqlParameters[1] = new SqlParameter("@makhachhang", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(makhachhang);

            sqlParameters[2] = new SqlParameter("@ngaythuephong", System.Data.SqlDbType.Date);
            sqlParameters[2].Value = Convert.ToString(ngaythuephong);

            sqlParameters[3] = new SqlParameter("@sotiencoc", System.Data.SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(sotiencoc);

            sqlParameters[4] = new SqlParameter("@songuoi", System.Data.SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(songuoi);

            conn.executeScalar(sql, sqlParameters);
        }

        public void Sua_Phieu_Thue_Chi_Tiet(string maphieu, string makhachhang, string ngaythuephong, string sotiencoc, string songuoi)
        {
            const string sql = "update chitietthuephong set makhachhang=@makhachhang, ngaythuephong=@ngaythuephong, sotiencoc=@sotiencoc, songuoi=@songuoi where maphieuthue=@maphieuthue";
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieu);

            sqlParameters[1] = new SqlParameter("@makhachhang", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(makhachhang);

            sqlParameters[2] = new SqlParameter("@ngaythuephong", System.Data.SqlDbType.Date);
            sqlParameters[2].Value = Convert.ToString(ngaythuephong);

            sqlParameters[3] = new SqlParameter("@sotiencoc", System.Data.SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(sotiencoc);

            sqlParameters[4] = new SqlParameter("@songuoi", System.Data.SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(songuoi);

            conn.executeScalar(sql, sqlParameters);
        }

        public void Xoa_Phieu_Thue(string maphieu)
        {
            const string sql = "delete from chitietthuephong where maphieuthue=@maphieuthue;" +
                               "delete from phieuthuephong where maphieuthue=@maphieuthue;";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieu);

            conn.executeInsertQuery(sql, sqlParameters);
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
