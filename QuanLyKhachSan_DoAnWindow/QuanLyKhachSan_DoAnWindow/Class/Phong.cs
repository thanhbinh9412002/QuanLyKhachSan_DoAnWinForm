using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Phong
    {
        private string ma_phong;
        private string ma_loai;
        private int gia;
        private int so_nguoi;
        private string da_dat;
        private string da_nhan;
        private string trang_thai;
        
        Phong(string ma_phong,
              string ma_loai,
              int gia,
              int so_nguoi,
              string da_dat,
              string da_nhan,
              string trang_thai)
        {
            this.ma_phong = ma_phong;
            this.ma_loai = ma_loai;
            this.gia = gia;
            this.so_nguoi = so_nguoi;
            this.da_dat = da_dat;
            this.da_nhan = da_nhan;
            this.trang_thai = trang_thai;
        }
    }
}
