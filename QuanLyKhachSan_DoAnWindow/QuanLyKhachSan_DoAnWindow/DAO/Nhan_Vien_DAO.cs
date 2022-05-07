using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Nhan_Vien_DAO
    {
        private DBConnection conn;
        public Nhan_Vien_DAO()
        {
            DBConnection = new DBConnection();
        }
    }

    
}
