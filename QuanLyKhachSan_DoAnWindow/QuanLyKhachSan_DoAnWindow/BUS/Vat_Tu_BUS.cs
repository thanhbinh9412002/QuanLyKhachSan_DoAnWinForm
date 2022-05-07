using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DoAnWindow.DAO;

namespace QuanLyKhachSan_DoAnWindow.BUS
{
    internal class Vat_Tu_BUS
    {
        private Vat_Tu_DAO vtDAO;
        public Vat_Tu_BUS()
        {
            vtDAO = new Vat_Tu_DAO();
        }
    }
}
