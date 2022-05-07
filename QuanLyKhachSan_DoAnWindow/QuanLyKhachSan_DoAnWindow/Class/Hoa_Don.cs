using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Hoa_Don
    {
        private string ma_hoa_don;
        private string ngay_thanh_toan;
        private string tong_tien;
        private string ma_phieu_thue;
        private string ma_khach_hang;
        private string username;

        public Hoa_Don(string ma_hoa_don, string ngay_thanh_toan, string tong_tien, string ma_phieu_thue, string ma_khach_hang, string username)
        {
            this.ma_hoa_don = ma_hoa_don;
            this.ngay_thanh_toan = ngay_thanh_toan;
            this.tong_tien = tong_tien;
            this.ma_phieu_thue = ma_phieu_thue;
            this.ma_khach_hang = ma_khach_hang;
            this.username = username;
        }

    }
}
