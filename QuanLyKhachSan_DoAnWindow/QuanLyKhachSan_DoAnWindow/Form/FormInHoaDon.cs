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
        public FormKhachHang fmKH;
        public string tmp;
        public FormInHoaDon()
        {
            InitializeComponent();
            var hdBUS = new Hoa_Don_BUS();
            //this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet4.hoadon' table. You can move, or remove it, as needed.
            //this.hoadonTableAdapter.Fill(this.quanLyKhachSanDataSet4.hoadon);
            var hdBUS = new Hoa_Don_BUS();
            btn_them.Enabled = true;
            //btn_in.Enabled = false;
            btn_huy.Enabled = false;
            btn_quaylai.Enabled = true;
            btn_themdichvu.Enabled = false;
            btn_huytk.Enabled = false;
            btn_thanhtoan.Enabled = false;
            btn_luu.Enabled = false;
            cbb_madichvu.Enabled = false;
            //txt_mahoadon.ReadOnly = true;
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
            

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            btn_them.Enabled = false;
            cbb_madichvu.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = true;
            //btn_in.Enabled = false;
            btn_themdichvu.Enabled = true;
            ResestValue();
            txt_mahoadon.Text = Tao_Ma_Hoa_Don("HD");
            dtgv_hoadon.DataSource = hdBUS.Lay_Cac_Cot(txt_mahoadon.Text);
            dtgv_hoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dtgv_hoadon.Columns[1].HeaderText = "Mã dịch vụ";
            dtgv_hoadon.Columns[2].HeaderText = "Tên dịch vụ";
            dtgv_hoadon.Columns[3].HeaderText = "Số lượng";
            dtgv_hoadon.Columns[4].HeaderText = "Đơn giá";
            dtgv_hoadon.Columns[5].HeaderText = "Thành tiền";
           
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
           /* var hdBUS = new Hoa_Don_BUS();
            string txt_makhachhang = cbb_makhachhang.SelectedValue.ToString();
            string txt_manhanvien = cbb_manhanvien.SelectedItem.ToString();
            string txt_maphieuthue = cbb_maphieuthue.SelectedItem.ToString();
            string txt_madichvu = cbb_madichvu.SelectedItem.ToString();
            int txt_tiendatcoc = int.Parse(cbb_sotiencoc.SelectedItem.ToString());
            DateTime txt_ngaythanhtoan = dtpk_ngaythanhtoan.Value;
            string songayo = hdBUS.Tinh_Tong_So_Ngay_O(txt_makhachhang, txt_ngaythanhtoan).ToString();
            int txt_songayo = int.Parse(songayo);
            string tmp = cbb_khuyenmai.SelectedItem.ToString();
            //string tongtien = txt_tongtien.Text;
            *//*string txt_sotienkhuyenmai = Tinh_So_Tien_Khuyen_Mai(tmp, tongtien).ToString();
            int txt_tongtien = int.Parse(txt_tongtien.ToString());
            int txt_khuyenmai = int.Parse(txt_sotienkhuyenmai);*//*

            //string txt_mahoadon = txt_mahoadon.Text.ToString();
            *//*hd = new Hoa_Don(txt_mahoadon, txt_makhachhang, txt_manhanvien, txt_ngaythanhtoan,
                txt_maphieuthue, txt_tiendatcoc, txt_songayo, txt_khuyenmai, txt_tongtien, txt_madichvu, txt_tendichvu, );*/

        }

        private void txt_tkhoadon_TextChanged(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_huytk.Enabled = true;
            var hdBUS = new Hoa_Don_BUS();
            this.dtgv_hoadon.DataSource = hdBUS.Lay_Danh_Sach_Hoa_Don(txt_tkhoadon.Text);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            int cot = 0;
            int hang = 0;
            var hdBUS = new Hoa_Don_BUS();
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "NHÓM 04";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "QUẢN LÝ KHÁCH SẠN";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 123456789";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN";
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:E6"].Value = txt_mahoadon.Text.ToString();
            exRange.Range["B7:B7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B7:B7"].Value = "Tên Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:E7"].Value = hdBUS.TenKhachHang(txt_mahoadon.Text);
            exRange.Range["B8:B8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C8:E8"].Value = hdBUS.DiaChi(txt_mahoadon.Text);
            exRange.Range["B9:B9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:E9"].Value = hdBUS.SoDienThoai(txt_mahoadon.Text);
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã dịch vụ";
            exRange.Range["C11:C11"].Value = "Tên dịch vụ";
            exRange.Range["D11:D11"].Value = "Số lượng";
            exRange.Range["E11:E11"].Value = "Giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            int tmp = int.Parse(hdBUS.SoDichVu(txt_mahoadon.Text));
            DataTable tblThongtinHang = hdBUS.ThongTinHoaDon(txt_mahoadon.Text);
            for (hang = 0; hang < tmp; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = hdBUS.TongTien(txt_mahoadon.Text);
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hồ Chí Minh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = hdBUS.NhanVienBan(txt_mahoadon.Text);
            exSheet.Name = "Hóa đơn khách sạn";
            exApp.Visible = true;
        }
    

        private void cbb_madichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            string madv = cbb_madichvu.SelectedValue.ToString();
            txt_tendichvu.Text = hdBUS.Lay_Ten_Dich_Vu(madv);
            txt_dongia.Text = hdBUS.Lay_Gia_Dich_Vu(madv);
            lb_donvi.Text = hdBUS.Lay_Don_Vi_Dich_Vu(madv);
            lb_donvi1.Text = hdBUS.Lay_Don_Vi_Dich_Vu(madv);
            lb_donvi2.Text = hdBUS.Lay_Don_Vi_Dich_Vu(madv);
        }

        private void btn_huytk_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            txt_tkhoadon.ResetText();
        }

        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            txt_thanhtien.Text = (int.Parse(txt_dongia.Text) * int.Parse(txt_soluong.Text)).ToString();

        }
    }
}
