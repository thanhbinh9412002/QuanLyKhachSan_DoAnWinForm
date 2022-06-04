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
    public partial class FormInHoaDon : Form
    {
        public FormMain fmMain;
        public FormKhachHang fmKH;
        public string tmp;
        public FormInHoaDon()
        {
            InitializeComponent();
            var hdBUS = new Hoa_Don_BUS();
            this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
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
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dtgv_hoadon.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
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

        private void btn_inhoadon_Click(object sender, EventArgs e)
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
            this.dataGridView1.DataSource = hdBUS.Lay_Du_Lieu(txt_theomahoadon.Text);
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet4.hoadon' table. You can move, or remove it, as needed.
            //this.hoadonTableAdapter.Fill(this.quanLyKhachSanDataSet4.hoadon);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hdBUS = new Hoa_Don_BUS();
            DataGridViewRow dr = new DataGridViewRow();
            dr = dataGridView1.Rows[e.RowIndex];
            string tmp = Convert.ToString(dr.Cells["mahoadon"].Value);
            dtgv_hoadon.DataSource = hdBUS.Chitiethoadon(tmp);
            //tmp = dr.Cells[0].Value.ToString();
        }
    }
}
