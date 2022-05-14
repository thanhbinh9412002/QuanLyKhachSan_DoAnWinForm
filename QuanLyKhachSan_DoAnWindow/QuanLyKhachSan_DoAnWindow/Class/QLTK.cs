using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class QLTK
    {
        private string username;
        private string maNV;
        private string password;

        public QLTK(string username, string maNV, string password)
        {
            this.username = username;
            this.maNV = maNV;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string Password { get => password; set => password = value; }
    }
}
