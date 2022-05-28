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
    internal class Khach_Hang_DAO
    {
        private DBConnection conn;
        public Khach_Hang_DAO()
        {
            conn = new DBConnection();
        }
        //them khach hang
        public void themKhachHang(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            const string sql =  "insert into khachhang(makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, coquan, sodienthoai, email) " +
                                "values(@ma, @name, @sex, @cmnd, @address, @coquan, @sdt, @email)";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = tenKH;

            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.Char);
            sqlParameters[2].Value = gtKH;

            sqlParameters[3] = new SqlParameter("@cmnd", SqlDbType.VarChar);
            sqlParameters[3].Value = cmnd;

            sqlParameters[4] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[4].Value = address;

            sqlParameters[5] = new SqlParameter("@coquan", SqlDbType.VarChar);
            sqlParameters[5].Value = coquan;

            sqlParameters[6] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = sdt;

            sqlParameters[7] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[7].Value = email;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        //xoa khach hang
        public void xoaKhachHang(string maKH)
        {
            const string sql = "Delete from khachhang where makhachhang = @maKH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            
            sqlParameters[0] = new SqlParameter("@maKH", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        //cap nhat khach hang
        public void capnhatKhachHang(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            const string sql = "update khachhang set tenkhachhang = @name, gioitinh = @sex," +
                " cmnd_passport = @cmnd, diachi = @address, coquan = @coquan, sodienthoai = @sdt, email = @email where makhachhang = @makh ";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@makh", SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = tenKH;

            sqlParameters[2] = new SqlParameter("@sex", SqlDbType.Char);
            sqlParameters[2].Value = gtKH;

            sqlParameters[3] = new SqlParameter("@cmnd", SqlDbType.VarChar);
            sqlParameters[3].Value = cmnd;

            sqlParameters[4] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[4].Value = address;

            sqlParameters[5] = new SqlParameter("@coquan", SqlDbType.VarChar);
            sqlParameters[5].Value = coquan;

            sqlParameters[6] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = sdt;

            sqlParameters[7] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[7].Value = email;

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
        public int coutKH()
        {
            string query = "select count(*) from khachhang";
            return conn.executeCount(query);
        }
        public string Picksdt(string sdt)
        {
            string query = "select sodienthoai from khachhang where sodienthoai = @sdt";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[0].Value = sdt;
            return Convert.ToString(conn.executeScalar(query, sqlParameters));
        }
        public string PickMakh(string sdt)
        {
            string sql = "select makhachhang from khachhang where sodienthoai = @sdt";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sdt", SqlDbType.VarChar);
            sqlParameters[0].Value = sdt;
            return Convert.ToString(conn.executeScalar(sql, sqlParameters));
        }
    }
}
