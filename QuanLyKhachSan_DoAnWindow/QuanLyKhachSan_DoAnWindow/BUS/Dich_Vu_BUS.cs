using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Dich_Vu_BUS
    {
        private Dich_Vu_DAO dvDAO;
        public Dich_Vu_BUS()
        {
            dvDAO = new Dich_Vu_DAO();
        }
    }
}
