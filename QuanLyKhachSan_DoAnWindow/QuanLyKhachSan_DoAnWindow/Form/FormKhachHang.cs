using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan_DoAnWindow.BUS;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormKhachHang : Form
    {
       //private Khach_Hang_BUS KHBUS;
        public FormMain fmMain;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        /*private void FormKhachHang_Load(object sender, EventArgs e)
        {
            KHBUS.LoadData(gvKhachhang);
        }*/
    }
}
