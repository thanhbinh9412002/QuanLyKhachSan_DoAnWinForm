using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Nhan_Vien_DAO
    {
        private DBConnection conn;
        public Nhan_Vien_DAO()
        {
            conn = new DBConnection();
        }
        //them nhan vien
        public void themNV(string ma, string ten, string gt, DateTime date, string diachi, string sdt, string chucvu)
        {
            string sql = "insert into nhanvien(manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu)" +
                "values(@ma, @ten, @date, @gt, @diachi, @phone, @chucvu)";
            SqlParameter[] sqlParameter = new SqlParameter[7];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = ma;
            sqlParameter[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameter[1].Value = ten;
            sqlParameter[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameter[2].Value = date;
            sqlParameter[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameter[3].Value = gt;
            sqlParameter[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameter[4].Value = diachi;
            sqlParameter[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameter[5].Value = sdt;
            sqlParameter[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameter[6].Value = chucvu;

            conn.executeInsertQuery(sql, sqlParameter);

        }
        //cap nhat nhan vien
        public void capnhatNV(string ma, string ten, string gt, DateTime date, string diachi, string sdt, string chucvu)
        {
            string sql = "update nhanvien set tennhanvien = @ten, ngaysinh = @date, phai = @gt, diachi = @diachi, phone = @phone, chucvu = @chucvu" +
                " where manhanvien = @ma";

            SqlParameter[] sqlParameter = new SqlParameter[7];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = ma;
            sqlParameter[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameter[1].Value = ten;
            sqlParameter[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameter[2].Value = date;
            sqlParameter[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameter[3].Value = gt;
            sqlParameter[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameter[4].Value = diachi;
            sqlParameter[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameter[5].Value = sdt;
            sqlParameter[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameter[6].Value = chucvu;

            conn.executeInsertQuery(sql, sqlParameter);
        }
        //xoa nhan vien
        public void xoaNV(string ma)
        {
            string sql = "delete from nhanvien where manhanvien = @ma";
            SqlParameter[] sqlParameter = new SqlParameter[1];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = ma;

            conn.executeInsertQuery(sql, sqlParameter);
        }

        // lay du lieu  - tim kiem theo ten
        public DataTable LoadBangNV(string tenNV)
        {
            string query = "select * from nhanvien where tennhanvien like '%" + tenNV + "%'";
            return conn.executeLoadData(query);
        }

        // dem so luong nhan vien
        public int CountMa()
        {
            string query = "select count(*) from nhanvien";
            return conn.executeCount(query);
        }
    }
}
