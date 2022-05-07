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
    public partial class FormKhachHang : Form
    {
        /*public FormMain frmMain;

        private SqlDataAdapter adapter;*/
        //private DataSet dataset;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            //LoadDataKh();
        }
        private void LoadDataKh()
        {
            /*SqlCommand cmd = new SqlCommand("DSKhachHang", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvKhachhang.DataSource = tb;
            gvKhachhang.ClearSelection();*/
        }
        private void ReadData()
        {
           /* if (gvKhachhang.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = gvKhachhang.SelectedRows[0];
            txtMkh.Text = row.Cells["Mã"].Value.ToString();
            txtTenkh.Text = row.Cells["Họ Tên"].Value.ToString();
            if (row.Cells["Giới tính"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtNgaysinh.Text = row.Cells["Ngày sinh"].Value.ToString();
            txtCmnd.Text = row.Cells["CMND"].Value.ToString();
            txtDiachi.Text = row.Cells["Địa chỉ"].Value.ToString();
            txtSodt.Text = row.Cells["SĐT"].Value.ToString();
            txtGhichu.Text = row.Cells["Ghi chú"].Value.ToString();*/
        }
        /*private bool makh()
        {
            if (txtMkh.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool tenkh()
        {
            if (txtTenkh.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool cmnd()
        {
            if (txtCmnd.Text == "")
            {
                MessageBox.Show("CMND/Passport không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (makh() && tenkh() && cmnd())
            {
                return true;
            }
            return false;
        }*/
        private void btnThem_Click(object sender, EventArgs e)
        {

           /* SqlCommand cmd = new SqlCommand("ThemKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            if (kiemtra())
            {
                cmd.Parameters.AddWithValue("@makh", txtMkh.Text);
                cmd.Parameters.AddWithValue("@tenkh", txtTenkh.Text);
                if (rdNam.Checked)
                    cmd.Parameters.AddWithValue("@gioitinh", "Nam");
                else
                    cmd.Parameters.AddWithValue("@gioitinh", "Nữ");
                cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Text);
                cmd.Parameters.AddWithValue("@cmnd", txtCmnd.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSodt.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhichu.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công", "Thêm khách hàng mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKh();

                }
                catch (SqlException exc)
                {
                    if (exc.Number == 2627)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            /*String MakhCu = (String)gvKhachhang.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("SuaKH", DataBase.GetConnection());
            if (kiemtra())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", txtMkh.Text);
                cmd.Parameters.AddWithValue("@tenkh", txtTenkh.Text);
                if (rdNam.Checked)
                    cmd.Parameters.AddWithValue("@gioitinh", "Nam");
                else
                    cmd.Parameters.AddWithValue("@gioitinh", "Nữ");
                cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Text);
                cmd.Parameters.AddWithValue("@cmnd", txtCmnd.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSodt.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhichu.Text);
                cmd.Parameters.Add(new SqlParameter("@makhcu", MakhCu));
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Sửa thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataKh();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*if (gvKhachhang.SelectedRows.Count > 0)
            {

                SqlCommand cmd = new SqlCommand("XoaKH", DataBase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", gvKhachhang.SelectedRows[0].Cells[0].Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKh();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chọn khách hàng cần xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }
        private void gvKhachhang_Click(object sender, EventArgs e)
        {
            //ReadData();
        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("TimKHTen", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", txtTimkiem.Text);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                gvKhachhang.DataSource = dt;
            }
            else
                MessageBox.Show("Không tìm thấy!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }


    }
}
