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
    internal class Khach_Hang_DAO
    {
        private DBConnection conn;
        public Khach_Hang_DAO()
        {
            conn = new DBConnection();
        }
        //them khach hang
        public void themKhachHang(Khach_Hang kh)
        {
            const string sql =  "insert into khachhang(makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, coquan, sodienthoai, email) " +
                                "values(@ma, @name, @sex, @cmnd, @address, @coquan, @sdt, @email)";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = kh.Ma_khach_hang;

            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = kh.Ten_khach_hang;

            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.Char);
            sqlParameters[2].Value = kh.Gioi_tinh;

            sqlParameters[3] = new SqlParameter("@cmnd", SqlDbType.VarChar);
            sqlParameters[3].Value = kh.Cmnd_passport;

            sqlParameters[4] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[4].Value = kh.Dia_chi;

            sqlParameters[5] = new SqlParameter("@coquan", SqlDbType.VarChar);
            sqlParameters[5].Value = kh.Co_quan;

            sqlParameters[6] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = kh.So_dien_thoai;

            sqlParameters[7] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[7].Value = kh.Email;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        //xoa khach hang
        public void xoaKhachHang(Khach_Hang kh)
        {
            const string sql = "Delete from khachhang where makhachhang = @maKH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            
            sqlParameters[0] = new SqlParameter("@maKH", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = kh.Ma_khach_hang;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        //cap nhat khach hang
        public void capnhatKhachHang(Khach_Hang kh)
        {
            const string sql = "update khachhang set tenkhachhang = @name, gioitinh = @sex," +
                " cmnd_passport = @cmnd, diachi = @address, coquan = @coquan, sodienthoai = @sdt, email = @email where makhachhang = @makh ";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@makh", SqlDbType.Char);
            sqlParameters[0].Value = kh.Ma_khach_hang;

            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = kh.Ten_khach_hang;

            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.Char);
            sqlParameters[2].Value = kh.Gioi_tinh;

            sqlParameters[3] = new SqlParameter("@cmnd", SqlDbType.VarChar);
            sqlParameters[3].Value = kh.Cmnd_passport;

            sqlParameters[4] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[4].Value = kh.Dia_chi;

            sqlParameters[5] = new SqlParameter("@coquan", SqlDbType.VarChar);
            sqlParameters[5].Value = kh.Co_quan;

            sqlParameters[6] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = kh.So_dien_thoai;

            sqlParameters[7] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[7].Value = kh.Email;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        // load data day du
        public DataTable loadData()
        {
            string query = "select * from khachhang";
            return conn.executeLoadData(query);
        }
        //load data theo ten khach hang tim kiem
        public DataTable loadData(string tenkh)
        {
            string query = "select * from khachhang where tenkhachhang like '%" + tenkh +"%'";
            return conn.executeLoadData(query);
        }

        // tra ve so luong khach hang hien co
        public string coutKH()
        {
            string query = "SELECT Max(makhachhang) FROM khachhang";
            SqlParameter[] sql = new SqlParameter[0];
            return Convert.ToString(conn.executeScalar(query, sql));
        }

        public DataTable KH(string sdt)         //lay thong tin kh theo sdt
        {
            string query = "select * from khachhang where sodienthoai = '"+ sdt +"'";
            return conn.executeLoadData(query);
        }
    }
}
