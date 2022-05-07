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
    public partial class FormLogin : Form
    {
        public FormMain fmMain;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            
            var htBUS = new He_Thong_BUS();
            string password = htBUS.Check_Tai_Khoan(txt_username.Text);
            string pass = txt_password.Text;
            if (pass == password)
            {
                MessageBox.Show("Đăng nhập thành công!");
                fmMain.mchucvu = "admin";
                fmMain.mfullname = htBUS.Lay_Ten_Nhan_Vien(txt_username.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công! Vui lòng kiểm tra lại");
            }
                
            
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
