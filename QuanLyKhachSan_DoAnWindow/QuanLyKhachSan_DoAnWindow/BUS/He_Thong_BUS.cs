using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public string Lay_Ten_Nhan_Vien(string username)
        {
            return htDAO.Lay_Ten_Nhan_Vien(username);
        }

        public void Doi_Mat_Khau(string username, string password)
        {
            htDAO.Doi_Mat_Khau(username, password);
        }

        public string Dem_Phong_Trong()
        {
            return htDAO.Dem_Phong_Trong();
        }

        public string Dem_Phong_Dat()
        {
            return htDAO.Dem_Phong_Dat();
        }

        public string Dem_Phong_Thue()
        {
            return htDAO.Dem_Phong_Thue();
        }

        public DataTable Lay_Data_phong()
        {
            return htDAO.Lay_Data_Phong();
        }
    }
}
