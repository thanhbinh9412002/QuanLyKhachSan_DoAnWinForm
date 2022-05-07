using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Thue_Phong_DAO
    {
        private DBConnection conn;
        public Thue_Phong_DAO()
        {
            conn = new DBConnection();
        }
    }
}
