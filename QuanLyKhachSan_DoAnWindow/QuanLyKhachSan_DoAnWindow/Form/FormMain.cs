using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormMain : Form
    {
        /*public FormLogin frmLogin;
        public FormDoiMK frmDoiMK;
        public FormKhachHang frmKH;
        public FormThongTin frmTT;
        public FormPhong frmP;
        public FormDatPhong frmDP;
        public FormThuePhong frmTP;
        public FormNguoiDung frmND;
        public FormBaoCao frmBC;*/

        public String musername = null;
        public String mfullname = null;
        public String mchucvu = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*MainNoEnabled();
            frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (mchucvu == "Nhân viên")
            {
                MainEnNhanVien();
            }
            else if (mchucvu == "admin")
            {
                MainEnabled();
            }
            else if (mchucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                Application.Exit();
            }

            lblUser.Text = "Hi " + mfullname + " !";
            ThongKe();
            LoadSDP();*/

        }
        public void ThongKe()
        {
            /*SqlConnection con = DataBase.GetConnection();
            SqlCommand cmd = new SqlCommand("ThongKe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                lbpt.Text = reader["phongtrong"].ToString();
                lbpd.Text = reader["phongdadat"].ToString();
                lbpdt.Text = reader["phongdanhan"].ToString();
            }*/
        }
        public void LoadSDP()
        {
            /*lvPhong.Items.Clear();
            SqlConnection con = DataBase.GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblphong", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i]["maphong"].ToString());
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i]["maphong"].ToString());
                    String dat = "";
                    String nhan = "";
                    dat = dt.Rows[i]["dadat"].ToString();
                    nhan = dt.Rows[i]["danhan"].ToString();
                    if (dat == "0" && nhan == "0")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 0;
                    }
                    else if (dat == "1" && nhan == "0")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 1;
                    }
                    else if (dat == "0" && nhan == "1")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 2;
                    }
                }
            }
            else
                MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }
        /*private void MainEnabled()
        {
            mnQuanly.Enabled = true;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnBaocao.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainNoEnabled()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = false;
            mnKhachhang1.Enabled = false;
            mnDatphong1.Enabled = false;
            mnBaocao.Enabled = false;
            mnDangxuat.Enabled = false;
        }
        private void MainEnQuanLy()
        {
            mnQuanly.Enabled = true;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnBaocao.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainEnNhanVien()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnBaocao.Enabled = false;
            mnDangxuat.Enabled = true;
        }*/
        /*static string Mahoa(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static bool Giaima(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = Mahoa(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        private void mnDangnhap_Click(object sender, EventArgs e)
        {
            /*frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (mchucvu == "admin")
            {
                MainEnabled();
            }
            else if (mchucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
            lblUser.Text = "Hi " + mfullname + " !";*/
        }
        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            /*lblUser.Text = "Hi!";
            MainNoEnabled(); frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();*/
        }
        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            /*frmDoiMK = new FormDoiMK();
            frmDoiMK.frmMain = this;
            frmDoiMK.ShowDialog();*/
        }
        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnKhachhang_Click(object sender, EventArgs e)
        {
            /*frmKH = new FormKhachHang();
            frmKH.frmMain = this;
            frmKH.ShowDialog();*/
        }
        private void mnInhoadon_Click(object sender, EventArgs e)
        {

        }
        private void mnDatphong_Click(object sender, EventArgs e)
        {
            /*frmDP = new FormDatPhong();
            frmDP.frmMain = this;
            frmDP.ShowDialog();*/
        }
        private void mnThuephong_Click(object sender, EventArgs e)
        {
            /*frmTP = new FormThuePhong();
            frmTP.frmMain = this;
            frmTP.ShowDialog();*/
        }
        private void mnPhong_Click(object sender, EventArgs e)
        {
            /*frmP = new FormPhong();
            frmP.frmMain = this;
            frmP.ShowDialog();*/
        }
        private void mnVattu_Click(object sender, EventArgs e)
        {

        }
        private void mnDichvu_Click(object sender, EventArgs e)
        {

        }
        private void mnNhanvien_Click(object sender, EventArgs e)
        {

        }
        private void mnNguoidung_Click(object sender, EventArgs e)
        {
            /*frmND = new FormNguoiDung();
            frmND.frmMain = this;
            frmND.ShowDialog();*/
        }
        private void mnThongtin_Click(object sender, EventArgs e)
        {
            /*frmTT = new FormThongTin();
            frmTT.frmMain = this;
            frmTT.ShowDialog();*/
        }

        private void mnBaocao_Click(object sender, EventArgs e)
        {
            /*frmBC = new FormBaoCao();
            frmBC.frmMain = this;
            frmBC.ShowDialog();*/
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
}
