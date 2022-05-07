using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class He_Thong
    {
        private string username;
        private string ma_nhan_vien;
        private string password;

        He_Thong(string username, string ma_nhan_vien, string password)
        {
            this.username = username;
            this.ma_nhan_vien = ma_nhan_vien;
            this.password = password;
        }
    }
}
