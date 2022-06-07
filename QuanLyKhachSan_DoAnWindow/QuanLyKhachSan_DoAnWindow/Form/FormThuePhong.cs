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
    public partial class FormThuePhong : Form
    {
        public FormMain fmMain;
        public FormKhachHang fmKH;
        private Thue_Phong_BUS tpBUS = new Thue_Phong_BUS();
        private Khach_Hang_BUS khBUS = new Khach_Hang_BUS();
        public FormThuePhong()
        {
            InitializeComponent();
        }

        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            this.Datagridview_phong.DataSource = tpBUS.Tim_Phong_Trong();
            this.Datagriwview_danhsach.DataSource = tpBUS.Hien_Thi_Danh_Sach();
            if (radio_dadat.Checked == true)
            {
                txt_maphieudat.Enabled = true;
                txt_maphieuthue.Enabled = false;
                button_maphieuthue.Enabled = false;
            }
        }

        private void Load_Data()
        {
            this.Datagridview_phong.DataSource = tpBUS.Tim_Phong_Trong();
            this.Datagriwview_danhsach.DataSource = tpBUS.Hien_Thi_Danh_Sach();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            this.Datagridview_phong.DataSource = tpBUS.Tim_Phong_Trong();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.Datagridview_phong.Rows[e.RowIndex];
            txt_maphong.Text = dr.Cells[0].Value.ToString();
        }

        private void radio_dadat_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_dadat.Checked == true)
            {
                txt_maphieudat.Enabled = true;
                button_maphieudat.Enabled = true;
                txt_maphieuthue.Enabled = false;
                button_maphieuthue.Enabled = false;
                txt_maphieuthue.Clear();
            }
        }

        private void radio_chuadat_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_chuadat.Checked == true)
            {
                txt_maphieudat.Enabled = false;
                button_maphieudat.Enabled = false;
                txt_maphieuthue.Enabled = true;
                button_maphieuthue.Enabled = true;
                txt_maphieudat.Clear();
            }
        }

        private void button_maphieuthue_Click(object sender, EventArgs e)
        {
            if (tpBUS.Dem_Ma_Phieu_Thue() + 1 < 10)
            {
                txt_maphieuthue.Text = "PT0" + (tpBUS.Dem_Ma_Phieu_Thue() + 1).ToString();
            }
            else
                txt_maphieuthue.Text = "PT" + (tpBUS.Dem_Ma_Phieu_Thue() + 1).ToString();
        }

        private void button_maphieudat_Click(object sender, EventArgs e)
        {
            if (tpBUS.Dem_Ma_Phieu_Dat() + 1 < 10)
            {
                txt_maphieudat.Text = "PD0" + (tpBUS.Dem_Ma_Phieu_Dat() + 1).ToString();
            }
            else
                txt_maphieudat.Text = "PD" + (tpBUS.Dem_Ma_Phieu_Dat() + 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Datagriwview_danhsach.DataSource = tpBUS.Hien_Thi_Danh_Sach(txt_timkiem.Text);
        }

        private void Datagriwview_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.Datagriwview_danhsach.Rows[e.RowIndex];
            string maphong = dr.Cells[2].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)                // kiem tra co click vao button ko
            {
                txt_maphong.Text = dr.Cells[2].Value.ToString();
                txt_tiencoc.Text = dr.Cells[5].Value.ToString();
                txt_songuoi.Text = dr.Cells[6].Value.ToString();
                var datex = DateTime.Parse(dr.Cells[4].Value.ToString());
                date_ngaythuephong.Value = datex;
                txt_sdtkh.Text = tpBUS.Lay_SDT_KH(dr.Cells[3].Value.ToString());
                tabControl1.SelectedTab = tabPage3;         // chuyen qua xem chi tiet
                this.Datagriwview_danhsach2.DataSource = tpBUS.Hien_Thi_Phong(maphong);
                Khach_Hang kh = khBUS.ThongtinKH(txt_sdtkh.Text);
                txt_makhachhang.Text = kh.Ma_khach_hang;
                txt_gioitinh.Text = kh.Gioi_tinh;
                txt_sdt.Text = kh.So_dien_thoai;
                txt_hovaten.Text = kh.Ten_khach_hang;
                txt_cmnd.Text = kh.Cmnd_passport;
                txt_diachi.Text = kh.Dia_chi;
            }
            if (dr.Cells[1].Value.ToString().Contains("PDT"))
            {
                txt_maphieudat.Text = dr.Cells[1].Value.ToString();
                radio_dadat.Checked = true;
                txt_maphieudat2.Text = dr.Cells[1].Value.ToString();
                txt_maphieuthue2.Text = "NULL";
                txt_ngaythue2.Text = dr.Cells[4].Value.ToString();
                txt_tiencoc2.Text = dr.Cells[5].Value.ToString();
                txt_songuoi2.Text = dr.Cells[6].Value.ToString();
            }
                
            else
            {
                txt_maphieuthue.Text = dr.Cells[1].Value.ToString();
                radio_chuadat.Checked = true;
                txt_maphieuthue2.Text = dr.Cells[1].Value.ToString();
                txt_maphieudat2.Text = "NULL";
                txt_ngaythue2.Text = dr.Cells[4].Value.ToString();
                txt_tiencoc2.Text = dr.Cells[5].Value.ToString();
                txt_songuoi2.Text = dr.Cells[6].Value.ToString();

            }
                
            txt_maphong.Text = dr.Cells[2].Value.ToString();
            txt_tiencoc.Text = dr.Cells[5].Value.ToString();
            txt_songuoi.Text = dr.Cells[6].Value.ToString();
            var date = DateTime.Parse(dr.Cells[4].Value.ToString());
            date_ngaythuephong.Value = date;
            txt_sdtkh.Text = tpBUS.Lay_SDT_KH(dr.Cells[3].Value.ToString());
            this.Datagriwview_danhsach2.DataSource = tpBUS.Hien_Thi_Phong(maphong);
            Khach_Hang khx = khBUS.ThongtinKH(txt_sdtkh.Text);
            txt_makhachhang.Text = khx.Ma_khach_hang;
            txt_gioitinh.Text = khx.Gioi_tinh;
            txt_sdt.Text = khx.So_dien_thoai;
            txt_hovaten.Text = khx.Ten_khach_hang;
            txt_cmnd.Text = khx.Cmnd_passport;
            txt_diachi.Text = khx.Dia_chi;
            Load_Data();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string makhachhang = tpBUS.Lay_MaKH_SDT(txt_sdtkh.Text);
            if (radio_dadat.Checked == true)
            {
                tpBUS.Them_Phieu_Thue(txt_maphieudat.Text, txt_maphong.Text, fmMain.musername);
                tpBUS.Them_Phieu_Thue_Chi_Tiet(txt_maphieudat.Text, makhachhang, date_ngaythuephong.Text, txt_tiencoc.Text, txt_songuoi.Text);
            }
            else
            {
                tpBUS.Them_Phieu_Thue(txt_maphieuthue.Text, txt_maphong.Text, fmMain.musername);
                tpBUS.Them_Phieu_Thue_Chi_Tiet(txt_maphieuthue.Text, makhachhang, date_ngaythuephong.Text, txt_tiencoc.Text, txt_songuoi.Text);
            }
            Load_Data();

        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (radio_dadat.Checked == true)
            {
                tpBUS.Xoa_Phieu_Thue(txt_maphieudat.Text);
            }
            else
            {
                tpBUS.Xoa_Phieu_Thue(txt_maphieuthue.Text);
            }
            txt_maphieudat.Clear();
            txt_maphieuthue.Clear();
            txt_maphong.Clear();
            txt_sdtkh.Clear();
            txt_tiencoc.Clear();
            txt_songuoi.Clear();
            Load_Data();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string makhachhang = tpBUS.Lay_MaKH_SDT(txt_sdtkh.Text);
            if (radio_dadat.Checked == true)
            {
                tpBUS.Sua_Phieu_Thue(txt_maphieudat.Text, txt_maphong.Text);
                tpBUS.Sua_Phieu_Thue_Chi_Tiet(txt_maphieudat.Text, makhachhang, date_ngaythuephong.Text, txt_tiencoc.Text, txt_songuoi.Text);
            }
            else
            {
                tpBUS.Sua_Phieu_Thue(txt_maphieuthue.Text, txt_maphong.Text);
                tpBUS.Sua_Phieu_Thue_Chi_Tiet(txt_maphieuthue.Text, makhachhang, date_ngaythuephong.Text, txt_tiencoc.Text, txt_songuoi.Text);
            }
            Load_Data();
        }
    }
}
