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
        private string username;
        public FormDichVu(string user = "")
        {
            InitializeComponent();
            this.username = user;
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
            dt = dvBUS.Lay_Du_lieu_2();
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
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
            DialogResult dialogResult = MessageBox.Show("Mã DV: " + txt_madichvu2.Text + "; Tên DV: " + txt_tendichvu2.Text, "Bạn có chắc muốn xoá dịch vụ này?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dvBUS.Xoa_DV(txt_madichvu2.Text);
            }
            this.dataGridView2.DataSource = dvBUS.Lay_Data_Bang_2();
        }


        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {
            var dvBUS = new Dich_Vu_BUS();
            this.dataGridView2.DataSource = dvBUS.Tim_Dich_Vu(txt_timkiem2.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView2.Rows[e.RowIndex];
            txt_madichvu2.Text = dr.Cells[0].Value.ToString();
            txt_tendichvu2.Text = dr.Cells[1].Value.ToString();
            txt_gia.Text = dr.Cells[2].Value.ToString();
            txt_donvi.Text = dr.Cells[3].Value.ToString();
        }
    }
}
