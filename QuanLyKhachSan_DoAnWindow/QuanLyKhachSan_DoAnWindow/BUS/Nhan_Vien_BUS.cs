using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Nhan_Vien_BUS
    {
        private Nhan_Vien_DAO nvDAO;
        public Nhan_Vien_BUS()
        {
            nvDAO = new Nhan_Vien_DAO();
        }
        public void ThemNV(string ma, string ten, string gt, DateTime date, string phone, string diachi, string chucvu)     //them nhan vien
        {
            nvDAO.themNhanVien(ma, ten, gt, date, phone, diachi, chucvu);
        }
        public void SuaNV(string ma, string ten, string gt, DateTime date, string phone, string diachi, string chucvu)        // sua nhan vien
        {
            nvDAO.suaNhanVien(ma, ten, gt, date, phone, diachi, chucvu);
        }
        public void XoaNV(string ma)            //xoa nhan vien
        {
            nvDAO.xoaNhanVien(ma);
        }
        public void LoadNV(DataGridView data)          //load data nhan vien      
        {
            data.DataSource = nvDAO.LoadNV();
        }
        public string LoadManv()            // tao ma nhan vien
        {
            int cout = nvDAO.loadManv() + 1;
            return cout.ToString();
        }
        public void TimkiemNV(DataGridView data, string tenNV)      //up bang len girb view
        {
            data.DataSource = nvDAO.timkiemNV(tenNV);
        }
    }
}
