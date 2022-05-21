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
    public partial class FormBaoCao : Form
    {
        public FormMain fmMain;
        public FormBaoCao()
        {
            InitializeComponent();
        }


        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cbb_theo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t1 = cbb_theo.SelectedItem.ToString();
            if ( t1 == "Tat ca")
            {
                txt_thoigian.Text = "Tat ca";
            }    
            else if (t1 == "Ngay")
            {
                txt_thoigian.Text = dateTimePicker1.Value.Day.ToString() +"-"+ dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Year.ToString();
            }
            else if (t1 == "Thang")
            {
                txt_thoigian.Text = dateTimePicker1.Value.Month.ToString() +"-"+ dateTimePicker1.Value.Year.ToString();
            }
            else
            {
                txt_thoigian.Text = dateTimePicker1.Value.Year.ToString();
            }
        }

        private void txt_thoigian_TextChanged(object sender, EventArgs e)
        {
            var bcBUS = new Bao_Cao_BUS();
            if ( txt_thoigian.Text == "Tat ca")
                this.dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_0();   
            else
                this.dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_1(txt_thoigian.Text);

        }

        private void btn_tongket_Click(object sender, EventArgs e)
        {
            string t1 = cbb_theo.SelectedItem.ToString();
            var bcBUS = new Bao_Cao_BUS();
            string soluong = bcBUS.Lay_Du_Lieu_2(txt_thoigian.Text, t1);
            txt_sohoadon.Text = soluong;
            string sotien = bcBUS.Lay_Du_Lieu_3(txt_thoigian.Text, t1);
            txt_sotien.Text = sotien;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }
    }
}
