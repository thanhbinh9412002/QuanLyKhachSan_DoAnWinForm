using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Tai_khoan
    {
        private string ma_nhan_vien;
        private string username;
        private string password;
        private string chuc_vu;

        public Tai_khoan(string ma_nhan_vien, string username, string password, string chuc_vu)
        {
            this.ma_nhan_vien = ma_nhan_vien;
            this.username = username;
            this.password = password;
            this.chuc_vu = chuc_vu;
        }

        public string Ma_nhan_vien { get => ma_nhan_vien; set => ma_nhan_vien = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Chuc_vu { get => chuc_vu; set => chuc_vu = value; }
    }
}
