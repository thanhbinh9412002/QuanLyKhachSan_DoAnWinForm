using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using QuanLyKhachSan_DoAnWindow.Class;
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
        public void ThemNV(Nhan_Vien nv)
        {
            nvDAO.themNV(nv);
        }
        //cap nhat nhan vien
        public void CapNhatNV(Nhan_Vien nv)
        {
            nvDAO.capnhatNV(nv);
        }
        //xoa nhan vien
        public void XoaNV(Nhan_Vien nv)
        {
            nvDAO.xoaNV(nv);
        }
        // day du lieu len gribview
        public void upNV(DataGridView data, string tenNV = "")
        {
            data.DataSource = nvDAO.LoadBangNV(tenNV);
        }
        //cap nhat ma nhan vien
        public int updateMa()
        {
            string strma = nvDAO.CountMa();
            return Convert.ToInt32(strma.Substring(2)) + 1;
        }
    }
}
