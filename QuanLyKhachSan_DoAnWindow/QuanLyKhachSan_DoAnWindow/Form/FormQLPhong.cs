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
        private string dadat = "khong", danhan = "khong";
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
            room = pgBUS.Tim_Loai_Phong(txt_timkiem2.Text);
            this.dataGriwView2.DataSource = room;

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
            if (check_dadat.Checked == true)
            {
                dadat = "co";
            }
            else
            {
                dadat = "khong";
            }
            if (check_danhan.Checked == true)
            {
                danhan = "co";
            }
            else
            {
                danhan = "khong";
            }
            pgBUS.Them_Phong(txt_maphong.Text, combo_loaiphong.Text, dadat, danhan);
            var htBUS = new He_Thong_BUS();
            DataTable room = htBUS.Lay_Data_phong();
            this.dataGriwView1.DataSource = room;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            if (check_dadat.Checked == true)
            {
                dadat = "co";
            }
            else
            {
                dadat = "khong";
            }
            if (check_danhan.Checked == true)
            {
                danhan = "co";
            }
            else
            {
                danhan = "khong";
            }
            pgBUS.Sua_Phong(txt_maphong.Text, combo_loaiphong.Text, dadat, danhan);
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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            DataTable room = pgBUS.Tim_Phong(txt_timkiem.Text);
            this.dataGriwView1.DataSource = room;
        }

        private void dataGriwView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGriwView1.Rows[e.RowIndex];
            txt_maphong.Text = dr.Cells[0].Value.ToString();
            combo_loaiphong.Text = dr.Cells[1].Value.ToString();
            if (dr.Cells[2].Value.ToString().Contains("co"))
            {
                check_dadat.Checked = true;
            }
            else
            {
                check_dadat.Checked = false;
            }
            if (dr.Cells[3].Value.ToString().Contains("co"))
            {
                check_danhan.Checked = true;
            }
            else
            {
                check_danhan.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Them_Loai_Phong(txt_maloai2.Text, txt_gia.Text, txt_songuoi.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = pgBUS.Tim_Loai_Phong(txt_timkiem2.Text); ;
            this.dataGriwView2.DataSource = room;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Sua_Loai_Phong(txt_maloai2.Text, txt_gia.Text, txt_songuoi.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = pgBUS.Tim_Loai_Phong(txt_timkiem2.Text); ;
            this.dataGriwView2.DataSource = room;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            pgBUS.Xoa_Loai_Phong(txt_maloai2.Text);
            var htBUS = new He_Thong_BUS();
            DataTable room = pgBUS.Tim_Loai_Phong(txt_timkiem2.Text); ;
            this.dataGriwView2.DataSource = room;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var pgBUS = new Phong_BUS();
            DataTable room = pgBUS.Tim_Loai_Phong(txt_timkiem2.Text);
            this.dataGriwView2.DataSource = room;
        }

        private void dataGriwView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGriwView2.Rows[e.RowIndex];
            txt_maloai2.Text = dr.Cells[0].Value.ToString();
            txt_songuoi.Text = dr.Cells[2].Value.ToString();
            txt_gia.Text = dr.Cells[1].Value.ToString();
        }
    }
}
