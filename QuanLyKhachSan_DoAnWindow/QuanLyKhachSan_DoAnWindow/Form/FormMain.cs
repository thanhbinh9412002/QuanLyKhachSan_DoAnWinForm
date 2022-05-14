using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan_DoAnWindow.BUS;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormMain : Form
    {
        public FormLogin fmLogin;
        public FormDoiMK fmDoiMK;
        public FormKhachHang fmKH;
        public FormThongTin fmTT;
        public FormQLPhong fmP;
        public FormDatPhong fmDP;
        public FormThuePhong fmTP;
        //public FormNguoiDung fmND;
        public FormVatTu fmVT;
        public FormDichVu fmDV;
        public FormNhanVien fmNV;
        public FormBaoCao fmBC;
        public FormInHoaDon fmIHD;

        public String musername = null;
        public String mfullname = null;
        public String mchucvu = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MainNoEnabled();
            fmLogin = new FormLogin();
            fmLogin.fmMain = this;
            fmLogin.ShowDialog();
            if (mchucvu == "admin")
            {
                MainEnabled();
            }
            else
            {
                MainNoEnabled();
            }

            lblUser.Text = "Hi " + mfullname + " !";
            ThongKe();
            LoadData();

        }
        public void ThongKe()
        {
            var htBUS = new He_Thong_BUS();
            string room = htBUS.Dem_Phong_Trong();
            txt_emptyroom.Text = room;
            room = htBUS.Dem_Phong_Dat();
            txt_hireroom.Text = room;
            room = htBUS.Dem_Phong_Dat();
            txt_useroom.Text = room;
        }
        public void LoadData()
        {
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGridView1.DataSource = room;
        }
        private void MainEnabled()
        {
            mnDangnhap.Enabled = false;
            mnQuanly.Enabled = true;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnBaocao.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainNoEnabled()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = false;
            mnKhachhang1.Enabled = false;
            mnDatphong1.Enabled = false;
            mnBaocao.Enabled = false;
            mnDangxuat.Enabled = false;
        }
        private void mnDangnhap_Click(object sender, EventArgs e)
        {
            fmLogin = new FormLogin();
            fmLogin.fmMain = this;
            fmLogin.ShowDialog();
            if (mchucvu == "admin")
            {
                MainEnabled();
            }
            lblUser.Text = "Hi " + mfullname + " !";
        }
        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            fmDoiMK = new FormDoiMK();
            fmDoiMK.fmMain = this;
            fmDoiMK.ShowDialog();
        }
        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnKhachhang_Click(object sender, EventArgs e)
        {
            fmKH = new FormKhachHang();
            fmKH.fmMain = this;
            fmKH.ShowDialog();
        }
        private void mnDatphong_Click(object sender, EventArgs e)
        {
            fmDP = new FormDatPhong();
            fmDP.fmMain = this;
            fmDP.ShowDialog();
        }
        private void mnThuephong_Click(object sender, EventArgs e)
        {
            fmTP = new FormThuePhong();
            fmTP.fmMain = this;
            fmTP.ShowDialog();
        }
        private void mnPhong_Click(object sender, EventArgs e)
        {
            fmP = new FormQLPhong();
            fmP.fmMain = this;
            fmP.ShowDialog();
        }
        private void mnThongtin_Click(object sender, EventArgs e)
        {
            fmTT = new FormThongTin();
            fmTT.fmMain = this;
            fmTT.ShowDialog();
        }
        private void mnVattu_Click(object sender, EventArgs e)
        {
            fmVT = new FormVatTu();
            fmVT.fmMain = this;
            fmVT.ShowDialog();

        }
        private void mnDichvu_Click(object sender, EventArgs e)
        {
            fmDV = new FormDichVu();
            fmDV.fmMain = this;
            fmDV.ShowDialog();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            fmNV = new FormNhanVien();
            fmNV.fmMain = this;
            fmNV.ShowDialog();
        }

        private void mnBaocao_Click(object sender, EventArgs e)
        {
            fmBC = new FormBaoCao();
            fmBC.fmMain = this;
            fmBC.ShowDialog();
        }
        private void mnInhoadon_Click(object sender, EventArgs e)
        {
            fmIHD = new FormInHoaDon();
            fmIHD.fmMain = this;
            fmIHD.ShowDialog();
        }


    }
}