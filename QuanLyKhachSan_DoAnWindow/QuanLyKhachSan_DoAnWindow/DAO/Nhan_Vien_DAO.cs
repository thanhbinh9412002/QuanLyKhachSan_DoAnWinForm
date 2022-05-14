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
    internal class Nhan_Vien_DAO
    {
        private DBConnection conn;
        public Nhan_Vien_DAO()
        {
            conn = new DBConnection();
        }
        //them nhan vien
        public void themNhanVien(string ma, string ten, string gt, DateTime date, string phone, string diachi, string chucvu)       
        {
            const string sql = "insert into nhanvien(manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu)" +
                " values(@ma, @ten, @date, @gt, @diachi, @phone, @chucvu)";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameters[1].Value = ten;

            sqlParameters[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameters[2].Value = date;

            sqlParameters[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameters[3].Value = gt;

            sqlParameters[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameters[4].Value = diachi;

            sqlParameters[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameters[5].Value = phone;

            sqlParameters[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameters[6].Value = chucvu;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        // cap nhat nhan vien
        public void suaNhanVien(string ma, string ten, string gt, DateTime date, string phone, string diachi, string chucvu)
        {
            const string sql = "Update nhanvien set tennhanvien = @ten, ngaysinh = @date, phai = @gt, diachi = @diachi, phone = @phone, chucvu = @chucvu " +
                "where manhanvien = @ma";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameters[1].Value = ten;

            sqlParameters[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameters[2].Value = date;

            sqlParameters[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameters[3].Value = gt;

            sqlParameters[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameters[4].Value = diachi;

            sqlParameters[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameters[5].Value = phone;

            sqlParameters[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameters[6].Value = chucvu;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        //xoa nhan vien
        public void xoaNhanVien(string ma)
        {
            const string sql = "Delete from nhanvien where manhanvien = @ma";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable LoadNV()           // load bang nhan vien
        {
            string sql = "select * from nhanvien";
            return conn.executeLoadData(sql);
        }
        public int loadManv()              // dem so luong nhan vien
        {
            string sql = "select count(*) from nhanvien";
            return conn.executeCount(sql);
        }
        public DataTable timkiemNV(string tenNV)       // bang tim kiem theo ten nhan vien
        {
            string sql = "select * from nhanvien where tennhanvien like '%" + tenNV + "%'";
            return conn.executeLoadData(sql);
        }
    }
}
