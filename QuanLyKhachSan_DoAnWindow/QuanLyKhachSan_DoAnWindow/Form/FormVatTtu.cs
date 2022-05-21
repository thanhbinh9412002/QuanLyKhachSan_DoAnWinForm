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
    public partial class FormVatTu : Form
    {
        public FormMain fmMain;
        public FormVatTu()
        {
            InitializeComponent();
            var vtBUS = new Vat_Tu_BUS();
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
            DataTable dt = new DataTable();
            dt = vtBUS.Lay_Du_lieu();
            combo_maloaiphong.DataSource = dt;
            combo_maloaiphong.DisplayMember = "maloai";
            combo_maloaiphong.ValueMember = "maloai";
            combo_maloaiphong.BindingContext = this.BindingContext;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var vtBUS = new Vat_Tu_BUS();
            vtBUS.Them_Vat_Tu(combo_maloaiphong.Text, txt_mavattu.Text, txt_tenvattu.Text, txt_soluong.Text);
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var vtBUS = new Vat_Tu_BUS();
            vtBUS.Sua_Vat_Tu(combo_maloaiphong.Text, txt_mavattu.Text, txt_tenvattu.Text, txt_soluong.Text);
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var vtBUS = new Vat_Tu_BUS();
            vtBUS.Xoa_Vat_Tu(txt_mavattu.Text, combo_maloaiphong.Text);
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var vtBUS = new Vat_Tu_BUS();
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
        }

        private void combo_maloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vtBUS = new Vat_Tu_BUS();
            this.dataGridView1.DataSource = vtBUS.Tim_Vat_Tu(combo_maloaiphong.Text, txt_timkiem.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];
            txt_mavattu.Text = dr.Cells[0].Value.ToString();
            txt_tenvattu.Text = dr.Cells[1].Value.ToString();
            txt_soluong.Text = dr.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
