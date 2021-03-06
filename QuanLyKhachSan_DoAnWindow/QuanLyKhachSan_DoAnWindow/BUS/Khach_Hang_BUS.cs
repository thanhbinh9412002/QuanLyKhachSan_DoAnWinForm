using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Windows.Forms;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Khach_Hang_BUS
    {
        private Khach_Hang_DAO khDAO;
        private Dat_Phong_DAO dpDAO;
        public Khach_Hang_BUS()
        {
            khDAO = new Khach_Hang_DAO();
            dpDAO = new Dat_Phong_DAO();
        }
        public void themKH(Khach_Hang kh)
        {
            khDAO.themKhachHang(kh);
        }
        public void xoaKH(Khach_Hang kh)
        {
            khDAO.xoaKhachHang(kh);
        }
        public void capnhatKH(Khach_Hang kh)
        {
            khDAO.capnhatKhachHang(kh);
        }
        public void LoadData(DataGridView data)
        {
            data.DataSource = khDAO.loadData();
        }
        public int CoutKH()
        {
            string strma = khDAO.coutKH();
            string ma = strma.Substring(2);
            return  Convert.ToInt32(ma);
        }
        public void TimKiemKH(DataGridView data, string tenKH)
        {
            data.DataSource = khDAO.loadData(tenKH);
        }
    
        public Khach_Hang ThongtinKH(string sdt)
        {
            DataTable data = khDAO.KH(sdt);

            DataRow row = data.Rows[0];

            Khach_Hang kh = new Khach_Hang(
                row["makhachhang"].ToString(),
                row["tenkhachhang"].ToString(),
                row["gioitinh"].ToString(),
                row["cmnd_passport"].ToString(),
                row["diachi"].ToString(),
                row["coquan"].ToString(),
                row["sodienthoai"].ToString(),
                row["email"].ToString()
             );

            return kh;
        }
        public bool CheckKH(string ma)
        {
            if( ma == dpDAO.CheckKH(ma))
                return true;
            return false;
        }
    }
}
