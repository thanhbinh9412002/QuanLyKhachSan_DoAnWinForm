using QuanLyKhachSan_DoAnWindow.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.Class;

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
            string sql = "select * from hoadon ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Du_Lieu_1(string ngay, string thang, string nam)   // lấy dữ liệu để thực hiện việc thống kê theo ngay
        {
            string sql = "select *  from hoadon where DAY(ngaythanhtoan)='" + ngay + "' and MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Du_Lieu_2(string thang, string nam)   // lấy dữ liệu để thực hiện việc thống kê theo thang
        {
            string sql = "select *  from hoadon where MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Du_Lieu_3(string nam)   // lấy dữ liệu để thực hiện việc thống kê theo nam
        {
            string sql = "select *  from hoadon where YEAR(ngaythanhtoan)='" + nam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public string Lay_Du_Lieu_4(string ngay, string thang, string nam, string chon)   // lấy dữ liệu để thực hiện việc tính tổng số hóa đơn theo thời gian
        {
            if (chon == "Tat ca")
            {
                string sql = "select count(mahoadon)  from hoadon ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
            else if (chon == "Ngay")
            {
                string sql = "select count(mahoadon)  from hoadon where DAY(ngaythanhtoan)='" + ngay + "' and MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
            else if (chon == "Thang")
            {
                string sql = "select count(mahoadon)  from hoadon where MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
            else
            {
                string sql = "select count(mahoadon)  from hoadon where YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object soluong = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(soluong);
            }
        }
        public string Lay_Du_Lieu_5(string ngay, string thang, string nam, string chon)   // lấy dữ liệu để thực hiện việc tính tổng số tiền theo thời gian
        {
            if (chon == "Tat ca")
            {
                string sql = "select sum(tongtien)  from hoadon ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }
            else if (chon == "Ngay")
            {
                string sql = "select sum(tongtien) from hoadon where DAY(ngaythanhtoan)='" + ngay + "' and MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }
            else if (chon == "Thang")
            {
                string sql = "select sum(tongtien)  from hoadon where MONTH(ngaythanhtoan)='" + thang + "' and YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }
            else
            {
                string sql = "select sum(tongtien)  from hoadon where YEAR(ngaythanhtoan)='" + nam + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                object sotien = conn.executeScalar(sql, sqlParameters);
                return Convert.ToString(sotien);
            }
        }
    }
}
