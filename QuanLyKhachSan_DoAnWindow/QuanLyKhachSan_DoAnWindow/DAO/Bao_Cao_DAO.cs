using QuanLyKhachSan_DoAnWindow.DataProvider;
using System;
using System.Collections.Generic;
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
        public string Xuat_So_Hoa_Don()   // lấy dữ liệu để thực hiện việc tìm kiếm theo mã hóa đơn 
        {
            //string sql = "select count (mahoadon) from hoadon";
            string hoadon = null;
            return hoadon;
        }
    }
}
