﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow
{
    public partial class FormNhanVien : Form
    {
        public FormQLTK fmQLTK;
        public FormMain fmMain;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void bt_QLTK_Click(object sender, EventArgs e)
        {
            fmQLTK = new FormQLTK();
            fmQLTK.fmNhanVien = this;
            fmQLTK.ShowDialog();
        }
    }
}
