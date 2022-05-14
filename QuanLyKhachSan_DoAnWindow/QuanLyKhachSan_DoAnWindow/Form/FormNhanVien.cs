using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.BUS;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormNhanVien : Form
    {
        public FormMain fmMain;
        private Nhan_Vien_BUS NVBUS = new Nhan_Vien_BUS();
        public FormNhanVien()
        {
            InitializeComponent();
            LoadNV();
        }

        public void LoadNV()
        {
            NVBUS.LoadNV(gvNhanVien);
            LoadMaNV();
        }

<<<<<<< Updated upstream
        private void FormNhanVien_Load(object sender, EventArgs e)
=======
        private void LoadMaNV()
        {
            txtMaNV.Text = "NV" + NVBUS.LoadManv();
            txtMaNV.Enabled = false;
        }
        private void bt_QLTK_Click(object sender, EventArgs e)          //Chuyen san form Quan ly tai khoan
>>>>>>> Stashed changes
        {
            LoadDataUser();
        }
        private void LoadDataUser()
        {

        }

        private void btThem_Click(object sender, EventArgs e)           //them nhan vien
        {
            string gt = (rbnam.Checked ? rbnam.Text : rbnu.Text);
            NVBUS.ThemNV(txtMaNV.Text, txtTenNV.Text, gt, dtNgaysinh.Value, txtsdt.Text, txtdiachi.Text, txtchucvu.Text);
            LoadNV();
        }

        private void btsua_Click(object sender, EventArgs e)            // cap nhat nhan vien
        {
            string gt = (rbnam.Checked ? rbnam.Text : rbnu.Text);
            NVBUS.SuaNV(txtMaNV.Text, txtTenNV.Text, gt, dtNgaysinh.Value, txtsdt.Text, txtdiachi.Text, txtchucvu.Text);
            LoadNV();
        }

        private void btXoa_Click(object sender, EventArgs e)            // xoa nhan vien
        {
            NVBUS.XoaNV(txtMaNV.Text);
            LoadNV();
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)           // click gribview lay noi dung len cac textbox
        {
            DataGridViewRow row = this.gvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            dtNgaysinh.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            string gt = row.Cells[3].Value.ToString();
            if (gt == "nam" || gt == "Nam")
            {
                rbnam.Checked = true;
            }
            else rbnu.Checked = true;
            txtsdt.Text = row.Cells[4].Value.ToString();
            txtdiachi.Text = row.Cells[5].Value.ToString();
            txtchucvu.Text = row.Cells[6].Value.ToString();
        }

        private void FormNhanVien_Click(object sender, EventArgs e)         // tro ve form ban dau
        {
            LoadNV();
            txtTenNV.Text = "";
            rbnam.Checked = true;
            dtNgaysinh.Value = DateTime.Today;
            txtsdt.Text = "";
            txtdiachi.Text = "";
            txtchucvu.Text = "";
        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)  // thuc hien tim kiem nhan vien
        {
            NVBUS.TimkiemNV(gvNhanVien,txtTimkiem.Text);
        }
    }
}
