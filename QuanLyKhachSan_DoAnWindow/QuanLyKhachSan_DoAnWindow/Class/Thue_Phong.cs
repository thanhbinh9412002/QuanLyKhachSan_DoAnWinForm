using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Thue_Phong
    {
        private string ma_phieu_thue;
        private string ma_phieu_dat;
        private string username;
        private string ma_phong;
        private string ngay;
        private string ma_dich_vu;
        private int so_luong;

        public Thue_Phong(string ma_phieu_thue, string ma_phieu_dat, string username, string ma_phong, string ngay, string ma_dich_vu, int so_luong)
        {
            this.ma_phieu_thue = ma_phieu_thue;
            this.ma_phieu_dat = ma_phieu_dat;
            this.username = username;
            this.ma_phong = ma_phong;
            this.ngay = ngay;
            this.ma_dich_vu = ma_dich_vu;
            this.so_luong = so_luong;
        }

    }
}
