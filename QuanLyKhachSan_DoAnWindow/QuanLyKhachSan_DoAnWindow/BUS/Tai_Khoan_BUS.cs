using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Tai_Khoan_BUS
    {
        private Tai_Khoan_DAO tkDAO;
        private Nhan_Vien_DAO nvDAO= new Nhan_Vien_DAO();
        public Tai_Khoan_BUS()
        {
            tkDAO = new Tai_Khoan_DAO();
        }
        private bool checkNV(string ma)
        {
            if (nvDAO.checkNV(ma))
                return true;    //neu co nhan vien nay
            return false;    //neu ko có nhan vien nay
        }
        //them tai khoan
        public void themTK(string ma, string user, string pass, string cv)
        {
            //------kiem tra-------
            //nếu mã đã có trong bảng NV nhưng ko có trong bảng TK -> thêm vô, được thêm nhiều tài khoản
            //nếu chưa có mã trong bảng NV nhưng có mã tronng bảng TK -> lỗi, báo lỗi chưa có nhân viên này
            if (checkNV(ma))
            {
                tkDAO.Them_tai_khoan(ma, user, pass, cv);
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm nhân viên này ở bảng nhân viên! Hãy quay lại!");
            }
        }
        //cap nhat tai khoan
        public void capnhatTK(string ma, string user, string pass, string cv)
        {
            tkDAO.Cap_nhat_tai_khoan(ma, user, pass, cv);
        }
        //xoa tai khoan
        public void xoaTK(string ma)
        {
            tkDAO.Xoa_tai_khoan(ma);
        }
        // day du lieu len grib view
        public void upTK(DataGridView data, string user = "")
        {
            data.DataSource = this.tkDAO.Loadbanghethong(user);
        }
        // cap nhat ma 
        public void updateMa(ComboBox cb)
        {
            //-----tải nhân viên lên combobox----- 
            //Nếu cb chưa có giá trị Item -> thêm 
            //nếu có rồi -> ko làm gì cả
            cb.Items.Clear();
            DataTable tb = this.tkDAO.manhanvien();
            foreach (DataRow row in tb.Rows)
            {
                cb.Items.Add(row["manhanvien"].ToString());
            }
            //------cap nhat mã------
            //tăng số mã đang có lên 1 
            int d = cb.Items.Count + 1;
            cb.Text = "NV" + d.ToString();
        }
        public void machucvu(ComboBox cb)
        {
            cb.Items.Clear();
            DataTable tb = this.tkDAO.machucvu();
            foreach (DataRow row in tb.Rows)
            {
                cb.Items.Add(row["machucvu"].ToString());
            }
        }
    }
}
