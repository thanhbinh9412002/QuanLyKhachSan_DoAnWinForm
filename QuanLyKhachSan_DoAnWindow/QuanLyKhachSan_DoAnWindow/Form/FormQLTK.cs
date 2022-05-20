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
    public partial class FormQLTK : Form
    {
        public FormMain fmMain;
        public FormNhanVien fmNhanVien;
        private Tai_Khoan_BUS tkBUS = new Tai_Khoan_BUS();
        public FormQLTK()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            tkBUS.upTK(gvQLTKNV);
            LoadMa();
        }
        private void LoadMa()
        {
            tkBUS.updateMa(cbMaNv);
            tkBUS.machucvu(cb_chucvu);
        }
        private void Load_Thongtin()
        {
            LoadUser();
            LoadMa();
            txtTenkh.Text = "";
            txtMkh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tkBUS.themTK(cbMaNv.Text, txtTenkh.Text, txtMkh.Text, cb_chucvu.Text);
            Load_Thongtin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tkBUS.capnhatTK(cbMaNv.Text, txtTenkh.Text, txtMkh.Text, cb_chucvu.Text);
            Load_Thongtin();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tkBUS.xoaTK(cbMaNv.Text);
            Load_Thongtin();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            tkBUS.upTK(gvQLTKNV, txtTimkiem.Text);
        }

        private void gvQLTKNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gvQLTKNV.Rows[e.RowIndex];
            txtTenkh.Text = row.Cells[0].Value.ToString();
            cbMaNv.Text = row.Cells[1].Value.ToString();
            cb_chucvu.Text = row.Cells[2].Value.ToString();
            txtMkh.Text = row.Cells[3].Value.ToString();
        }

        private void FormQLTK_Click(object sender, EventArgs e)
        {
            Load_Thongtin();
        }
    }
}
