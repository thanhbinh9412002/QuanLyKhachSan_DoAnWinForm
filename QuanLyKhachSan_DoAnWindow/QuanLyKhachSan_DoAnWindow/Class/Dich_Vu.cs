using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Dich_Vu
    {
        private string ma_dich_vu;
        private string ten_dich_vu;
        private int gia;
        private string don_vi_tinh;

        public Dich_Vu(string ma_dich_vu, string ten_dich_vu, int gia, string don_vi_tinh)
        {
            this.ma_dich_vu = ma_dich_vu;
            this.ten_dich_vu = ten_dich_vu;
            this.gia = gia;
            this.don_vi_tinh = don_vi_tinh;
        }
    }
}
