using QuanLyKhachSan_DoAnWindow.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable Lay_Du_Lieu_1(string thoigian)
        {
            return bcDAO.Lay_Du_Lieu_1(thoigian);
        }
        public string Lay_Du_Lieu_2(string thoigian, string chon)
        {
            return bcDAO.Lay_Du_Lieu_2(thoigian, chon);
        }
        public string Lay_Du_Lieu_3(string thoigian, string chon)
        {
            return bcDAO.Lay_Du_Lieu_3(thoigian, chon);
        }
    }
}
