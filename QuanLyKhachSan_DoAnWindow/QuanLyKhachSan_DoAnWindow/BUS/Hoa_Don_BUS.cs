using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Hoa_Don_BUS
    {
        private Hoa_Don_DAO hdDAO;
        public Hoa_Don_BUS()
        {
            hdDAO = new Hoa_Don_DAO();
        }
    }
}
