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
    public partial class FormNhanVien : Form
    {
        public FormQLTK fmQLTK;
        public FormMain fmMain;
        private Nhan_Vien_BUS nvBUS;
        private Nhan_Vien NV;
        public FormNhanVien()
        {
            nvBUS = new Nhan_Vien_BUS();
            InitializeComponent();
            LoadNV();
        }


        private void bt_new_Click(object sender, EventArgs e)
        {
            Load_ThongTin();
        }
        private void LoadNV()        //show nhan vien
        {
            nvBUS.upNV(gvNhanvien);
            LoadManv();
        }
        private void LoadManv()     //cap nhat ma nhan vien
        {
            txtMaNV.Text = "NV" + Convert.ToString(nvBUS.updateMa());
            txtMaNV.Enabled = false;
        }
        private void Load_ThongTin()    //chay tat ca du lieu can thiet
        {
            LoadNV();
            txtTenNV.Text = "";
            dtngaysinh.Value = DateTime.Today;
            rbnam.Checked = true;
            txtsdt.Text = "";
            txtdiachi.Text = "";
            txtchucvu.Text = "";
        }
        private void bt_QLTK_Click(object sender, EventArgs e)      //chuyen qua form QLTKNV
        {
            fmQLTK = new FormQLTK();
            fmQLTK.fmNhanVien = this;
            fmQLTK.ShowDialog();
        }

        private void btThem_Click(object sender, EventArgs e)       // them nhan vien
        {
            BasicFunstion(1);
        }

        private void btsua_Click(object sender, EventArgs e)        //cap nhat nhan vien
        {
            BasicFunstion(2);
        }

        private void btXoa_Click(object sender, EventArgs e)        // xoa nhan vien
        {
            if (MessageBox.Show("Xác minh trước khi tiến hành" + "\n\n" + "Bạn có muốn tiếp tục" + "\n" + "Xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BasicFunstion(3);
            }
        }
        private void BasicFunstion(int i)           //tong hop cac chuc nang co ban
        {
            string gt = (rbnam.Checked ? rbnam.Text : rbnu.Text);
            NV = new Nhan_Vien(txtMaNV.Text, txtTenNV.Text, dtngaysinh.Value, gt, txtdiachi.Text, txtsdt.Text, txtchucvu.Text);
            switch (i)
            {
                case 1:
                    nvBUS.ThemNV(NV);
                    break;
                case 2:
                    nvBUS.CapNhatNV(NV);
                    break;
                case 3:
                    nvBUS.XoaNV(NV);
                    break;
            }
            Load_ThongTin();
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)     // tim kiem theo ten nhan vien
        {
            nvBUS.upNV(gvNhanvien, txtTimkiem.Text);
        }

        private void gvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)   // dua du lieu xuong cac testbox
        {
            DataGridViewRow row = this.gvNhanvien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            dtngaysinh.Text = row.Cells[2].Value.ToString();
            string gt = row.Cells[3].Value.ToString();
            if (gt == "nam" || gt == "Nam")
            {
                rbnam.Checked = true;
            }
            else rbnu.Checked = true;
            txtdiachi.Text = row.Cells[4].Value.ToString();
            txtsdt.Text = row.Cells[5].Value.ToString();
            txtchucvu.Text = row.Cells[6].Value.ToString();
        }
    }
}
