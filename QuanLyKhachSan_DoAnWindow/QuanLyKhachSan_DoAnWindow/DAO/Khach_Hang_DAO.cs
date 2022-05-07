using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Khach_Hang_DAO
    {
        private DBConnection conn;
        public Khach_Hang_DAO()
        {
            conn = new DBConnection();
        }
    }
}
