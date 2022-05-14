using QuanLyKhachSan_DoAnWindow.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormKhachHang : Form
    {
        private Khach_Hang_BUS KHBUS = new Khach_Hang_BUS();
        public FormMain fmMain;

        public FormKhachHang()
        {
            InitializeComponent();
            LoadView();
        }
        private void LoadView()          // Load datagirbview
        {
            KHBUS.LoadData(gvKhachhang);
            Load_MaKH();
        }

        private void Load_MaKH()        // Load mã khách hàng
        {
            int count = 0;
            count = KHBUS.CoutKH() + 1;
            txtMkh.Text = "KH" + count.ToString();
            txtMkh.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)          // thêm khách hàng
        {
            string gt = (rdNam.Checked ? rdNam.Text : rdNu.Text);
            KHBUS.themKH(txtMkh.Text, txtTenkh.Text, gt, txtCmnd.Text, txtDiachi.Text,
                txtCoquan.Text, txtSodt.Text, txtEmail.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)           // cập nhật khách  hàng
        {
            string gt = (rdNam.Checked ? rdNam.Text : rdNu.Text);
            KHBUS.capnhatKH(txtMkh.Text, txtTenkh.Text, gt, txtCmnd.Text, txtDiachi.Text,
                txtCoquan.Text, txtSodt.Text, txtEmail.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)       // xóa khách hàng
        {
            KHBUS.xoaKH(txtMkh.Text);
        }

        private void gvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)        // click vào girbview các textbox sẽ hiển thị nội dung
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

        private void FormKhachHang_Click(object sender, EventArgs e)        // click vào form để trở về form ban đầu
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

        private void gvKhachhang_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)  //enter se tim kiem   
        {
            if (e.KeyCode == Keys.Enter)
            {
                KHBUS.TimKiemKH(gvKhachhang, txtTimkiem.Text);
            }
        }

        private void txtCmnd_KeyDown(object sender, KeyEventArgs e) // enter chuyen sang textbox diachi
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiachi.Focus();
            }
        }

        private void txtDiachi_KeyDown(object sender, KeyEventArgs e) // enter chuyen sang textbox coquan
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCoquan.Focus();
            }

        }

        private void txtCoquan_KeyDown(object sender, KeyEventArgs e)   //enter chuyen sang textbox sdt
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSodt.Focus();
            }
        }

        private void txtSodt_KeyDown(object sender, KeyEventArgs e) //enter chuyen sang textbox email
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

    }
}
