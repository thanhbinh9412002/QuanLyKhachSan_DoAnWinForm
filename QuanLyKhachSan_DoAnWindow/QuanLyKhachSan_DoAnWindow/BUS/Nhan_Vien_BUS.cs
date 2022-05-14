using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Nhan_Vien_BUS
    {
        private Nhan_Vien_DAO nvDAO;
        public Nhan_Vien_BUS()
        {
            nvDAO = new Nhan_Vien_DAO();
        }
    }
}
