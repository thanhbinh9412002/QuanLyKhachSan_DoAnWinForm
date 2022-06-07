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

        public DataTable ThongTinKhachHang(string mahoadon)
        {
            return hdDAO.ThongTinKhachHang(mahoadon);
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
        public DataTable Lay_Cac_Cot(string mahoadon)
        {
            return hdDAO.Lay_Cac_Cot(mahoadon);
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

        public void Them_Chi_Tiet_Dich_Vu(Hoa_Don hd)
        {
            hdDAO.Them_Chi_Tiet_Dich_Vu(hd);
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
        public void TraPhong(string mahoadon, string dadat, string danhan)
        {
            hdDAO.TraPhong(mahoadon, dadat, danhan);
        }
        // dùng để xuất ra excel

        public string TenKhachHang(string mahoadon)
        {
            return hdDAO.TenKhachHang(mahoadon);
        }
        public string SoDienThoai(string mahoadon)
        {
            return hdDAO.SoDienThoai(mahoadon);
        }
        public string DiaChi(string mahoadon)
        {
            return hdDAO.DiaChi(mahoadon);
        }
        public string SoDichVu(string mahoadon)
        {
            return hdDAO.SoDichVu(mahoadon);
        }
        public DataTable ThongTinHoaDon(string mahoadon)
        {
            return hdDAO.ThongTinHoaDon(mahoadon);
        }
        public string TongTien(string mahoadon)
        {
            return hdDAO.TongTien(mahoadon);
        }
        public string NhanVienBan(string mahoadon)
        {
            return hdDAO.NhanVienBan(mahoadon);
        }
    }
}
