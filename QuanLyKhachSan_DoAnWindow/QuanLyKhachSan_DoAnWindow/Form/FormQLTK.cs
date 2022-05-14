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

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormQLTK : Form
    {
        public FormMain fmMain;
        public FormNhanVien fmNhanVien;
        public FormQLTK()
        {
            InitializeComponent();
        }

        private void FormQLTK_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
        private void LoadDataUser()
        {

        }
    }
}
