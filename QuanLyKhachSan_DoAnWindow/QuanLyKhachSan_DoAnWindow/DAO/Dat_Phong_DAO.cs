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

        public DataTable Tim_Phong_Theo_Ma_Phong(string maphong)
        {
            string sql = "select phong.maphong, phong.maloai, loaiphong.gia, loaiphong.songuoi, trangthaiphong.trangthai from phong, loaiphong, trangthaiphong " +
                "where phong.maphong = @maphong and phong.maloai = loaiphong.maloai and trangthaiphong.maphong = phong.maphong";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);
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

        public DataTable Tim_Kiem_DS(string maphieudat)
        {
            string sql = "select maphieudat, makhachhang, ngayden, ngaydi from phieudatphong where maphieudat like '%" +maphieudat+ "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Lay_Ma_Phieu()
        {
            string sql = "select maphieudat from phieudatphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable Lay_Thong_Tin(string maphieudat)
        {
            string sql = "select chitietdatphong.maphieudat, chitietdatphong.maphong, khachhang.cmnd_passport, phieudatphong.songuoi, phieudatphong.sotiendatcoc, phieudatphong.ngayden, phieudatphong.ngaydi " +
                "from phieudatphong, chitietdatphong, khachhang " +
                "where chitietdatphong.maphieudat = phieudatphong.maphieudat and phieudatphong.makhachhang = khachhang.makhachhang and phieudatphong.maphieudat = @maphieudat";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieudat", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphieudat);
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
