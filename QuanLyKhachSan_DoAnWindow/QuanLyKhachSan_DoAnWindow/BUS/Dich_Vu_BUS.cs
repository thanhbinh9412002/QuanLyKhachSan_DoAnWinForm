using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Dich_Vu_BUS
    {
        private Dich_Vu_DAO dvDAO;
        public Dich_Vu_BUS()
        {
            dvDAO = new Dich_Vu_DAO();
        }

        public DataTable Lay_Du_lieu()
        {
            return dvDAO.Lay_Du_lieu();
        }

        public DataTable Lay_Data_Bang()
        {
            return dvDAO.Lay_Data_Bang();
        }

        public string Lay_Ma_Phong(string maphieuthue)
        {
            return dvDAO.Lay_Ma_Phong(maphieuthue);
        }

        public string Lay_Ngay(string maphieuthue)
        {
            return dvDAO.Lay_Ngay(maphieuthue);
        }

        public string Lay_So_Luong(string maphieuthue)
        {
            return dvDAO.Lay_So_Luong(maphieuthue);
        }

        public string Lay_Ma_Dich_Vu(string maphieuthue)
        {
            return dvDAO.Lay_Ma_Dich_Vu(maphieuthue);
        }

        public string Lay_Ten_DV(string madichvu)
        {
            return dvDAO.Lay_Ten_DV(madichvu);
        }
    }
}
