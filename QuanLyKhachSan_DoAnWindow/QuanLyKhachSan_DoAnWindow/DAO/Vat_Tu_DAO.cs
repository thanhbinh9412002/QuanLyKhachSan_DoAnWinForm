using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Vat_Tu_DAO
    {
        private DBConnection conn;
        public Vat_Tu_DAO()
        {
            conn = new DBConnection();
        }
    }
}
