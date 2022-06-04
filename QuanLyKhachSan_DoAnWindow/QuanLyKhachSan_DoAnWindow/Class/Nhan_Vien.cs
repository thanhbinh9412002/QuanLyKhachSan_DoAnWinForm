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
        private DateTime ngay_sinh;
        private string phai;
        private string dia_chi;
        private string phone;
        private string chuc_vu;

        public Nhan_Vien(string ma_nhan_vien,
                  string ten_nhan_vien,
                  DateTime ngay_sinh,
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

        public string Ma_nhan_vien { get => ma_nhan_vien; set => ma_nhan_vien = value; }
        public string Ten_nhan_vien { get => ten_nhan_vien; set => ten_nhan_vien = value; }
        public DateTime Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Chuc_vu { get => chuc_vu; set => chuc_vu = value; }
    }
}
