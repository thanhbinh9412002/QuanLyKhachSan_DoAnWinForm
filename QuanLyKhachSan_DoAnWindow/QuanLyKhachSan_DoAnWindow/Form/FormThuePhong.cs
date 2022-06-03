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
    public partial class FormThuePhong : Form
    {
        public FormMain fmMain;
        private Thue_Phong_BUS tpBUS = new Thue_Phong_BUS();
        public FormThuePhong()
        {
            InitializeComponent();
        }

        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            this.Datagridview_phong.DataSource = tpBUS.Tim_Phong_Trong();
            this.Datagriwview_danhsach.DataSource = tpBUS.Hien_Thi_Danh_Sach();
            if (radio_dadat.Checked == true)
            {
                txt_maphieudat.Enabled = true;
                txt_maphieuthue.Enabled = false;
                button_maphieuthue.Enabled = false;
            }
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            this.Datagridview_phong.DataSource = tpBUS.Tim_Phong_Trong();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.Datagridview_phong.Rows[e.RowIndex];
            txt_maphong.Text = dr.Cells[0].Value.ToString();
        }

        private void radio_dadat_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_dadat.Checked == true)
            {
                txt_maphieudat.Enabled = true;
                txt_maphieuthue.Enabled = false;
                button_maphieuthue.Enabled = false;
                txt_maphieuthue.Clear();
            }
        }

        private void radio_chuadat_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_chuadat.Checked == true)
            {
                txt_maphieudat.Enabled = false;
                txt_maphieuthue.Enabled = true;
                button_maphieuthue.Enabled = true;
                txt_maphieudat.Clear();
            }
        }

        private void button_maphieuthue_Click(object sender, EventArgs e)
        {
            txt_maphieuthue.Text = "PT" + (tpBUS.Dem_Ma_Phieu_Thue() + 1).ToString();
        }

        private void button_maphieudat_Click(object sender, EventArgs e)
        {
            txt_maphieudat.Text = "PDT" + (tpBUS.Dem_Ma_Phieu_Dat() + 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Datagriwview_danhsach.DataSource = tpBUS.Hien_Thi_Danh_Sach(txt_timkiem.Text);
        }

        private void Datagriwview_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.Datagriwview_danhsach.Rows[e.RowIndex];
            string maphong = dr.Cells[2].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)                // kiem tra co click vao button ko
            {
                tabControl1.SelectedTab = tabPage3;         // chuyen qua xem chi tiet
                this.Datagriwview_danhsach2.DataSource = tpBUS.Hien_Thi_Phong(maphong);
            }
            if (dr.Cells[1].Value.ToString().Contains("PDT"))
            {
                txt_maphieudat.Text = dr.Cells[1].Value.ToString();
                radio_dadat.Checked = true;
            }
                
            else
            {
                txt_maphieuthue.Text = dr.Cells[1].Value.ToString();
                radio_chuadat.Checked = true;
            }
                

        }

    }
}
