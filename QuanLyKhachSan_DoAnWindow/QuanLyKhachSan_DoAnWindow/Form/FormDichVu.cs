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
            this.Close();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.phieuthuephong' table. You can move, or remove it, as needed.
            var dvBUS = new Dich_Vu_BUS();
            DataTable dt = new DataTable();
            dt = dvBUS.Lay_Du_lieu();
            combo_maphieuthue.DataSource = dt;
            combo_maphieuthue.DisplayMember = "maphieuthue";
            combo_maphieuthue.ValueMember = "maphieuthue";
            combo_maphieuthue.BindingContext = this.BindingContext;
            dt = dvBUS.Lay_Du_lieu_2();
            combo_madichvu.DataSource = dt;
            combo_madichvu.DisplayMember = "madichvu";
            combo_madichvu.ValueMember = "madichvu";
            combo_madichvu.BindingContext = this.BindingContext;
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
        }

        private void combo_maphieuthue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            string maphieu = combo_maphieuthue.SelectedValue.ToString();
            string dulieu = dvBUS.Lay_Ma_Phong(maphieu);
            txt_maphong.Text = dulieu;
            dulieu = dvBUS.Lay_So_Luong(maphieu);
            txt_soluong.Text = dulieu;
            dulieu = dvBUS.Lay_Ten_DV(dvBUS.Lay_Ma_Dich_Vu(maphieu));
            txt_tendichvu.Text = dulieu;
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
        }

        private void combo_madichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            string madichvu = combo_madichvu.SelectedValue.ToString();
            string dulieu = dvBUS.Lay_Ten_DV(madichvu);
            txt_tendichvu.Text = dulieu;
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
        }

        private void button_themdvphong_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Them_DV_Phong(combo_maphieuthue.Text, txt_mahoadon.Text, combo_madichvu.Text, txt_soluong.Text);
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
        }

        private void button_suadvphong_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Sua_DV_Phong(combo_maphieuthue.Text, txt_mahoadon.Text, combo_madichvu.Text, txt_soluong.Text);
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
        }

        private void button_xoadvphong_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Xoa_DV_Phong(combo_maphieuthue.Text);
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text);
        }

        private void button_themdv_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Them_DV(txt_madichvu2.Text, txt_tendichvu2.Text, txt_gia.Text, txt_donvi.Text);
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
        }

        private void button_suadv_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Sua_DV(txt_madichvu2.Text, txt_tendichvu2.Text, txt_gia.Text, txt_donvi.Text);
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
        }

        private void button_xoadv_Click(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            dvBUS.Xoa_DV(txt_madichvu2.Text);
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            this.dataGridView1.DataSource = dvBUS.Tim_Phieu_Thue_Phong(txt_timkiem.Text); 
        }

        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            this.dataGridView2.DataSource = dvBUS.Tim_Dich_Vu(txt_timkiem2.Text);
        }
    }
}
