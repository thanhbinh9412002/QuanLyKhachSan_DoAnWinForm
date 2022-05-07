using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Dat_Phong
    {
        private string ma_phieu_dat;
        private string ma_phong;
        private string ma_khach_hang;
        private string ngay_den;
        private string ngay_di;
        private string so_tien_dat_coc;
        private string username;
        private string tinh_trang;
        private int so_nguoi;

        public Dat_Phong(string ma_phieu_dat, string ma_phong, string ma_khach_hang, string ngay_den, string ngay_di, string so_tien_dat_coc, string username, string tinh_trang, int so_nguoi)
        {
            this.ma_phieu_dat = ma_phieu_dat;
            this.ma_phong = ma_phong;
            this.ma_khach_hang = ma_khach_hang;
            this.ngay_den = ngay_den;
            this.ngay_di = ngay_di;
            this.so_tien_dat_coc = so_tien_dat_coc;
            this.username = username;
            this.tinh_trang = tinh_trang;
            this.so_nguoi = so_nguoi;
        }
    }
}
