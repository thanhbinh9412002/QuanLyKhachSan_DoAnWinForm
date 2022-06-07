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
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormBaoCao : Form
    {
        public FormMain fmMain;
        //public Bao_Cao bc;
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            string chon = cbb_theo.SelectedItem.ToString();
            string ngay = txt_ngay.Text;
            string thang = txt_thang.Text;
            string nam = txt_nam.Text;
            var bcBUS = new Bao_Cao_BUS();
            if (chon == "Tat ca")
            {
                txt_ngay.ResetText();
                txt_thang.ResetText();
                txt_nam.ResetText();
                dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_0();
            }
            else if (chon == "Ngay")
                dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_1(ngay, thang, nam);
            else if (chon == "Thang")
            {
                txt_ngay.ResetText();
                dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_2(thang, nam);
            }
            else
            {
                txt_ngay.ResetText();
                txt_thang.ResetText();
                dtgv_danhsach.DataSource = bcBUS.Lay_Du_Lieu_3(nam);
            }
        }

        private void btn_tongket_Click(object sender, EventArgs e)
        {
            string chon = cbb_theo.SelectedItem.ToString();
            string ngay = txt_ngay.Text;
            string thang = txt_thang.Text;
            string nam = txt_nam.Text;
            var bcBUS = new Bao_Cao_BUS();
            string soluong = bcBUS.Lay_Du_Lieu_4(ngay, thang, nam, chon);
            txt_sohoadon.Text = soluong;
            string sotien = bcBUS.Lay_Du_Lieu_5(ngay, thang, nam, chon);
            txt_sotien.Text = sotien;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.quanLyKhachSanDataSet.hoadon);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet5.hoadon' table. You can move, or remove it, as needed.
            //this.hoadonTableAdapter.Fill(this.quanLyKhachSanDataSet5.hoadon);

        }
    }
}
