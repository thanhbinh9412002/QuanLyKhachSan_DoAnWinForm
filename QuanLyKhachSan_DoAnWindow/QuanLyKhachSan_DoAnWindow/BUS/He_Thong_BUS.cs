using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class He_Thong_BUS
    {
        private He_Thong_DAO htDAO;
        public He_Thong_BUS()
        {
            htDAO = new He_Thong_DAO();
        }

        public string Check_Tai_Khoan(string username)
        {
            return htDAO.Check_Tai_Khoan(username);
        }
    }
}
