using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Khach_Hang_BUS
    {
        private Khach_Hang_DAO khDAO;
        public Khach_Hang_BUS()
        {
            khDAO = new Khach_Hang_DAO();
        }
        public void themKH(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            khDAO.themKhachHang(maKH, tenKH, gtKH, cmnd, address, coquan, sdt, email);
        }
        public void xoaKH(string maKH)
        {
            khDAO.xoaKhachHang(maKH);
        }
        public void capnhatKH(string maKH, string tenKH, string gtKH, string cmnd, string address, string coquan, string sdt, string email)
        {
            khDAO.capnhatKhachHang(maKH, tenKH, gtKH, cmnd, address, coquan, sdt, email);
        }
        public void LoadData(DataGridView data)
        {
            data.DataSource = khDAO.loadData();
        }
        public int CoutKH()
        {
            return khDAO.coutKH();
        }
        public void TimKiemKH(DataGridView data, string tenKH)
        {
            data.DataSource = khDAO.loadData(tenKH);
        }
        public bool Checksdt(string sdt)
        {
            if(sdt == khDAO.Picksdt(sdt))
            {
                return true;
            }
            return false;
        }
    }
}
