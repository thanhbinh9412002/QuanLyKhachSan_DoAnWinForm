using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Phong_DAO
    {
        private DBConnection conn;
        public Phong_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable Lay_Ma_Loai()
        {
            const string sql = "select maloai from loaiphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable phieuthue = new DataTable();
            phieuthue = conn.executeReader(sql, sqlParameters);
            return phieuthue;
        }

        public void Them_Phong(string maphong, string maloai)
        {
            const string sql = "insert into phong(maphong, maloai, dadat, danhan) values(@maphong, @maloai, 'khong', 'khong')";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);

            sqlParameters[1] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(maloai);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_Phong(string maphong, string maloai, string dadat, string danhan)
        {
            const string sql = "update phong set  maloai=@maloai, dadat=@dadat, danhan=@danhan where maphong=@maphong";
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);

            sqlParameters[1] = new SqlParameter("@dadat", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(dadat);

            sqlParameters[2] = new SqlParameter("@danhan", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(danhan);

            sqlParameters[3] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Xoa_Phong(string maphong)
        {
            const string sql = "delete from phieuthuephong where maphong=@maphong; " +
                               "delete from phieudatphong where maphong =@maphong; " +
                               "delete from trangthaiphong where maphong = @maphong;" +
                               "delete from phong where maphong = @maphong; ";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@maphong", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maphong);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable Tim_Phong(string maphong)
        {
            string sql = "select * from phong where maphong like '%"+maphong+"%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang= new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public void Them_Loai_Phong(string maloai, string gia, string songuoi)
        {
            const string sql = "insert into loaiphong(maloai, gia, songuoi) values(@maloai, @gia, @songuoi)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);

            sqlParameters[1] = new SqlParameter("@gia", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(gia);

            sqlParameters[2] = new SqlParameter("@songuoi", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(songuoi);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void Sua_Loai_Phong(string maloai, string gia, string songuoi)
        {
            const string sql = "update loaiphong set gia=@gia, songuoi=@songuoi where maloai=@maloai";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@gia", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(gia);

            sqlParameters[1] = new SqlParameter("@songuoi", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(songuoi);

            sqlParameters[2] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(maloai);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public string Lay_Ma_Phong(string maloai)
        {
            const string sql = "select count(maphong) from phong where maloai=@maloai";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public string Lay_Ma_Vat_Tu(string maloai)
        {
            const string sql = "select count(mavattu) from chitietvattu where maloai=@maloai";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);
            object temp = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(temp);
        }

        public void Xoa_Loai_Phong(string maloai)
        {
            string maphong = Lay_Ma_Phong(maloai);
            var pgBUS = new Phong_DAO();
            if (maphong != "0")
            {
                MessageBox.Show("Bạn chưa xoá các phòng liên quan đến loại phòng này!");
                return;
            }
            string mavattu = Lay_Ma_Vat_Tu(maloai);
            var vtBUS = new Vat_Tu_DAO();
            if (mavattu != "0")
            {
                MessageBox.Show("Bạn chưa xoá các vật tư liên quan đến loại phòng này!");
                return;
            }

            const string sql = "delete from loaiphong where maloai=@maloai;";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@maloai", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(maloai);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable Tim_Loai_Phong(string maloai)
        {
            string sql = "select * from loaiphong where maloai like '%" + maloai + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
    }
}
