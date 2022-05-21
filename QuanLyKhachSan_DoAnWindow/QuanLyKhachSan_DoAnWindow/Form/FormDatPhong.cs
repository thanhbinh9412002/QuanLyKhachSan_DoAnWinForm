using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_DoAnWindow.BUS;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormDatPhong : Form
    {
        public FormMain fmMain;
        public FormKhachHang fmKH;
        private Dat_Phong_BUS dpBUS = new Dat_Phong_BUS();
        public FormDatPhong()
        {
            InitializeComponent();
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
            this.gvdanhsach.DataSource = dpBUS.Hien_Thi_DS();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
        }
        private void bt_MaPD_Click(object sender, EventArgs e)
        {
            string maphieudat = "PD" + (dpBUS.Count_Ma_Phieu() + 1).ToString();
            txtmapd.Text = maphieudat;
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
            clearInfo();
        }
        private void clearInfo()
        {
            txt_sdtkh.Text = "";
            txt_songuoi.Text = "";
            txt_tiencoc.Text = "";
            date_ngayden.Value = DateTime.Today;
            date_ngaydi.Text = "31/12/2022"; 

        }

        //loc code
        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.gvdanhsach.Rows[e.RowIndex];                 //lay ma phieu dat va ma khach hang tu bang
            string makh = row.Cells[2].Value.ToString();
            string mapd = row.Cells[1].Value.ToString();

            var senderGrid = (DataGridView)sender;                              
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)                // kiem tra co click vao button ko
            {
                tabControl1.SelectedTab = tabPage3;         // chuyen qua xem chi tiet
                loadthongtin(makh, mapd);
            }
        }
        public void loadthongtin(string makh, string mapd)
        {
            loadpage(makh);           // load thong tin chi tiet
            loadinfoRoom(mapd);       // load thong tin phong
        }
        private void loadpage(string makh)          //load thong tin chi tiet khach hang da dat phong
        {
            dpBUS.load_chitiet(lsvChiTiet, makh);
        }

        private void loadinfoRoom(string mapd)  // load thong tin phong cua khach hang
        {
            dpBUS.load_inforoom(lvdp , mapd);
        }
        private void gvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.gvdanhsach.Rows[e.RowIndex];
            txtmapd.Text = row.Cells[1].Value.ToString();
            string makh = row.Cells[2].Value.ToString();
            date_ngayden.Text = row.Cells[3].Value.ToString();
            date_ngaydi.Text = row.Cells[4].Value.ToString();

            // cap nhat page chi tiet va phong theo ma 
            loadthongtin(makh, txtmapd.Text);
            //lay thong tin tu page chi tiet
            txt_sdtkh.Text = lsvChiTiet.Items[5].SubItems[1].Text;      
            txt_songuoi.Text = lsvChiTiet.Items[8].SubItems[1].Text;    
            txt_tiencoc.Text = lsvChiTiet.Items[9].SubItems[1].Text;
        }

        public void laythongtinKH(string sdt)       //lay so dien thoai cua khach hang
        {
            txt_sdtkh.Text = sdt;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)       //quay lai trang truoc
        {
            this.Close();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
