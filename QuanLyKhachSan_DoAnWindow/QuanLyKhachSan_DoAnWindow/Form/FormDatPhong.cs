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
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormDatPhong : Form
    {
        public FormMain fmMain;
        public FormKhachHang fmKH = new FormKhachHang();
        private Dat_Phong_BUS dpBUS = new Dat_Phong_BUS();
        private Dat_Phong DP;
        private string username;
        public FormDatPhong(string user = "")
        {
            InitializeComponent();
            loadthongtin();
            date_ngaythue.Value = DateTime.Today;
            this.username = user;
        }

        private void bt_MaPD_Click(object sender, EventArgs e)          //nút New để tạo mã phiếu mới
        {
            string maphieudat = "PD" + (dpBUS.Count_Ma_Phieu() + 1).ToString();
            txtmapd.Text = maphieudat;
            loadtable_phong();
            clearInfo();
        }

        private void clearInfo()    //làm trống textbox
        {
            txt_songuoi.Text = "1";
            txt_tiencoc.Text = "";
            date_ngaythue.Value = DateTime.Today;

        }

        public void loadthongtin(string maphong = "")
        {
           if(maphong != "")
                loadpage_chitiet(maphong);           // load page chi tiet
           else
            {
                loadpage_danhsach();                //load page danh sach
                loadtable_phong();                  //load bang phong
            }    

        }
        private void loadpage_chitiet(string maphong)         
        {
            dpBUS.load_chitiet(lsvChiTiet, maphong);        //Load page chi tiet khach hang da dat phong
            dpBUS.load_inforoom(lvdp, maphong);             //load bang phong trong page chitiet
        }

        private void loadpage_danhsach()
        {
            this.gvdanhsach.DataSource = dpBUS.Hien_Thi_DS();     //load page danh sach      
        }

        private void loadtable_phong()
        {
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();    //load bang phong
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            txt_timkiem.Clear();
        }

        private void gvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gvdanhsach.Rows[e.RowIndex];                 //lay ma phieu dat va ma khach hang tu bang
            string maphong = row.Cells[2].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)                // kiem tra co click vao button ko
            {
                tabControl1.SelectedTab = tabPage3;         // chuyen qua xem chi tiet
                loadthongtin(maphong);
            }
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

        //##################################################################################################//
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)                // ham xu ly: chi dc phep chon 1 phong
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)       // kiem tra da chon trong hang du lieu va dung cot checkbox  
            {
                foreach (DataGridViewRow row in DataGridView1.Rows)     // chay vong lap tat ca hang
                {
                    row.Cells["radiobutton"].Value = false;             //cho tat ca hang la false value
                    if(row.Index == e.RowIndex)             // neu hang do la hang duoc chon thi gan true value
                    {
                        row.Cells["radiobutton"].Value = !Convert.ToBoolean(row.Cells["radiobutton"].EditedFormattedValue);
                        if (Convert.ToBoolean(row.Cells["radiobutton"].Value))          // thong bao so phong da chon
                        {
                            MessageBox.Show("Bạn chọn phòng: " + row.Cells[1].Value);
                        }
                    }
                }
            }   
        }
        private int index_row;
        private bool ChoosePhong()          //kiem tra da chon phong chua
        {
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["radiobutton"].Value))
                {
                    index_row = row.Index;
                    return true;
                }
            }
            MessageBox.Show("Bạn chưa chọn phòng!");
            return false;
        }
        private string layMaphong()
        {
            string maphong = "";
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Index == index_row)
                {
                    maphong = row.Cells[1].Value.ToString();
                }
            }
            return maphong;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            try //kiem tra chuc nang
            {
                if (!string.IsNullOrWhiteSpace(txt_sdtkh.Text))         //kiem tra textbox khong để trống hay để khoảng trăng
                {
                    string maphong = "";
                    maphong = layMaphong();
                    if (ChoosePhong() && fmKH.checksdt(txt_sdtkh.Text) && !string.IsNullOrEmpty(maphong))     // kiem tra đã chọn phong và đúng sdt khach hang hay khong
                    {
                        Khach_Hang_BUS kh = new Khach_Hang_BUS();
                        Khach_Hang KH = kh.ThongtinKH(txt_sdtkh.Text);
                        DP = new Dat_Phong(txtmapd.Text, maphong, username, KH.Ma_khach_hang, date_ngaythue.Value, Convert.ToInt32(txt_tiencoc.Text), Convert.ToInt32(txt_songuoi.SelectedItem));
                        dpBUS.themPhieu(DP, maphong);

                        loadthongtin();
                        MessageBox.Show("Bạn đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã thêm thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại!");
                }
            }
            catch
            {
                MessageBox.Show("Bạn đã gặp lỗi!");
            }
        }

        //##################################################################################################//
        //xoa thong tin dat phong
        private void btnDEL_Click(object sender, EventArgs e)
        {
            int index = gvdanhsach.CurrentCell.RowIndex;
            string khachhang = gvdanhsach.Rows[index].Cells[3].Value.ToString();
            if (MessageBox.Show("Xác minh trước khi tiến hành" + "\n\n" + "Bạn có muốn tiếp tục" + "\n" + "Xóa khách hàng " + khachhang +" không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maphieu = gvdanhsach.Rows[index].Cells[1].Value.ToString();
                string maphong = gvdanhsach.Rows[index].Cells[2].Value.ToString();
                dpBUS.xoaPhieu(maphieu, maphong);
                MessageBox.Show("Bạn đã xóa thành công!");
                loadthongtin();
            }
        }
        //tim kiem theo ten khach hang da dat phong
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_timkiem.Text))
            {
                dpBUS.TimkiemKH(txt_timkiem.Text, gvdanhsach);
            }
            else
            {
                loadthongtin();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}