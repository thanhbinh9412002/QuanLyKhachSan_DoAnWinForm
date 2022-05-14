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
        //them nhan vien
        public void ThemNV(string ma, string ten, string gt, DateTime date, string diachi, string sdt, string chucvu)
        {
            nvDAO.themNV(ma, ten, gt, date, diachi, sdt, chucvu);
        }
        //cap nhat nhan vien
        public void CapNhatNV(string ma, string ten, string gt, DateTime date, string diachi, string sdt, string chucvu)
        {
            nvDAO.capnhatNV(ma, ten, gt, date, diachi, sdt, chucvu);
        }
        //xoa nhan vien
        public void XoaNV(string ma)
        {
            nvDAO.xoaNV(ma);
        }
        // day du lieu len gribview
        public void upNV(DataGridView data, string tenNV = "")
        {
            data.DataSource = nvDAO.LoadBangNV(tenNV);
        }
        //cap nhat ma nhan vien
        public string updateMa()
        {
            int count = nvDAO.CountMa() + 1;
            return count.ToString();
        }
    }
}
