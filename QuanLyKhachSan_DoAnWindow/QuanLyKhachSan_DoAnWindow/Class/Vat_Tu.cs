using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Vat_Tu
    {
        private string ma_vat_tu;
        private string ten_vat_tu;
        private int so_luong;
        private string ma_loai_phong;

        Vat_Tu(string ma_vat_tu,
               string ten_vat_tu,
               int so_luong,
               string ma_loai_phong)
        {
            this.ma_vat_tu = ma_vat_tu;
            this.ten_vat_tu = ten_vat_tu;
            this.so_luong = so_luong;
            this.ma_loai_phong = ma_loai_phong;
        }
    }
}
