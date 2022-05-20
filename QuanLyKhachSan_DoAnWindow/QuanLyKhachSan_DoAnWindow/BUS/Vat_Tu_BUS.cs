using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;
using System.Data;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Vat_Tu_BUS
    {
        private Vat_Tu_DAO vtDAO;
        public Vat_Tu_BUS()
        {
            vtDAO = new Vat_Tu_DAO();
        }

        public DataTable Lay_Du_lieu()
        {
            return vtDAO.Lay_Du_lieu();
        }

        public DataTable Tim_Vat_Tu(string maloaiphong, string mavattu)
        {
            return vtDAO.Tim_Vat_Tu(maloaiphong, mavattu);
        }
    }
}
