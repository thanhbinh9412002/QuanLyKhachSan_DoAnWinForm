using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using QuanLyKhachSan_DoAnWindow.Class;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Dat_Phong_BUS
    {
        private Dat_Phong_DAO dpDAO;
        public Dat_Phong_BUS()
        {
            dpDAO = new Dat_Phong_DAO();
        }

        public int Count_Ma_Phieu()
        {
            return dpDAO.Count_Ma_Phieu();
        }

        public DataTable Tim_Phong_Trong()
        {
            return dpDAO.Tim_Phong_Trong();
        }

        public DataTable Hien_Thi_DS()
        {
            return dpDAO.Hien_Thi_DS();
        }
        public void load_chitiet(ListView chitiet, string maphong)
        {
            DataTable data = new DataTable();
            data = dpDAO.loadpagechitiet(maphong);

            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    chitiet.Items[i].SubItems[1].Text = row[i].ToString();
                }
            }
        }
        public void load_inforoom(ListView tbphong, string maphong)
        {
            DataTable data = new DataTable();
            data = dpDAO.lay_bangPhong(maphong);

            tbphong.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem();
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                tbphong.Items.Add(item);
            }
            data.Clear();
        }
        //them phieu
        
        public void themPhieu(Dat_Phong dp, string maphong)
        {
            dpDAO.themPhieuDat(dp);
            dpDAO.themchitietPhieuDat(dp);
            dpDAO.capnhatcodatphong(maphong);
        }

        //xoa phieu
        public void xoaPhieu(string maphieu, string maphong)
        {
            dpDAO.xoachitietPhieuDat(maphieu);
            dpDAO.xoaPhieuDat(maphieu);
            dpDAO.capnhatkhongdatphong(maphong);
        }
        //tim kiem theo ten khach hang
        public void TimkiemKH(string tenKH, DataGridView view)
        {
            view.DataSource = dpDAO.laybangtimkiem(tenKH);
        }
    }
}
