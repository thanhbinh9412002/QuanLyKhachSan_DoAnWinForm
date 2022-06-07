using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
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

        public string Count_Ma_Phieu()
        {
            string query = "SELECT MAX(maphieudat) FROM phieudatphong";
            SqlParameter[] sql = new SqlParameter[0];
            return Convert.ToString(conn.executeScalar(query, sql));
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
            string sql =    "select phieudatphong.maphieudat, phieudatphong.maphong, khachhang.tenkhachhang, chitietdatphong.sotiencoc, chitietdatphong.ngaythuephong, chitietdatphong.songuoi " +
                            "from phieudatphong, khachhang, chitietdatphong " +
                            "where khachhang.makhachhang = chitietdatphong.makhachhang and phieudatphong.maphieudat = chitietdatphong.maphieudat " +
                            "order by ngaythuephong DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
        public DataTable loadpagechitiet(string maphong)           // tao ra bang thong tin chi tiet nhu tren form
        {
            string query =  "select khachhang.makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, sodienthoai, ngaythuephong, songuoi, sotiencoc " +
                            "from khachhang inner join chitietdatphong on khachhang.makhachhang = chitietdatphong.makhachhang  " +
                            "where chitietdatphong.maphieudat = (select maphieudat from phieudatphong where maphong = '" + maphong + "')";
            return conn.executeLoadData(query);
        }
        //lay thong tin ve loai phong cua ma phieu dat
        public DataTable lay_bangPhong(string maphong)
        {
            string query = "select phong.maphong, loaiphong.maloai, loaiphong.songuoi, loaiphong.gia " +
                           "from phong, loaiphong " +
                           "where loaiphong.maloai = phong.maloai and phong.maphong = @phong";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@phong", SqlDbType.Char);
            sqlParameters[0].Value = maphong;

            return conn.executeReader(query, sqlParameters);
        }

        //them phieu dat phong
        //cap nhat phong 
        public void capnhatcodatphong(string ma)
        {
            string sql = "update phong set dadat = @dat where maphong = @ma";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@dat", SqlDbType.Char);
            sqlParameters[1].Value = "co";

            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void capnhatkhongdatphong(string ma)
        {
            string sql = "update phong set dadat = @dat where maphong = @ma";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@dat", SqlDbType.Char);
            sqlParameters[1].Value = "khong" +
                "";

            conn.executeInsertQuery(sql, sqlParameters);
        }

        //themphieudat
        public void themPhieuDat(Dat_Phong DP)
        {
            string sql1 = "insert into phieudatphong(maphieudat, maphong, username)" +
                " values(@maphieu, @maphong, @user)";
            SqlParameter[] sql = new SqlParameter[3];
            sql[0] = new SqlParameter("@maphieu", SqlDbType.Char);
            sql[0].Value = DP.Ma_phieu_dat;

            sql[1] = new SqlParameter("@maphong", SqlDbType.Char);
            sql[1].Value = DP.Ma_phong;

            sql[2] = new SqlParameter("@user", SqlDbType.VarChar);
            sql[2].Value = DP.Username;

            conn.executeInsertQuery(sql1, sql);
        }
        
        public void themchitietPhieuDat(Dat_Phong DP)
        {
            string sql2 = "insert into chitietdatphong(maphieudat, makhachhang, ngaythuephong, sotiencoc, songuoi) " +
                "values(@maphieu, @makh, @ngaythue, @sotien, @songuoi)";
            SqlParameter[] sql = new SqlParameter[5];
            sql[0] = new SqlParameter("@maphieu", SqlDbType.Char);
            sql[0].Value = DP.Ma_phieu_dat;

            sql[1] = new SqlParameter("@makh", SqlDbType.Char);
            sql[1].Value = DP.Ma_khach_hang;

            sql[2] = new SqlParameter("@ngaythue", SqlDbType.DateTime);
            sql[2].Value = DP.Ngaythue;

            sql[3] = new SqlParameter("@sotien", SqlDbType.Int);
            sql[3].Value = DP.So_tien_coc;

            sql[4] = new SqlParameter("@songuoi", SqlDbType.Int);
            sql[4].Value = DP.So_nguoi;

            conn.executeInsertQuery(sql2, sql);
        }

        public void xoachitietPhieuDat(string maphieu)
        {
            string query = "delete from chitietdatphong where maphieudat = @machitiet";
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@machitiet", SqlDbType.Char);
            sql[0].Value = maphieu;

            conn.executeInsertQuery(query, sql);
        }
        public void xoaPhieuDat(string maphieu)
        {
            string query = "delete from phieudatphong where maphieudat = @maphieu";
            SqlParameter[] sql = new SqlParameter[1];
            
            sql[0] = new SqlParameter("@maphieu", SqlDbType.Char);
            sql[0].Value = maphieu;

            conn.executeInsertQuery(query, sql);
        }
        public DataTable laybangtimkiem(string tenKH)
        {
            string sql = "select phieudatphong.maphieudat, phieudatphong.maphong, khachhang.tenkhachhang, chitietdatphong.sotiencoc, chitietdatphong.ngaythuephong, chitietdatphong.songuoi " +
                            "from phieudatphong, khachhang, chitietdatphong " +
                            "where khachhang.makhachhang = chitietdatphong.makhachhang and phieudatphong.maphieudat = chitietdatphong.maphieudat and tenkhachhang like '%" + tenKH + "%'" +
                            "order by ngaythuephong DESC";
            return conn.executeLoadData(sql);
        }    

        //kiem tra khach hang co trong danh sach dat phong
        public string CheckKH(string ma)
        {
            string query = "select makhachhang from chitietdatphong where makhachhang = @ma";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = ma;
            return Convert.ToString(conn.executeScalar(query, sqlParameter));
        }
    }
}
