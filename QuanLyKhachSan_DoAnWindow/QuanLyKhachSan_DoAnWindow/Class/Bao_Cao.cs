using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DoAnWindow.Class
{
    internal class Bao_Cao
    {
        private string ngay;
        private string thang;
        private string nam;
        private string chon;
        public Bao_Cao(string ngay, string thang, string nam, string chon)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
            this.chon = chon;
        }
    }
}
