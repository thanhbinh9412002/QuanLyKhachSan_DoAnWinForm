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

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormQLTK : Form
    {
        public FormMain fmMain;
        public FormNhanVien fmNhanVien;
        private QLTK_BUS TKbus = new QLTK_BUS();
        public FormQLTK()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            TKbus.DisplayQLTK(gvQLTKNV);
            LoadMaNV();
        }
        private void LoadMaNV()
        {
            txt_maNV.Text = TKbus.updateManv();
            txt_maNV.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)          // them tai khoan
        {
            TKbus.themTK(txtTenkh.Text, txtMkh.Text, txt_maNV.Text);
            LoadUser();
        }

        private void btnSua_Click(object sender, EventArgs e)           // cap nhat tai khoan
        {
            TKbus.capnhatTK(txtTenkh.Text, txtMkh.Text, txt_maNV.Text);
            LoadUser();
        }

        private void btnXoa_Click(object sender, EventArgs e)           // xoa tai khoan
        {
            TKbus.xoaTK(txt_maNV.Text);
            LoadUser();
        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)      // tim kiem theo username
        {
            TKbus.DisplayQLTK(gvQLTKNV, txtTimkiem.Text);
        }
    }
}
