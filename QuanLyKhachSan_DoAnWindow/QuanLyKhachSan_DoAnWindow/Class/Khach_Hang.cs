using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Khach_Hang
    {
        private string ma_khach_hang;
        private string ten_khach_hang;
        private string gioi_tinh;
        private string cmnd_passport;
        private string dia_chi;
        private string co_quan;
        private string so_dien_thoai;
        private string email;

        public Khach_Hang(string ma_khach_hang,
                   string ten_khach_hang,
                   string gioi_tinh,
                   string cmnd_passport,
                   string dia_chi,
                   string co_quan,
                   string so_dien_thoai,
                   string email)
        {
            this.ma_khach_hang = ma_khach_hang;
            this.ten_khach_hang = ten_khach_hang;
            this.gioi_tinh = gioi_tinh;
            this.cmnd_passport = cmnd_passport;
            this.dia_chi = dia_chi;
            this.co_quan = co_quan;
            this.so_dien_thoai = so_dien_thoai;
            this.email = email;
        }

        public string Ma_khach_hang { get => ma_khach_hang; set => ma_khach_hang = value; }
        public string Ten_khach_hang { get => ten_khach_hang; set => ten_khach_hang = value; }
        public string Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
        public string Cmnd_passport { get => cmnd_passport; set => cmnd_passport = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Co_quan { get => co_quan; set => co_quan = value; }
        public string So_dien_thoai { get => so_dien_thoai; set => so_dien_thoai = value; }
        public string Email { get => email; set => email = value; }
    }
}
