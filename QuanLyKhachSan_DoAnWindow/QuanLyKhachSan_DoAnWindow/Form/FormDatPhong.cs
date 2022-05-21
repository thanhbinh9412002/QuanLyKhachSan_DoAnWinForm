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
    public partial class FormDatPhong : Form
    {
        public FormMain fmMain;
        public FormDatPhong()
        {
            InitializeComponent();
            var dpBUS = new Dat_Phong_BUS();
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
            this.DataGridView2.DataSource = dpBUS.Hien_Thi_DS();
            DataTable dt = new DataTable();
            dt = dpBUS.Lay_Ma_Phieu();
            combo_maphieudat.DataSource = dt;
            combo_maphieudat.DisplayMember = "maphieudat";
            combo_maphieudat.ValueMember = "maphieudat";
            combo_maphieudat.BindingContext = this.BindingContext;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var dpBUS = new Dat_Phong_BUS();
            string maphieudat = "PD" + (dpBUS.Count_Ma_Phieu() + 1).ToString();
            txtmapd.Text = maphieudat;
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var dpBUS = new Dat_Phong_BUS();
            this.DataGridView2.DataSource = dpBUS.Tim_Kiem_DS(txt_timkiem.Text);
        }

        private void combo_maphieudat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dpBUS = new Dat_Phong_BUS();
            DataTable dt = new DataTable();
            dt = dpBUS.Lay_Thong_Tin(combo_maphieudat.Text);
            txtmapd.Text = dt.Rows[0][0].ToString();
            txt_maphong.Text = dt.Rows[0][1].ToString();
            txt_cmndkh.Text = dt.Rows[0][2].ToString();
            txt_songuoi.Text = dt.Rows[0][3].ToString();
            txt_tiencoc.Text = dt.Rows[0][4].ToString();
            txt_ngayden.Text = dt.Rows[0][5].ToString();
            txt_ngaydi.Text = dt.Rows[0][6].ToString();
            this.dataGridView3.DataSource = dpBUS.Tim_Phong_Theo_Ma_Phong(txt_maphong.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
