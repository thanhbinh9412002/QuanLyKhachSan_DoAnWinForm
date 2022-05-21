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

        public DataTable Hien_Thi_DS()
        {
            string sql = "select maphieudat, makhachhang, ngayden, ngaydi, songuoi from phieudatphong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable bang = new DataTable();
            bang = conn.executeReader(sql, sqlParameters);
            return bang;
        }

        public DataTable loadpagechitiet(string makh)           // tao ra bang thong tin chi tiet nhu tren form
        {
            string query = "select khachhang.makhachhang, tenkhachhang, gioitinh, cmnd_passport, diachi, sodienthoai, ngayden, ngaydi, songuoi, sotiendatcoc " +
                            "from khachhang inner join phieudatphong on khachhang.makhachhang = phieudatphong.makhachhang " +
                            "where khachhang.makhachhang = '" + makh + "'";
            return conn.executeLoadData(query);
        }
        //lay thong tin ve loai phong cua ma phieu dat
        public DataTable lay_bangPhong(string mapd)
        {
            string query = "select maphong, loaiphong.maloai, songuoi,gia " +
                "from phong inner join loaiphong on phong.maloai = loaiphong.maloai " +
                "where phong.maphong =  (select maphong from chitietdatphong where maphieudat = @mapd) ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mapd", SqlDbType.Char);
            sqlParameters[0].Value = mapd;

            return conn.executeReader(query, sqlParameters);
        }
    }
}
