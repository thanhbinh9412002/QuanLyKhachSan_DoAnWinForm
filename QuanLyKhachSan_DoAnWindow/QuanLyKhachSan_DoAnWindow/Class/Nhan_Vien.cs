using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Nhan_Vien
    {
        private string ma_nhan_vien;
        private string ten_nhan_vien;
        private string ngay_sinh;
        private string phai;
        private string dia_chi;
        private string phone;
        private string chuc_vu;

        Nhan_Vien(string ma_nhan_vien,
                  string ten_nhan_vien,
                  string ngay_sinh,
                  string phai,
                  string dia_chi,
                  string phone,
                  string chuc_vu)
        {
            this.ma_nhan_vien = ma_nhan_vien;
            this.ten_nhan_vien = ten_nhan_vien;
            this.ngay_sinh = ngay_sinh;
            this.phai = phai;
            this.dia_chi = dia_chi;
            this.phone = phone;
            this.chuc_vu = chuc_vu;
        }
    }
}
