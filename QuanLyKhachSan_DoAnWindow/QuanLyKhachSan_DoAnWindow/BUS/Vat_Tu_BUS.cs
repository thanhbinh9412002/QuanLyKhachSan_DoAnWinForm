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

        public void Them_Vat_Tu(string maloaiphong, string mavattu, string tenvattu, string soluong)
        {
            vtDAO.Them_Vat_Tu(maloaiphong, mavattu, tenvattu, soluong);
        }

        public void Sua_Vat_Tu(string maloaiphong, string mavattu, string tenvattu, string soluong)
        {
            vtDAO.Sua_Vat_Tu(maloaiphong, mavattu, tenvattu, soluong);
        }

        public void Xoa_Vat_Tu(string mavattu, string maloaiphong)
        {
            vtDAO.Xoa_Vat_Tu(mavattu, maloaiphong);
        }

        public DataTable Tim_Vat_Tu(string maloaiphong, string mavattu)
        {
            return vtDAO.Tim_Vat_Tu(maloaiphong, mavattu);
        }
    }
}
