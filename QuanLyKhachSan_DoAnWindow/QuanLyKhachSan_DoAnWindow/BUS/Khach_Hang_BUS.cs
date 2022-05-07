using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Khach_Hang_BUS
    {
        private Khach_Hang_DAO khDAO;
        public Khach_Hang_BUS()
        {
            khDAO = new Khach_Hang_DAO();
        }
    }
}
