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

        public string Lay_SDT_KH(string makhachhang)
        {
            return tpDAO.Lay_SDT_KH(makhachhang);
        }

        public string Lay_MaKH_SDT(string sodienthoai)
        {
            return tpDAO.Lay_MaKH_SDT(sodienthoai);
        }

        public void Them_Phieu_Thue(string maphieu, string maphong, string username)
        {
            tpDAO.Them_Phieu_Thue(maphieu, maphong, username);
        }

        public void Sua_Phieu_Thue(string maphieu, string maphong)
        {
            tpDAO.Sua_Phieu_Thue(maphieu,maphong);
        }

        public void Them_Phieu_Thue_Chi_Tiet(string maphieu, string makhachhang, string ngaythuephong, string sotiencoc, string songuoi)
        {
            tpDAO.Them_Phieu_Thue_Chi_Tiet(maphieu, makhachhang, ngaythuephong, sotiencoc, songuoi);   
        }

        public void Sua_Phieu_Thue_Chi_Tiet(string maphieu, string makhachhang, string ngaythuephong, string sotiencoc, string songuoi)
        {
            tpDAO.Sua_Phieu_Thue_Chi_Tiet(maphieu, makhachhang, ngaythuephong, sotiencoc, songuoi);
        }

        public void Xoa_Phieu_Thue(string maphieu)
        {
            tpDAO.Xoa_Phieu_Thue(maphieu);
        }
    }
}
