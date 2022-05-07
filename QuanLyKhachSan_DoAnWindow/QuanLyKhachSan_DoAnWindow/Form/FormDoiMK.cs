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
    public partial class FormDoiMK : Form
    {
        public FormMain fmMain;
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {
            lblUser.Text = fmMain.musername;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            var htBUS = new He_Thong_BUS();
            string oldpassword = htBUS.Check_Tai_Khoan(fmMain.musername);
            if (oldpassword == txtMkc.Text && txtMkm.Text == txtMkm2.Text)
            {
                htBUS.Doi_Mat_Khau(fmMain.musername, txtMkm.Text);
                MessageBox.Show("Đổi mật khẩu thành công!");
                txtMkc.Clear();
                txtMkm.Clear();
                txtMkm2.Clear();
            }
            else 
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu!");
            }
        }
    }
}
