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
    public partial class FormNguoiDung : Form
    {
        /*public FormMain frmMain;*/
        public FormNguoiDung()
        {
            InitializeComponent();
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
        private void LoadDataUser()
        {
           /* SqlCommand cmd = new SqlCommand("SELECT * FROM tbluser", DataBase.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.ClearSelection();*/
        }
    }
}
