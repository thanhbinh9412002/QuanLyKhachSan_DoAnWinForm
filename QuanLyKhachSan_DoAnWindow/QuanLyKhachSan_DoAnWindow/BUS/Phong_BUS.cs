using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Phong_BUS
    {
        private Phong_DAO pgDAO;
        public Phong_BUS()
        {
            pgDAO = new Phong_DAO();
        }

        public void Them_Phong(string maphong, string maloai)
        {
            pgDAO.Them_Phong(maphong, maloai);
        }

        public DataTable Lay_Ma_Loai()
        {
            return pgDAO.Lay_Ma_Loai();
        }

        public void Sua_Phong(string maphong, string maloai, string dadat, string danhan)
        {
            pgDAO.Sua_Phong(maphong, maloai, dadat, danhan);
        }

        public void Xoa_Phong(string maphong)
        {
            pgDAO.Xoa_Phong(maphong);
        }

        public DataTable Tim_Phong(string maphong)
        {
            return pgDAO.Tim_Phong(maphong);
        }

        public void Them_Loai_Phong(string maloai, string gia, string songuoi)
        {
            pgDAO.Them_Loai_Phong(maloai, gia, songuoi);
        }

        public DataTable Tim_Loai_Phong(string maloai)
        {
            return pgDAO.Tim_Loai_Phong(maloai);
        }

        public void Sua_Loai_Phong(string maloai, string gia, string songuoi)
        {
            pgDAO.Sua_Loai_Phong(maloai, gia, songuoi);
        }

        public void Xoa_Loai_Phong(string maloai)
        {
            pgDAO.Xoa_Loai_Phong(maloai);
        }
    }
}
