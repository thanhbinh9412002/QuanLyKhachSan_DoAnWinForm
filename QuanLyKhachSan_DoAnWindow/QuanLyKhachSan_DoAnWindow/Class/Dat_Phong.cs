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
        private string username;
        private string ma_khach_hang;
        private DateTime ngaythue;
        private int so_tien_coc;
        private int so_nguoi;

        public Dat_Phong(string ma_phieu_dat, string ma_phong, string username, string ma_khach_hang, DateTime ngaythue, int so_tien_coc, int so_nguoi)
        {
            this.ma_phieu_dat = ma_phieu_dat;
            this.ma_phong = ma_phong;
            this.username = username;
            this.ma_khach_hang = ma_khach_hang;
            this.ngaythue = ngaythue;
            this.so_tien_coc = so_tien_coc;
            this.so_nguoi = so_nguoi;
        }

        public string Ma_phieu_dat { get => ma_phieu_dat; set => ma_phieu_dat = value; }
        public string Ma_phong { get => ma_phong; set => ma_phong = value; }
        public string Username { get => username; set => username = value; }
        public string Ma_khach_hang { get => ma_khach_hang; set => ma_khach_hang = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        public int So_tien_coc { get => so_tien_coc; set => so_tien_coc = value; }
        public int So_nguoi { get => so_nguoi; set => so_nguoi = value; }
    }
}
