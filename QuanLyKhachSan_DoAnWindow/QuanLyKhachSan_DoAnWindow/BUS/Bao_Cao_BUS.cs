using QuanLyKhachSan_DoAnWindow.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.Class;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Bao_Cao_BUS
    {
        private Bao_Cao_DAO bcDAO;
        public Bao_Cao_BUS()
        {
            bcDAO = new Bao_Cao_DAO();
        }
        public DataTable Lay_Du_Lieu_0()
        {
            return bcDAO.Lay_Du_Lieu_0();
        }
        public DataTable Lay_Du_Lieu_1(string ngay, string thang, string nam)
        {
            return bcDAO.Lay_Du_Lieu_1(ngay, thang, nam);
        }
        public DataTable Lay_Du_Lieu_2(string thang, string nam)
        {
            return bcDAO.Lay_Du_Lieu_2(thang, nam);
        }
        public DataTable Lay_Du_Lieu_3(string nam)
        {
            return bcDAO.Lay_Du_Lieu_3(nam);
        }
        public string Lay_Du_Lieu_4(string ngay, string thang, string nam, string chon)
        {
            return bcDAO.Lay_Du_Lieu_4(ngay, thang, nam, chon);
        }
        public string Lay_Du_Lieu_5(string ngay, string thang, string nam, string chon)
        {
            return bcDAO.Lay_Du_Lieu_5(ngay, thang, nam, chon);
        }
    }
}
