using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Thue_Phong_BUS
    {
        private Thue_Phong_DAO tpDAO;
        public Thue_Phong_BUS()
        {
            tpDAO = new Thue_Phong_DAO();
        }
    }
}
