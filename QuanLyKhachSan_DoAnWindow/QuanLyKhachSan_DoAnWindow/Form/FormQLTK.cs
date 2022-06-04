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
    public partial class FormQLTK : Form
    {
        public FormMain fmMain;
        public FormNhanVien fmNhanVien;
        private Tai_khoan TK;
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
            BasicFunstion(1);       //1 = them tai khoan
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            BasicFunstion(2);       //2 = cap nhat tai khoan
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            BasicFunstion(3);       //3 = xoa tai khoan
        }

        private void BasicFunstion(int i)
        {
            TK = new Tai_khoan(cbMaNv.Text, txtTenkh.Text, txtMkh.Text, cb_chucvu.Text);
            switch (i)
            {
                case 1: tkBUS.themTK(TK);       break;      //them tai khoan
                case 2: tkBUS.capnhatTK(TK);    break;      //cap nhat tai khoan
                case 3: tkBUS.xoaTK(TK);        break;      //xoa tai khoan
            }
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
