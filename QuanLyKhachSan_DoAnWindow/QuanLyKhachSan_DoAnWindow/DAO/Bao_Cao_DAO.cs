using QuanLyKhachSan_DoAnWindow.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Bao_Cao_DAO
    {
        private DBConnection conn;
        public Bao_Cao_DAO()
        {
            conn = new DBConnection();
            
        }
        public DataTable Lay_Du_Lieu_0()   // lấy dữ liệu để thực hiện việc thống kê hết tất cả
        { 
            string sql = "select mahoadon, ngaythanhtoan, tongtien, maphieuthue, makhachhang  from hoadon ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Du_Lieu_1(string thoigian)   // lấy dữ liệu để thực hiện việc thống kê theo thời gian
        {
            string sql = "select mahoadon, ngaythanhtoan, tongtien, maphieuthue, makhachhang  from hoadon where ngaythanhtoan like '%" + thoigian +"%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public string Lay_Du_Lieu_2(string thoigian, string chon)   // lấy dữ liệu để thực hiện việc tính tổng số háo đơn theo thời gian
        {
            if (chon == "Tat ca")
            {
                string sql = "select count(mahoadon)  from hoadon ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
            else
            {
                string sql = "select count(mahoadon)  from hoadon where ngaythanhtoan like '%" + thoigian + "%'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
        }
        public string Lay_Du_Lieu_3(string thoigian, string chon)   // lấy dữ liệu để thực hiện việc tính tổng số tiền theo thời gian
        {
            if (chon == "Tat ca")
            {
                string sql = "select sum(tongtien)  from hoadon ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }
            else
            {
                string sql = "select sum(tongtien)  from hoadon where ngaythanhtoan like '%" + thoigian + "%'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }    
        }
    }
}
