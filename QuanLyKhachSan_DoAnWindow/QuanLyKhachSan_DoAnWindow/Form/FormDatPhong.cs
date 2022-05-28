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
        public FormKhachHang fmKH = new FormKhachHang();
        private Dat_Phong_BUS dpBUS = new Dat_Phong_BUS();
        public FormDatPhong()
        {
            InitializeComponent();
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
            this.gvdanhsach.DataSource = dpBUS.Hien_Thi_DS();
            date_ngayden.Value = DateTime.Today;
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
            txt_songuoi.Text = "";
            txt_tiencoc.Text = "";
            date_ngayden.Value = DateTime.Today;
            date_ngaydi.Text = "31/12/2022"; 

        }

        //loc code
        private void gvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gvdanhsach.Rows[e.RowIndex];                 //lay ma phieu dat va ma khach hang tu bang
            string maphong = row.Cells[2].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)                // kiem tra co click vao button ko
            {
                tabControl1.SelectedTab = tabPage3;         // chuyen qua xem chi tiet
                loadthongtin(maphong);
            }
        }
        public void loadthongtin(string maphong)
        {
            loadpage(maphong);           // load thong tin chi tiet
            loadinfoRoom(maphong);       // load thong tin phong
        }
        private void loadpage(string maphong)          //load thong tin chi tiet khach hang da dat phong
        {
            dpBUS.load_chitiet(lsvChiTiet, maphong);
        }

        private void loadinfoRoom(string maphong)  // load thong tin phong cua khach hang
        {
            dpBUS.load_inforoom(lvdp , maphong);
        }
        private void gvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)   // khi nhan vao bang thi page chitiet cap nhat
        {
            try
            {
                DataGridViewRow row = this.gvdanhsach.Rows[e.RowIndex];
                string maphong = row.Cells[2].Value.ToString();
                loadthongtin(maphong);
            }
            catch
            {
                MessageBox.Show("Đừng nhấn vào dòng tiêu đề");
            }
        }

        public void laythongtinKH(string sdt)       //lay so dien thoai khi từ form khach hang sang form datphoong
        {
            txt_sdtkh.Text = sdt;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)       //quay lai trang truoc
        {
            this.Close();
        }

        private int timphong()
        {
            int index = -1;

            /*foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells[radiobutton.Index].Value != null && (bool)row.Cells[radiobutton.Index].Value)
                {
                    index = row.Index;
                }
            }*/

            return index;
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            int index = timphong();
            try
            {
                if(index != -1)
                {
                    string hinhthuc = (radio_offline.Checked ? radio_offline.Text : radio_online.Text);

                    DataGridViewRow row = this.DataGridView1.Rows[index];
                    string maphong = row.Cells[phongcol1.Index].Value.ToString();
                    string maloai = row.Cells[maloaicol.Index].Value.ToString();
                    string dadat = row.Cells[dadatcol.Index].Value.ToString();
                    string danhan = row.Cells[danhancol.Index].Value.ToString();
                    MessageBox.Show(maphong + maloai + danhan + dadat);
                    if (fmKH.checksdt(txt_sdtkh.Text))
                    {
                        dpBUS.Phieudat(txtmapd.Text, maphong, fmMain.musername, hinhthuc);
                        dpBUS.chitietphieu(txtmapd.Text, txt_sdtkh.Text, txt_songuoi.Text, txt_tiencoc.Text, date_ngaydi.Value, date_ngayden.Value);
                        MessageBox.Show("Bạn đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại này chưa có trong dữ liệu khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn phòng!");
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi ở đâu rồi con trai ta!");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*foreach(DataGridViewRow row in DataGridView1.Rows)
            {
                if(row.Cells[radiobutton.Index].Value == null || (bool)row.Cells[radiobutton.Index].Value)
                {
                    row.Cells[radiobutton.Index].Value = 0;
                }    
            }
            DataGridView1.Rows[e.RowIndex].Cells[radiobutton.Index].Value = 1;*/
        }
    }
}
