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
            string sql =    "select phieudatphong.maphieudat, phieudatphong.maphong, khachhang.tenkhachhang, chitietdatphong.sotiencoc, chitietdatphong.ngaydi, chitietdatphong.songuoi " +
                            "from phieudatphong, khachhang, chitietdatphong " +
                            "where khachhang.makhachhang = chitietdatphong.makhachhang and phieudatphong.maphieudat = chitietdatphong.maphieudat " +
                            "order by ngaydi DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }
        public DataTable loadpagechitiet(string maphong)           // tao ra bang thong tin chi tiet nhu tren form
        {
            string query =  "select khachhang.makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, sodienthoai, ngayden, ngaydi, songuoi, sotiencoc " +
                            "from khachhang inner join chitietdatphong on khachhang.makhachhang = chitietdatphong.makhachhang  " +
                            "where chitietdatphong.maphieudat = (select maphieudat from phieudatphong where maphong = '" + maphong + "')";
            return conn.executeLoadData(query);
        }
        //lay thong tin ve loai phong cua ma phieu dat
        public DataTable lay_bangPhong(string maphong)
        {
            string query = "select phong.maphong, loaiphong.maloai, songuoi, gia " +
                           "from phong, loaiphong " +
                           "where loaiphong.maloai = phong.maloai and phong.maphong = @phong";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@phong", SqlDbType.Char);
            sqlParameters[0].Value = maphong;

            return conn.executeReader(query, sqlParameters);
        }

        //them phieu dat phong
        public void Themphieu(string maphieu, string maphong, string user)
        {
            string sql = "insert into phieudatphong(maphieudat,maphong,username) " +
                "values(@ma, @phong, @user)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameters[0].Value = maphieu;

            sqlParameters[1] = new SqlParameter("@phong", SqlDbType.Char);
            sqlParameters[1].Value = maphong;

            sqlParameters[2] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[2].Value = user;

            conn.executeInsertQuery(sql, sqlParameters);
        }
         
        //cap nhat thong tin cua phong
        public void upPhong(string maphong, string hinhthuc)
        {
            string sql = "update phong set danhan = @nhan, dadat = @dat where maphong = @maphong";

            SqlParameter[] sqlParameter = new SqlParameter[3];

            sqlParameter[0] = new SqlParameter("@maphong", SqlDbType.Char);
            sqlParameter[0].Value = maphong;

            sqlParameter[1] = new SqlParameter("@dat", SqlDbType.Char);
            sqlParameter[2] = new SqlParameter("@nhan", SqlDbType.Char);

            sqlParameter[1].Value = "co";
            sqlParameter[2].Value = "co";
            if (hinhthuc == "online")
            {
                sqlParameter[1].Value = "khong";
            }

            conn.executeInsertQuery(sql, sqlParameter);
        }
        //them chi tiet dat phong
        public void themchitiet(string maphieu, string makh, string songuoi, string tiencoc, DateTime di, DateTime den)
        {
            string sql = "insert into chitietdatphong(maphieudat, makhachhang, ngayden, ngaydi, sotiencoc, songuoi)" +
                " values(@ma, @kh, @den, @di, @tien, @nguoi)";
            SqlParameter[] sqlParameter = new SqlParameter[6];

            sqlParameter[0] = new SqlParameter("@ma", SqlDbType.Char);
            sqlParameter[0].Value = maphieu;

            sqlParameter[1] = new SqlParameter("@kh", SqlDbType.Char);
            sqlParameter[1].Value = makh;

            sqlParameter[2] = new SqlParameter("@den", SqlDbType.DateTime);
            sqlParameter[2].Value = den;

            sqlParameter[3] = new SqlParameter("@di", SqlDbType.DateTime);
            sqlParameter[3].Value = di;

            sqlParameter[4] = new SqlParameter("@tien", SqlDbType.Char);
            sqlParameter[4].Value = tiencoc;

            sqlParameter[5] = new SqlParameter("@nguoi", SqlDbType.Int);
            sqlParameter[5].Value = Convert.ToInt32(songuoi);

            conn.executeInsertQuery(sql, sqlParameter);
        }
    }
}
