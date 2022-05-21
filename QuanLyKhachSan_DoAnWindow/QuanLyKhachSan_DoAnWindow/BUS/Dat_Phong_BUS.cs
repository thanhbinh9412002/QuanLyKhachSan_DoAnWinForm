using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
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
        public void load_chitiet(ListView chitiet, string makh)
        {
            DataTable data = new DataTable();
            data = dpDAO.loadpagechitiet(makh);

            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    chitiet.Items[i].SubItems[1].Text = row[i].ToString();
                }
            }
        }
        public void load_inforoom(ListView tbphong, string mapd)
        {
            DataTable data = new DataTable();
            data = dpDAO.lay_bangPhong(mapd);

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
    }
}
