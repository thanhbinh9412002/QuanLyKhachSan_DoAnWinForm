using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Phong_BUS
    {
        private Phong_DAO pgDAO;
        public Phong_BUS()
        {
            pgDAO = new Phong_DAO();
        }
    }
}
