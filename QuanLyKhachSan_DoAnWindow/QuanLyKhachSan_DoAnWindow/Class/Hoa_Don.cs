using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Hoa_Don
    {
        private string mahoadon;
        private string makhachhang;
        private string manhanvien;
        private string ngaythanhtoan;
        private string maphieuthue;
        private int sotiencoc;
        private int songayo;
        private int sotienkhuyenmai;
        private int tongtien;
        private string madichvu;
        private int soluong;
        private int thanhtien;
        private TextBox txt_mahoadon;
        private string txt_makhachhang;
        private string txt_manhanvien;
        private DateTime txt_ngaythanhtoan;
        private string txt_maphieuthue;
        private int txt_tiendatcoc;
        private int txt_songayo;
        private int txt_khuyenmai;
        private int txt_tongtien;
        private string txt_madichvu;
        private TextBox txt_tendichvu;
        private object p;

        public Hoa_Don(string mahoadon, string makhachhang, string manhanvien, string ngaythanhtoan, string maphieuthue, 
            int sotiencoc, int songayo, int sotienkhuyenmai, int tongtien, string madichvu, int soluong, int thanhtien)
        {
            this.mahoadon = mahoadon;
            this.makhachhang = makhachhang;
            this.manhanvien = manhanvien;
            this.ngaythanhtoan = ngaythanhtoan;
            this.maphieuthue = maphieuthue;
            this.sotiencoc = sotiencoc;
            this.songayo = songayo;
            this.sotienkhuyenmai = sotienkhuyenmai;
            this.tongtien = tongtien;
            this.madichvu = madichvu;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }

        public Hoa_Don(TextBox txt_mahoadon, string txt_makhachhang, string txt_manhanvien, DateTime txt_ngaythanhtoan, string txt_maphieuthue, int txt_tiendatcoc, int txt_songayo, int txt_khuyenmai, int txt_tongtien, string txt_madichvu, TextBox txt_tendichvu, object p)
        {
            this.txt_mahoadon = txt_mahoadon;
            this.txt_makhachhang = txt_makhachhang;
            this.txt_manhanvien = txt_manhanvien;
            this.txt_ngaythanhtoan = txt_ngaythanhtoan;
            this.txt_maphieuthue = txt_maphieuthue;
            this.txt_tiendatcoc = txt_tiendatcoc;
            this.txt_songayo = txt_songayo;
            this.txt_khuyenmai = txt_khuyenmai;
            this.txt_tongtien = txt_tongtien;
            this.txt_madichvu = txt_madichvu;
            this.txt_tendichvu = txt_tendichvu;
            this.p = p;
        }

        public string Ma_hoa_don { get => mahoadon; set => mahoadon = value; }
        public string Ma_khach_hang { get => makhachhang; set => makhachhang = value; }
        public string Ma_nhan_vien { get => manhanvien; set => manhanvien = value; }
        public string Ngay_thanh_toan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public string Ma_phieu_thue { get => maphieuthue; set => maphieuthue = value; }
        public int So_tien_coc { get => sotiencoc; set => sotiencoc = value; }
        public int So_ngay_o { get => songayo; set => songayo = value; }
        public int So_tien_khuyen_mai { get => sotienkhuyenmai; set => sotienkhuyenmai = value; }
        public int Tong_tien { get => tongtien; set => tongtien = value; }
        public string Ma_dich_vu { get => madichvu; set => madichvu = value; }
        public int So_luong { get => soluong; set => soluong = value; }
        public int Thanh_tien { get => thanhtien; set => thanhtien = value; }


    }
}
