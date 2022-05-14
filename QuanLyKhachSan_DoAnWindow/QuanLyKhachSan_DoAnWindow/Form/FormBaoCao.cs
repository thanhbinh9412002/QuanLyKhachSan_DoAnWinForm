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

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            /*var bcBUS = new Bao_Cao_BUS();
            txt_sohoadon.Text = bcBUS.Xuat_So_Hoa_Don();*/
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
