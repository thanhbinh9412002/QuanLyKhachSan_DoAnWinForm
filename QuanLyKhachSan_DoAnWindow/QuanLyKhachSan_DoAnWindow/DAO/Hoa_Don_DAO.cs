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
    internal class Hoa_Don_DAO
    {
        private DBConnection conn;
        public Hoa_Don_DAO()
        {
            conn = new DBConnection();
        }
        public DataTable Lay_Du_Lieu(string mahoadon)   // lấy dữ liệu để thực hiện việc tìm kiếm theo mã hóa đơn 
        {
            string sql = "select mahoadon, ngaythanhtoan, tongtien, maphieuthue, makhachhang  from hoadon where mahoadon like '%"+ mahoadon + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Du_Lieu_2(string makhachhang)  // lấy dữ liệu để thực hiện việc tìm kiếm theo mã khách hàng
        {
            string sql = "select mahoadon, ngaythanhtoan, tongtien, maphieuthue, makhachhang  from hoadon where makhachhang like '%" + makhachhang + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
    }
}
