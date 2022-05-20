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
    public partial class FormInHoaDon : Form
    {
        public FormMain fmMain;
        public FormInHoaDon()
        {
            InitializeComponent();
            var hdBUS = new Hoa_Don_BUS();
            this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_inhoadon_Click(object sender, EventArgs e)
        {

        }

        private void txt_theomahoadon_TextChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        private void txt_theomakhachhang_TextChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu_2(txt_theomakhachhang.Text);
        }
    }
}
