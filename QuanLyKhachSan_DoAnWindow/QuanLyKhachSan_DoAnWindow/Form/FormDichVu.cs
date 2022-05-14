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

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormDichVu : Form
    {
        public FormMain fmMain;
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.phieuthuephong' table. You can move, or remove it, as needed.
            //this.phieuthuephongTableAdapter.Fill();
            var dvBUS = new Dich_Vu_BUS();
            DataTable dt = new DataTable();
            dt = dvBUS.Lay_Du_lieu();
            combo_maphieuthue.DataSource = dt;
            combo_maphieuthue.DisplayMember = "maphieuthue";
            combo_maphieuthue.ValueMember = "maphieuthue";
            combo_maphieuthue.BindingContext = this.BindingContext;
            this.dataGridView1.DataSource = dvBUS.Lay_Data_Bang();
        }

        private void combo_maphieuthue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            string maphieu = combo_maphieuthue.SelectedValue.ToString();
            string dulieu = dvBUS.Lay_Ma_Phong(maphieu);
            txt_maphong.Text = dulieu;
            dulieu = dvBUS.Lay_Ma_Dich_Vu(maphieu);
            combo_madichvu.Text = dulieu;
            dulieu = dvBUS.Lay_Ngay(maphieu);
            txt_date.Text = dulieu;
            dulieu = dvBUS.Lay_So_Luong(maphieu);
            txt_soluong.Text = dulieu;
            dulieu = dvBUS.Lay_Ten_DV(dvBUS.Lay_Ma_Dich_Vu(maphieu));
            txt_tendichvu.Text = dulieu;
        }

        private void combo_madichvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
