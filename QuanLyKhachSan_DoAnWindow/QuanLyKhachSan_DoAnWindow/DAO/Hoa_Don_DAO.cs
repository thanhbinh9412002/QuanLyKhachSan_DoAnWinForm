using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DataProvider;
using System.Data.SqlClient;
using System.Data;
using QuanLyKhachSan_DoAnWindow.Class;


namespace QuanLyKhachSan_DoAnWindow.DAO
{
    internal class Hoa_Don_DAO
    {
        private DBConnection conn;
        public Hoa_Don_DAO()
        {
            conn = new DBConnection();
        }
        public DataTable Lay_Ma_Khach_Hang()
        {
            string sql = "select makhachhang from khachhang";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable mkh = new DataTable();
            mkh = conn.executeReader(sql, sqlParameters);
            return mkh;
        }
        public DataTable Lay_Ma_Nhan_Vien()
        {
            string sql = "select manhanvien from nhanvien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable mnv = new DataTable();
            mnv = conn.executeReader(sql, sqlParameters);
            return mnv;
        }

        public void TraPhong(string mahoadon, string dadat, string danhan)
        {

            const string sql = "update phong a join phieuthuephong b on a.maphong = b.maphong " +
                "join hoadon c on b.mahoadon = c.mahoadon set a.dadat = @dadat, a.danhan = @danhan where b.mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);

            sqlParameters[1] = new SqlParameter("@dadat", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(dadat);

            sqlParameters[2] = new SqlParameter("@danhan", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(danhan);

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable Lay_Ma_Phieu_Thue()
        {
            string sql = "select maphieuthue from phieuthuephong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable mpt = new DataTable();
            mpt = conn.executeReader(sql, sqlParameters);
            return mpt;
        }
        public DataTable Lay_Ma_Dich_Vu()
        {
            string sql = "select madichvu from dichvu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable mdv = new DataTable();
            mdv = conn.executeReader(sql, sqlParameters);
            return mdv;
        }
        public DataTable Lay_Danh_Sach_Hoa_Don(string mahoadon)
        {
            string sql = "select * from hoadon where mahoadon like '%" + mahoadon + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable hoadon = new DataTable();
            hoadon = conn.executeReader(sql, sqlParameters);
            return hoadon;
        }
        public DataTable Lay_Cac_Cot(string mahoadon)
        {
            string sql = "select chitietdichvu.mahoadon, chitietdichvu.madichvu, dichvu.tendichvu, chitietdichvu.soluong, " +
                "dichvu.gia, chitietdichvu.thanhtien " +
                "from chitietdichvu " +
                "join dichvu on chitietdichvu.madichvu = dichvu.madichvu " +
                "where chitietdichvu.mahoadon = @mahd";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahd", SqlDbType.Char);
            sqlParameters[0].Value = mahoadon;
            DataTable dichvu = new DataTable();
            dichvu = conn.executeReader(sql, sqlParameters);
            return dichvu;
        }
        public string Lay_Ma_Hoa_Don()
        {
            const string sql = "select max(mahoadon) from hoadon";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            object mhoadon = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(mhoadon);
        }
        public DataTable Lay_So_Tien_Coc()
        {
            string sql = "select sotiencoc from chitietthuephong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable tien = new DataTable();
            tien = conn.executeReader(sql, sqlParameters);
            return tien;
        }
        public DataTable ChiTietDichVu(string madichvu)
        {
            string sql = "select * from dichvu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dichvu = new DataTable();
            dichvu = conn.executeReader(sql, sqlParameters);
            return dichvu;
        }
        public int Tinhsongayo(string makhachhang, DateTime ngaythanhtoan)
        {
            const string sql = "select ngaythuephong from chitietthuephong where makhachhang = @makhachhang";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[1] = new SqlParameter("@makhachhang", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(makhachhang);
            DateTime ngaythue = DateTime.Parse(sql);
            TimeSpan Time = ngaythanhtoan - ngaythue;
            int TongSoNgay = Time.Days;
            return TongSoNgay;
        }
        public void Luu_Hoa_Don(Hoa_Don hd)
        {
            // chèn dữ lệu vào bảng hóa đơn
            const string sql1 = "insert into hoadon(mahoadon, makhachhang, manhanvien, ngaythanhtoan, maphieuthue, sotiencoc, songayo, sotienkhuyenmai, tongtien)" +
                "values (@mahoadon, @makhachhang, @manhanvien, @ngaythanhtoan, @maphieuthue, @sotiencoc, @songayo, @sotienkhuyenmai, @tongtien)";
            SqlParameter[] sqlParameters1 = new SqlParameter[9];
            sqlParameters1[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters1[0].Value = hd.Ma_hoa_don;

            sqlParameters1[1] = new SqlParameter("@makhachhang", System.Data.SqlDbType.VarChar);
            sqlParameters1[1].Value = hd.Ma_khach_hang;

            sqlParameters1[2] = new SqlParameter("@manhanvien", System.Data.SqlDbType.VarChar);
            sqlParameters1[2].Value = hd.Ma_nhan_vien;

            sqlParameters1[3] = new SqlParameter("@ngaythanhtoan", System.Data.SqlDbType.Date);
            sqlParameters1[3].Value = hd.Ngay_thanh_toan;

            sqlParameters1[4] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters1[4].Value = hd.Ma_phieu_thue;

            sqlParameters1[5] = new SqlParameter("@sotiencoc", System.Data.SqlDbType.Int);
            sqlParameters1[5].Value = hd.So_tien_coc;

            sqlParameters1[6] = new SqlParameter("@songayo", System.Data.SqlDbType.Int);
            sqlParameters1[6].Value = hd.So_ngay_o;

            sqlParameters1[7] = new SqlParameter("@sotienkhuyenmai", System.Data.SqlDbType.Int);
            sqlParameters1[7].Value = hd.So_tien_khuyen_mai;

            sqlParameters1[8] = new SqlParameter("@tongtien", System.Data.SqlDbType.Int);
            sqlParameters1[8].Value = hd.Tong_tien;

            conn.executeInsertQuery(sql1, sqlParameters1);
        }

        public string Lay_Ten_Dich_Vu(string madichvu)
        {
            const string sql = "select tendichvu from dichvu where madichvu = @madichvu";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);
            object a = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(a);
        }

        public string Lay_Gia_Dich_Vu(string madichvu)
        {
            string sql = "select gia from dichvu where madichvu = @madv";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@madv", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);
            object b = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(b);
        }

        public string Lay_Don_Vi_Dich_Vu(string madichvu)
        {
            string sql = "select donvitinh from dichvu where madichvu = @madv";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@madv", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(madichvu);
            object c = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(c);
        }

        public void Them_Chi_Tiet_Dich_Vu(Hoa_Don hd)
        {
            const string sql = "insert into chitietdichvu(mahoadon, maphieuthue, madichvu, soluong, thanhtien) " +
                "values (@mahoadon, @maphieuthue, @madichvu, @soluong, @thanhtien)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = hd.Ma_hoa_don;

            sqlParameters[1] = new SqlParameter("@maphieuthue", System.Data.SqlDbType.VarChar);
            sqlParameters[1].Value = hd.Ma_phieu_thue;

            sqlParameters[2] = new SqlParameter("@madichvu", System.Data.SqlDbType.VarChar);
            sqlParameters[2].Value = hd.Ma_dich_vu;

            sqlParameters[3] = new SqlParameter("@soluong", System.Data.SqlDbType.Int);
            sqlParameters[3].Value = hd.So_luong;

            sqlParameters[4] = new SqlParameter("@thanhtien", System.Data.SqlDbType.Int);
            sqlParameters[4].Value = hd.Thanh_tien;

            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable ThongTinKhachHang(string mahoadon)
        {
            string sql = "select a.mahoadon, b.tenkhachhang, b.diachi, b.sodienthoai from hoadon a join khachhang b on a.makhachhang = b.makhachhang where a.mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.Char);
            sqlParameters[0].Value = mahoadon;
            DataTable kh = new DataTable();
            kh = conn.executeReader(sql, sqlParameters);
            return kh;
        }



        // Cho phần excel


        public DataTable ThongTinHoaDon(string mahoadon)
        {
            string sql = "select a.madichvu, b.tendichvu, a.soluong, b.gia, a.thanhtien from chitietdichvu a join dichvu b on a.madichvu = b.madichvu where a.mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.Char);
            sqlParameters[0].Value = mahoadon;
            DataTable tthd = new DataTable();
            tthd = conn.executeReader(sql, sqlParameters);
            return tthd;
        }

        public string TenKhachHang(string mahoadon)
        {
            string sql = "select b.tenkhachhang from hoadon a join khachhang b on a.makhachhang = b.makhachhang where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object ten = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(ten);
        }

        public string SoDienThoai(string mahoadon)
        {
            string sql = "select b.sodienthoai from hoadon a join khachhang b on a.makhachhang = b.makhachhang where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object sdt = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(sdt);
        }

        public string DiaChi(string mahoadon)
        {
            string sql = "select b.diachi from hoadon a join khachhang b on a.makhachhang = b.makhachhang where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object dc = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(dc);
        }

        public string SoDichVu(string mahoadon)
        {
            string sql = "select count(madichvu) from chitietdichvu where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object sdv = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(sdv);
        }

        public string TongTien(string mahoadon)
        {
            string sql = "select tongtien  from hoadon where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object tien = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(tien);
        }

        public string NhanVienBan(string mahoadon)
        {
            string sql = "select b.tennhanvien  from hoadon a join nhanvien b on a.manhanvien = b.manhanvien where mahoadon = @mahoadon";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(mahoadon);
            object tnv = conn.executeScalar(sql, sqlParameters);
            return Convert.ToString(tnv);
        }
    }
}
