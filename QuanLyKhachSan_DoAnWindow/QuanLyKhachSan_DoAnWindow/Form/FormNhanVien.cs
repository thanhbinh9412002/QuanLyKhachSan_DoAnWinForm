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
    public partial class FormNhanVien : Form
    {
        public FormQLTK fmQLTK;
        public FormMain fmMain;
        private Nhan_Vien_BUS nvBUS = new Nhan_Vien_BUS();
        public FormNhanVien()
        {
            InitializeComponent();
            LoadNV();
        }
        
        private void LoadNV()        //  show nhan vien
        {
            nvBUS.upNV(gvNhanvien);
            LoadManv();
        }
        private void LoadManv()     //cap nhat ma nhan vien
        {
            txtMaNV.Text = "NV" + nvBUS.updateMa();
            txtMaNV.Enabled = false;
        }
        private void Load_ThongTin()
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
            string gt = (rbnam.Checked ? rbnam.Text : rbnu.Text);
            nvBUS.ThemNV(txtMaNV.Text, txtTenNV.Text, gt, dtngaysinh.Value, txtdiachi.Text, txtsdt.Text, txtchucvu.Text);
            Load_ThongTin();
        }

        private void btsua_Click(object sender, EventArgs e)        //cap nhat nhan vien
        {
            string gt = (rbnam.Checked ? rbnam.Text : rbnu.Text);
            nvBUS.CapNhatNV(txtMaNV.Text, txtTenNV.Text, gt, dtngaysinh.Value, txtdiachi.Text, txtsdt.Text, txtchucvu.Text);
            Load_ThongTin();
        }

        private void btXoa_Click(object sender, EventArgs e)        // xoa nhan vien
        {
            nvBUS.XoaNV(txtMaNV.Text);
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

        private void FormNhanVien_Click(object sender, EventArgs e)     //chuyen ve form ban dau
        {
            Load_ThongTin();
        }
    }
}
