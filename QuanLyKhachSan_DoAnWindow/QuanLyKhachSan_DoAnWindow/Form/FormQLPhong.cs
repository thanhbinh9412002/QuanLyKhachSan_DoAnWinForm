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
    public partial class FormQLPhong : Form
    {
        public FormMain fmMain;
        public FormQLPhong()
        {
            InitializeComponent();
        }

        private void FormQLPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet3.phong' table. You can move, or remove it, as needed.
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
            var pgBUS = new Phong_BUS();
            DataTable dt = new DataTable();
            dt = pgBUS.Lay_Ma_Loai();
            combo_loaiphong.DataSource = dt;
            combo_loaiphong.DisplayMember = "maloai";
            combo_loaiphong.ValueMember = "maloai";
            combo_loaiphong.BindingContext = this.BindingContext;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Them_Phong(txt_maphong.Text, combo_loaiphong.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Sua_Phong(txt_maphong.Text, combo_loaiphong.Text, txt_dadat.Text, txt_danhan.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Xoa_Phong(txt_maphong.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            DataTable room = pgBUS.Tim_Phong(txt_maphong.Text);
            this.dataGriwView1.DataSource = room;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
