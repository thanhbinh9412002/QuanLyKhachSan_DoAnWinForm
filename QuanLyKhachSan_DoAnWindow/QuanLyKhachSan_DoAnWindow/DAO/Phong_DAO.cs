using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Phong_DAO
    {
        private DBConnection conn;
        public Phong_DAO()
        {
            conn = new DBConnection();
        }
    }
}
