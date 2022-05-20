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
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var dpBUS = new Dat_Phong_BUS();
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dpBUS = new Dat_Phong_BUS();
            string maphieudat = "PD" + (dpBUS.Count_Ma_Phieu() + 1).ToString();
            txtmapd.Text = maphieudat;
            this.DataGridView1.DataSource = dpBUS.Tim_Phong_Trong();
        }

    }
}
