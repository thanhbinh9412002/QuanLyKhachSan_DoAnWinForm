using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Dich_Vu_DAO
    {
        private DBConnection conn;
        public Dich_Vu_DAO()
        {
            conn = new DBConnection();
        }
    }
}
