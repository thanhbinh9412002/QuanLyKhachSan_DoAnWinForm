using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using System.Data.SqlClient;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Khach_Hang_DAO
    {
        private DBConnection conn;
        public Khach_Hang_DAO()
        {
            conn = new DBConnection();
        }
        public void themKhachHang(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            const string sql =  "insert into khachhang(makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, coquan, sodienthoai, email) " +
                                "values(@ma, @name, @sex, @cmnd, @address, @coquan, @sdt, @email)";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@ma", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            sqlParameters[1] = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = tenKH;

            sqlParameters[2] = new SqlParameter("@sex", System.Data.SqlDbType.Char);
            sqlParameters[2].Value = gtKH;

            sqlParameters[3] = new SqlParameter("@cmnd", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = cmnd;

            sqlParameters[4] = new SqlParameter("@address", System.Data.SqlDbType.VarChar);
            sqlParameters[4].Value = address;

            sqlParameters[5] = new SqlParameter("@coquan", System.Data.SqlDbType.VarChar);
            sqlParameters[5].Value = coquan;

            sqlParameters[6] = new SqlParameter("@sdt", System.Data.SqlDbType.VarChar);
            sqlParameters[6].Value = sdt;

            sqlParameters[7] = new SqlParameter("@email", System.Data.SqlDbType.VarChar);
            sqlParameters[7].Value = email;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void xoaKhachHang(string maKH)
        {
            const string sql = "Delete from khachhang where makhachhang = @maKH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            
            sqlParameters[0] = new SqlParameter("@maKH", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void capnhatKhachHang(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            const string sql = "update khachhang set tenkhachhang = @name, gioitinh = @sex," +
                " cmnd_passport = @cmnd, diachi = @address, coquan = @coquan, sodienthoai = @sdt, email = @email where makhachhang = @makh ";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@makh", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maKH;

            sqlParameters[1] = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = tenKH;

            sqlParameters[2] = new SqlParameter("@sex", System.Data.SqlDbType.Char);
            sqlParameters[2].Value = gtKH;

            sqlParameters[3] = new SqlParameter("@cmnd", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = cmnd;

            sqlParameters[4] = new SqlParameter("@address", System.Data.SqlDbType.VarChar);
            sqlParameters[4].Value = address;

            sqlParameters[5] = new SqlParameter("@coquan", System.Data.SqlDbType.VarChar);
            sqlParameters[5].Value = coquan;

            sqlParameters[6] = new SqlParameter("@sdt", System.Data.SqlDbType.VarChar);
            sqlParameters[6].Value = sdt;

            sqlParameters[7] = new SqlParameter("@email", System.Data.SqlDbType.VarChar);
            sqlParameters[7].Value = email;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        /*public void loadData()
        {
            string query = "select * from khachhang";

        }*/
    }
}
