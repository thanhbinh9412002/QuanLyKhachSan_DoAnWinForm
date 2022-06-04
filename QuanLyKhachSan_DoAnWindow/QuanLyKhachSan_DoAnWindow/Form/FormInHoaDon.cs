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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormInHoaDon : Form
    {
        public FormMain fmMain;
        public string tmp;
        public FormInHoaDon()
        {
            InitializeComponent();
            var hdBUS = new Hoa_Don_BUS();
            //this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToExcel(DataGridView dtgv_hoadon, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Hóa đơn khác hàng ";

                // export header trong DataGridView
                for (int i = 0; i < dtgv_hoadon.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = this.dtgv_hoadon.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dtgv_hoadon.RowCount; i++)
                {
                    for (int j = 0; j < this.dtgv_hoadon.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgv_hoadon.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

            /*if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                //ToExcel(, saveFileDialog1.FileName);
            }*/
        }

        private void txt_theomahoadon_TextChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            //this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet4.hoadon' table. You can move, or remove it, as needed.
            //this.hoadonTableAdapter.Fill(this.quanLyKhachSanDataSet4.hoadon);
            var hdBUS = new Hoa_Don_BUS();
            btn_them.Enabled = true;
            btn_in.Enabled = false;
            btn_huy.Enabled = false;
            btn_quaylai.Enabled = true;
            //btn_timkiem.Enabled = true;
            btn_thanhtoan.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahoadon.ReadOnly = true;
            txt_tendichvu.ReadOnly = true;
            txt_dongia.ReadOnly = true;
            txt_thanhtien.ReadOnly = true;
            txt_tongtien.ReadOnly = true;
            txt_thanhtien.Text = "0";
            txt_tongtien.Text = "0";
            txt_tkhoadon.Enabled = true;

            // load dữ liệu từ data sang combobox mã khách hàng
            cbb_makhachhang.DataSource = hdBUS.Lay_Ma_Khach_Hang();
            cbb_makhachhang.DisplayMember = "makhachhang";
            cbb_makhachhang.ValueMember = "makhachhang";
            // load dữ liệu từ data sang combobox mã nhân viên
            cbb_manhanvien.DataSource = hdBUS.Lay_Ma_Nhan_Vien();
            cbb_manhanvien.DisplayMember = "manhanvien";
            cbb_manhanvien.ValueMember = "manhanvien";
            // load dữ liệu từ data sang combobox mã phiếu thuê
            cbb_maphieuthue.DataSource = hdBUS.Lay_Ma_Phieu_Thue();
            cbb_maphieuthue.DisplayMember = "maphieuthue";
            cbb_maphieuthue.ValueMember = "maphieuthue";
            // load dữ liệu từ data sang combobox mã dịch vụ
            cbb_madichvu.DataSource = hdBUS.Lay_Ma_Dich_Vu();
            cbb_madichvu.DisplayMember = "madichvu";
            cbb_madichvu.ValueMember = "madichvu";
            //load dữ liệu từ data sang combobox só tiền đã cọc
            cbb_sotiencoc.DataSource = hdBUS.Lay_So_Tien_Coc();
            cbb_sotiencoc.DisplayMember = "sotiencoc";
            cbb_sotiencoc.ValueMember = "sotiencoc";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var hdBUS = new Hoa_Don_BUS();
            DataGridViewRow dr = new DataGridViewRow();
            dr = dtgv_hoadon.Rows[e.RowIndex];
            string tmp = Convert.ToString(dr.Cells["mahoadon"].Value);
            //dtgv_hoadon.DataSource = hdBUS.Chitiethoadon(tmp);
            
            //tmp = dr.Cells[0].Value.ToString();*/
        }

        private void txt_tkhoadon_TextChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            this.dtgv_hoadon.DataSource = hdBUS.Lay_Danh_Sach_Hoa_Don(txt_tkhoadon.Text);
        }

        private void ResestValue()
        {
            txt_mahoadon.ResetText();
            cbb_manhanvien.ResetText();
            cbb_maphieuthue.ResetText();
            cbb_khuyenmai.ResetText();
            cbb_makhachhang.ResetText();
            cbb_madichvu.ResetText();
            txt_soluong.ResetText();
            txt_tendichvu.ResetText();
            txt_dongia.ResetText();
            txt_thanhtien.Text = "0";
            txt_tongtien.Text = "0";
            dtpk_ngaythanhtoan.Value = DateTime.Today;
        }

        public static string Tao_Ma_Hoa_Don(string tiento)
        {
            var hdBUS = new Hoa_Don_BUS();
            string key = tiento;
            string hauto;
            string tmp = hdBUS.Lay_Ma_Hoa_Don();
            hauto = tmp.Substring(2);
            int sohoadon = Int32.Parse(hauto);
            sohoadon++;
            hauto = sohoadon.ToString();
            if (sohoadon < 10)
                hauto = "0" + hauto;
            key = key + hauto;
            return key;
        }

        public static int Tinh_So_Tien_Khuyen_Mai(string khuyenmai,string tongtien)
        {
            int sokhuyenmai = int.Parse(khuyenmai);
            int sotongtien = int.Parse(tongtien);
            int key = sotongtien * sokhuyenmai / 100;
            return key;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            btn_them.Enabled = false;
            btn_huy.Enabled = false;
            btn_luu.Enabled = true;
            btn_in.Enabled = false;
            ResestValue();
            txt_mahoadon.Text = Tao_Ma_Hoa_Don("HD");
            dtgv_hoadon.DataSource = hdBUS.Lay_Cac_Cot();
            dtgv_hoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dtgv_hoadon.Columns[1].HeaderText = "Mã khách hàng";
            dtgv_hoadon.Columns[2].HeaderText = "Mã nhân viên";
            dtgv_hoadon.Columns[3].HeaderText = "Ngày thanh toán";
            dtgv_hoadon.Columns[4].HeaderText = "Mã phiếu thuê";
            dtgv_hoadon.Columns[5].HeaderText = "Số tiền đặt cọc";
            dtgv_hoadon.Columns[6].HeaderText = "Số ngày ở";
            dtgv_hoadon.Columns[7].HeaderText = "Số tiền khuyến mãi";
            dtgv_hoadon.Columns[8].HeaderText = "Thành tiền";
        }

        private void cbb_madichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            string madichvu = cbb_madichvu.SelectedItem.ToString();
            txt_tendichvu.Text = hdBUS.Lay_Ten_Dich_Vu(madichvu);
            txt_dongia.Text = hdBUS.Lay_Gia_Dich_Vu(madichvu);
            label16.Text = hdBUS.Lay_Don_Vi_Dich_Vu(madichvu);
            label17.Text = hdBUS.Lay_Don_Vi_Dich_Vu(madichvu);
            

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            string txt_makhachhang = cbb_makhachhang.SelectedItem.ToString();
            string txt_manhanvien = cbb_manhanvien.SelectedItem.ToString();
            string txt_maphieuthue = cbb_maphieuthue.SelectedItem.ToString();
            string txt_madichvu = cbb_madichvu.SelectedItem.ToString();
            int txt_tiendatcoc = int.Parse(cbb_sotiencoc.SelectedItem.ToString());
            DateTime txt_ngaythanhtoan = dtpk_ngaythanhtoan.Value;
            string songayo = hdBUS.Tinh_Tong_So_Ngay_O(txt_makhachhang, txt_ngaythanhtoan).ToString();
            int txt_songayo = int.Parse(songayo);
            string tmp = cbb_khuyenmai.SelectedItem.ToString();
            //string tongtien = txt_tongtien.Text;
            /*string txt_sotienkhuyenmai = Tinh_So_Tien_Khuyen_Mai(tmp, tongtien).ToString();
            int txt_tongtien = int.Parse(txt_tongtien.ToString());
            int txt_khuyenmai = int.Parse(txt_sotienkhuyenmai);*/

            //string txt_mahoadon = txt_mahoadon.Text.ToString();
            /*hd = new Hoa_Don(txt_mahoadon, txt_makhachhang, txt_manhanvien, txt_ngaythanhtoan,
                txt_maphieuthue, txt_tiendatcoc, txt_songayo, txt_khuyenmai, txt_tongtien, txt_madichvu, txt_tendichvu, );*/

        }
    }
}
