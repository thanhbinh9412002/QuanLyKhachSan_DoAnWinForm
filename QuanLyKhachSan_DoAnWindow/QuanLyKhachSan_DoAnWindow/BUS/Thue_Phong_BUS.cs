using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Thue_Phong_BUS
    {
        private Thue_Phong_DAO tpDAO;
        public Thue_Phong_BUS()
        {
            tpDAO = new Thue_Phong_DAO();
        }

        public DataTable Tim_Phong_Trong()
        {
            return tpDAO.Tim_Phong_Trong();
        }

        public DataTable Hien_Thi_Danh_Sach()
        {
            return tpDAO.Hien_Thi_Danh_Sach();
        }

        public DataTable Hien_Thi_Danh_Sach(string maphieu)
        {
            return tpDAO.Hien_Thi_Danh_Sach(maphieu);
        }

        public DataTable Hien_Thi_Phong(string maphong)
        {
            return tpDAO.Hien_Thi_Phong(maphong);
        }

        public int Dem_Ma_Phieu_Dat()
        {
            return tpDAO.Dem_Ma_Phieu_Dat();
        }

        public int Dem_Ma_Phieu_Thue()
        {
            return tpDAO.Dem_Ma_Phieu_Thue();
        }
    }
}
