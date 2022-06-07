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
    internal class Nhan_Vien_DAO
    {
        private DBConnection conn;
        public Nhan_Vien_DAO()
        {
            conn = new DBConnection();
        }
        //them nhan vien
        public void themNV(Nhan_Vien nv)
        {
            string sql = "insert into nhanvien(manhanvien, tennhanvien, ngaysinh, phai, diachi, phone, chucvu)" +
                "values(@ma, @ten, @date, @gt, @diachi, @phone, @chucvu)";
            SqlParameter[] sqlParameter = new SqlParameter[7];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = nv.Ma_nhan_vien;
            sqlParameter[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameter[1].Value = nv.Ten_nhan_vien;
            sqlParameter[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameter[2].Value = nv.Ngay_sinh;
            sqlParameter[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameter[3].Value = nv.Phai;
            sqlParameter[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameter[4].Value = nv.Dia_chi;
            sqlParameter[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameter[5].Value = nv.Phone;
            sqlParameter[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameter[6].Value = nv.Chuc_vu;

            conn.executeInsertQuery(sql, sqlParameter);

        }
        //cap nhat nhan vien
        public void capnhatNV(Nhan_Vien nv)
        {
            string sql = "update nhanvien set tennhanvien = @ten, ngaysinh = @date, phai = @gt, diachi = @diachi, phone = @phone, chucvu = @chucvu" +
                " where manhanvien = @ma";

            SqlParameter[] sqlParameter = new SqlParameter[7];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = nv.Ma_nhan_vien;
            sqlParameter[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameter[1].Value = nv.Ten_nhan_vien;
            sqlParameter[2] = new SqlParameter("@date", SqlDbType.DateTime);
            sqlParameter[2].Value = nv.Ngay_sinh;
            sqlParameter[3] = new SqlParameter("@gt", SqlDbType.VarChar);
            sqlParameter[3].Value = nv.Phai;
            sqlParameter[4] = new SqlParameter("@diachi", SqlDbType.VarChar);
            sqlParameter[4].Value = nv.Dia_chi;
            sqlParameter[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameter[5].Value = nv.Phone;
            sqlParameter[6] = new SqlParameter("@chucvu", SqlDbType.VarChar);
            sqlParameter[6].Value = nv.Chuc_vu;

            conn.executeInsertQuery(sql, sqlParameter);
        }
        //xoa nhan vien
        public void xoaNV(Nhan_Vien nv)
        {
            string sql = "delete from nhanvien where manhanvien = @ma";
            SqlParameter[] sqlParameter = new SqlParameter[1];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = nv.Ma_nhan_vien;

            conn.executeInsertQuery(sql, sqlParameter);
        }

        // lay du lieu  - tim kiem theo ten
        public DataTable LoadBangNV(string tenNV)
        {
            string query = "select * from nhanvien where tennhanvien like '%" + tenNV + "%'";
            return conn.executeLoadData(query);
        }

        // dem so luong nhan vien
        public string CountMa()
        {
            string query = "SELECT Max(manhanvien) FROM nhanvien";
            SqlParameter[] sql = new SqlParameter[0];
            return Convert.ToString(conn.executeScalar(query, sql));
        }

        // check co nhan vien ko 
        public bool checkNV(string ma)
        {
            string query = "select manhanvien from nhanvien where manhanvien = @ma";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0]= new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = ma;
            Object check = conn.executeScalar(query, sqlParameters);
            if (check != null)
                return true;
            return false;
        }
    }
}
