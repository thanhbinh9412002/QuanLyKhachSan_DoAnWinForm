using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Dat_Phong_BUS
    {
        private Dat_Phong_DAO dpDAO;
        public Dat_Phong_BUS()
        {
            dpDAO = new Dat_Phong_DAO();
        }

        public int Count_Ma_Phieu()
        {
            return dpDAO.Count_Ma_Phieu();
        }

        public DataTable Tim_Phong_Trong()
        {
            return dpDAO.Tim_Phong_Trong();
        }

        public DataTable Hien_Thi_DS()
        {
            return dpDAO.Hien_Thi_DS();
        }

        public DataTable Tim_Kiem_DS(string maphieudat)
        {
            return dpDAO.Tim_Kiem_DS(maphieudat);
        }

        public DataTable Lay_Ma_Phieu()
        {
            return dpDAO.Lay_Ma_Phieu();
        }

        public DataTable Lay_Thong_Tin(string maphieudat)
        {
            return dpDAO.Lay_Thong_Tin(maphieudat);
        }

        public DataTable Tim_Phong_Theo_Ma_Phong(string maphong)
        {
            return dpDAO.Tim_Phong_Theo_Ma_Phong(maphong);
        }

    }
}
