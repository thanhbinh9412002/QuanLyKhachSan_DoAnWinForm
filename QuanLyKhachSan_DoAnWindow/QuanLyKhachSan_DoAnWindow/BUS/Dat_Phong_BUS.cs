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
    }
}
