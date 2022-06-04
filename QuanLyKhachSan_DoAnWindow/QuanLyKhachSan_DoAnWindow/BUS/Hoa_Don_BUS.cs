using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Hoa_Don_BUS
    {
        private Hoa_Don_DAO hdDAO;
        public Hoa_Don_BUS()
        {
            hdDAO = new Hoa_Don_DAO();
        }
        public DataTable Lay_Ma_Khach_Hang()
        {
            return hdDAO.Lay_Ma_Khach_Hang();
        }
        public DataTable Lay_Ma_Nhan_Vien()
        {
            return hdDAO.Lay_Ma_Nhan_Vien();
        }
        public DataTable Lay_Ma_Phieu_Thue()
        {
            return hdDAO.Lay_Ma_Phieu_Thue();
        }
        public DataTable Lay_Ma_Dich_Vu()
        {
            return hdDAO.Lay_Ma_Dich_Vu();
        }
        public DataTable Lay_Danh_Sach_Hoa_Don(string mahoadon)
        {
            return hdDAO.Lay_Danh_Sach_Hoa_Don(mahoadon);
        }
        public DataTable Lay_Cac_Cot()
        {
            return hdDAO.Lay_Cac_Cot();
        }
        public string Lay_Ma_Hoa_Don()
        {
            return hdDAO.Lay_Ma_Hoa_Don();
        }
        public DataTable Lay_So_Tien_Coc()
        {
            return hdDAO.Lay_So_Tien_Coc();
        }
        public int Tinh_Tong_So_Ngay_O(string makhachhang, DateTime ngaythanhtoan)
        {
            return hdDAO.Tinhsongayo(makhachhang, ngaythanhtoan);
        }
        public void Luu_Hoa_Don(Hoa_Don hd)
        {
            hdDAO.Luu_Hoa_Don(hd);
        }
        public string Lay_Ten_Dich_Vu(string madichvu)
        {
            return hdDAO.Lay_Ten_Dich_Vu(madichvu);
        }
        public string Lay_Gia_Dich_Vu(string madichvu)
        {
            return hdDAO.Lay_Gia_Dich_Vu(madichvu);
        }
        public string Lay_Don_Vi_Dich_Vu(string madichvu)
        {
            return hdDAO.Lay_Don_Vi_Dich_Vu(madichvu);
        }

        /* public DataTable Chitiethoadon(string mahoadon)
         {
             return hdDAO.Chitiethoadon(mahoadon);
         }*/
    }
}
