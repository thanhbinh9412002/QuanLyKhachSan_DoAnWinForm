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
            this.DataGridView1.DataSource = tpBUS.Tim_Phong_Trong();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            this.DataGridView1.DataSource = tpBUS.Tim_Phong_Trong();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.DataGridView1.Rows[e.RowIndex];
            txt_maphong.Text = dr.Cells[0].Value.ToString();
        }
    }
}
