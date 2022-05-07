using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Dat_Phong_BUS
    {
        private Dat_Phong_DAO dpDAO;
        public Dat_Phong_BUS()
        {
            dpDAO = new Dat_Phong_DAO();
        }
    }
}
