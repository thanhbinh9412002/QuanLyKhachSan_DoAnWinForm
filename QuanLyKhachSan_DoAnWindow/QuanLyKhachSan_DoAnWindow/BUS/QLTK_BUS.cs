using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Windows.Forms;


namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class QLTK_BUS
    {
        private QLTK_DAO tkDAO;
        public QLTK_BUS()
        {
            tkDAO = new QLTK_DAO();
        }

        //them tai khoan
        public void themTK(string user, string pass, string maNV)
        {
            tkDAO.themTaiKhoan(user, pass, maNV);
        }

        //cap nhat tai khoan
        public void capnhatTK(string user, string pass, string maNV)
        {
            tkDAO.suaTaiKhoan(user, pass, maNV);
        }

        //xoa tai khoan
        public void xoaTK(string maNV)
        {
            tkDAO.xoataikhoan(maNV);
        }

        // show du lieu len gribview    //show ket qua tim kiem theo tai khoan
        public void DisplayQLTK(DataGridView data, string user = "")
        {
            data.DataSource = tkDAO.LoadbangQL(user);        
        }
        
        public string updateManv()
        {
            int count = tkDAO.CountMa() + 1;
            return count.ToString();
        }


    }
}
