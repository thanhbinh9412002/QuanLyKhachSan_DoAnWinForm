using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan_DoAnWindow.BUS;
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormKhachHang : Form
    {
        private Khach_Hang_BUS KHBUS = new Khach_Hang_BUS();
        public FormMain fmMain;
        public FormDatPhong fmDP;
        public FormThuePhong fmTP;
        private Khach_Hang KH;
        private string username;
        public FormKhachHang(string user ="")
        {
            InitializeComponent();
            Load_ThongTin();
            this.username = user;
        }
        private void LoadView()          // Load datagirbview
        {
            KHBUS.LoadData(gvKhachhang);
            Load_MaKH();
            gvKhachhang.Sort(gvKhachhang.Columns[0], ListSortDirection.Ascending);
        }

        private void Load_MaKH()        // Load mã khách hàng
        {
            int count = 0;
            count = KHBUS.CoutKH() + 1;
            txtMkh.Text = "KH" + count.ToString();
            txtMkh.Enabled = false;
        }

        private void Load_ThongTin()
        {
            txtTenkh.Text = "";
            rdNam.Enabled = true;
            txtCmnd.Text = "";
            txtDiachi.Text = "";
            txtCoquan.Text = "";
            txtSodt.Text = "";
            txtEmail.Text = "";
            LoadView();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BasicFuntions(1);
        }
            
        private void btnSua_Click(object sender, EventArgs e)
        {
            BasicFuntions(2);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BasicFuntions(3);
        }

        private void BasicFuntions(int i) // chuc nang co ban
        {
            string gt = (rdNam.Checked ? rdNam.Text : rdNu.Text);
            KH = new Khach_Hang(txtMkh.Text, txtTenkh.Text, gt, txtCmnd.Text, txtDiachi.Text, txtCoquan.Text, txtSodt.Text, txtEmail.Text);
            switch (i)
            {
                case 1:
                    KHBUS.themKH(KH);           //thêm khach hang
                    Load_ThongTin();
                    break;
                case 2:
                    KHBUS.capnhatKH(KH);        //cap nhat khach hang
                    break;
                case 3:
                    KHBUS.xoaKH(KH);            //xoa khach hang
                    break;
            }
            Load_ThongTin();
        }


        private void gvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)        // click vào girbview các textbox sẽ hiển thị nội dung
        {
            try
            {
                DataGridViewRow row = this.gvKhachhang.Rows[e.RowIndex];
                txtMkh.Text = row.Cells[0].Value.ToString();
                txtTenkh.Text = row.Cells[1].Value.ToString();
                string gt = row.Cells[2].Value.ToString();
                if (gt == "nam")
                {
                    rdNam.Enabled = true;
                }
                else rdNu.Enabled = true;
                txtCmnd.Text = row.Cells[3].Value.ToString();
                txtDiachi.Text = row.Cells[4].Value.ToString();
                txtCoquan.Text = row.Cells[5].Value.ToString();
                txtSodt.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Đừng nhấn vào dòng tiêu đề");
            }
            gvKhachhang.Sort(gvKhachhang.Columns[0], ListSortDirection.Ascending);
        }

        

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)  //enter se tim kiem   
        {
            if (e.KeyCode == Keys.Enter)
            {
                KHBUS.TimKiemKH(gvKhachhang, txtTimkiem.Text);
            }
        }

        private void bt_newMa_Click(object sender, EventArgs e)
        {
            Load_ThongTin();
        }

        public bool checksdt(string sdt)
        {
            if (!string.IsNullOrEmpty(sdt))
            {
                Khach_Hang kh = KHBUS.ThongtinKH(sdt);
                if (kh.So_dien_thoai == sdt)
                    return true;
                MessageBox.Show("Số điện thoại này chưa có trong dữ liệu khách hàng");
            }
            return false;
        }

        private void bt_datphong_Click(object sender, EventArgs e)
        {
            fmDP = new FormDatPhong(username);
            if (!string.IsNullOrEmpty(txtSodt.Text))
            {
                fmDP.laythongtinKH(txtSodt.Text);
                fmDP.fmKH = this;
                fmDP.Text = "Đặt phòng - " + username;
                fmDP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiện chưa có số điện thoại");
            }
        }

        private void bt_thuephong_Click(object sender, EventArgs e)
        {
            fmTP = new FormThuePhong();
            //fmTP.fmKH = this;
            fmTP.ShowDialog();
        }

        private void bt_Traphong_Click(object sender, EventArgs e)
        {

        }
    }
}
