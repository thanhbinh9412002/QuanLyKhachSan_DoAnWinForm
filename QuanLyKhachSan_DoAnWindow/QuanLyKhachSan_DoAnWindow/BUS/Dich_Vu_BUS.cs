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

        public DataTable Lay_Du_lieu_2()
        {
            return dvDAO.Lay_Du_lieu_2();
        }

        public DataTable Tim_Phieu_Thue_Phong(string maphieuthue)
        {
            return dvDAO.Tim_Phieu_Thue_Phong(maphieuthue);
        }

        public DataTable Tim_Dich_Vu(string madichvu)
        {
            return dvDAO.Tim_Dich_Vu(madichvu);
        }

        public DataTable Lay_Data_Bang_2()
        {
            return dvDAO.Lay_Data_Bang_2();
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

        public void Them_DV_Phong(string maphieuthue, string maphong, string madichvu, string ngay, string soluong)
        {
            dvDAO.Them_DV_Phong(maphieuthue, maphong, madichvu, ngay, soluong);
        }

        public void Sua_DV_Phong(string maphieuthue, string maphong, string madichvu, string ngay, string soluong)
        {
            dvDAO.Sua_DV_Phong(maphieuthue, maphong, madichvu, ngay, soluong);
        }

        public void Xoa_DV_Phong(string maphieuthue, string maphong)
        {
            dvDAO.Xoa_DV_Phong(maphieuthue, maphong);
        }

        public void Them_DV(string madichvu, string tendichvu, string gia, string donvitinh)
        {
            dvDAO.Them_DV(madichvu, tendichvu, gia, donvitinh);
        }

        public void Sua_DV(string madichvu, string tendichvu, string gia, string donvitinh)
        {
            dvDAO.Sua_DV(madichvu, tendichvu, gia, donvitinh);
        }

        public void Xoa_DV(string madichvu)
        {
            dvDAO.Xoa_DV(madichvu);
        }
    }
}
