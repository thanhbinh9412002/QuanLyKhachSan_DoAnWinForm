
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvNhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbchucvu = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_gt = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lb_maNV = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.bt_QLTK = new System.Windows.Forms.Button();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvNhanvien
            // 
            this.gvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column7});
            this.gvNhanvien.Location = new System.Drawing.Point(12, 12);
            this.gvNhanvien.Name = "gvNhanvien";
            this.gvNhanvien.Size = new System.Drawing.Size(758, 232);
            this.gvNhanvien.TabIndex = 0;
            this.gvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "manhanvien";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tennhanvien";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "phai";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngaysinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "phone";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "diachi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "chucvu";
            this.Column7.HeaderText = "Chức vụ";
            this.Column7.Name = "Column7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtngaysinh);
            this.panel1.Controls.Add(this.rbnu);
            this.panel1.Controls.Add(this.rbnam);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.lbTimkiem);
            this.panel1.Controls.Add(this.txtchucvu);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.lbchucvu);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.lb_diachi);
            this.panel1.Controls.Add(this.lb_gt);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.lbTenNV);
            this.panel1.Controls.Add(this.lb_maNV);
            this.panel1.Location = new System.Drawing.Point(13, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 198);
            this.panel1.TabIndex = 1;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(177, 77);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(39, 17);
            this.rbnu.TabIndex = 17;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Location = new System.Drawing.Point(94, 77);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(47, 17);
            this.rbnam.TabIndex = 16;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(163, 161);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(177, 26);
            this.txtTimkiem.TabIndex = 15;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(91, 167);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(66, 16);
            this.lbTimkiem.TabIndex = 14;
            this.lbTimkiem.Text = "Tìm kiếm:";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.Location = new System.Drawing.Point(395, 99);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(138, 26);
            this.txtchucvu.TabIndex = 13;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(395, 67);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(138, 26);
            this.txtdiachi.TabIndex = 12;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(395, 35);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(138, 26);
            this.txtsdt.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(124, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(138, 26);
            this.txtMaNV.TabIndex = 8;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(124, 35);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(138, 26);
            this.txtTenNV.TabIndex = 7;
            // 
            // lbchucvu
            // 
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchucvu.Location = new System.Drawing.Point(300, 109);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(58, 16);
            this.lbchucvu.TabIndex = 6;
            this.lbchucvu.Text = "Chức vụ:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(300, 45);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(89, 16);
            this.lb_phone.TabIndex = 5;
            this.lb_phone.Text = "Số điện thoại:";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(300, 77);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(51, 16);
            this.lb_diachi.TabIndex = 4;
            this.lb_diachi.Text = "Địa chỉ:";
            // 
            // lb_gt
            // 
            this.lb_gt.AutoSize = true;
            this.lb_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gt.Location = new System.Drawing.Point(18, 77);
            this.lb_gt.Name = "lb_gt";
            this.lb_gt.Size = new System.Drawing.Size(58, 16);
            this.lb_gt.TabIndex = 3;
            this.lb_gt.Text = "Giới tính:";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(18, 109);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(71, 16);
            this.lb_date.TabIndex = 2;
            this.lb_date.Text = "Ngày sinh:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(18, 45);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(95, 16);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Tên nhân viên:";
            // 
            // lb_maNV
            // 
            this.lb_maNV.AutoSize = true;
            this.lb_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maNV.Location = new System.Drawing.Point(18, 13);
            this.lb_maNV.Name = "lb_maNV";
            this.lb_maNV.Size = new System.Drawing.Size(90, 16);
            this.lb_maNV.TabIndex = 0;
            this.lb_maNV.Text = "Mã nhân viên:";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(626, 264);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(105, 27);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(626, 307);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(105, 27);
            this.btsua.TabIndex = 3;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(626, 349);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(105, 27);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bt_QLTK
            // 
            this.bt_QLTK.Location = new System.Drawing.Point(604, 403);
            this.bt_QLTK.Name = "bt_QLTK";
            this.bt_QLTK.Size = new System.Drawing.Size(144, 35);
            this.bt_QLTK.TabIndex = 5;
            this.bt_QLTK.Text = "Quản lý tài khoản";
            this.bt_QLTK.UseVisualStyleBackColor = true;
            this.bt_QLTK.Click += new System.EventHandler(this.bt_QLTK_Click);
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(124, 109);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(138, 20);
            this.dtngaysinh.TabIndex = 18;
            this.dtngaysinh.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 463);
            this.Controls.Add(this.bt_QLTK);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvNhanvien);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Click += new System.EventHandler(this.FormNhanVien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvNhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_maNV;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_gt;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button bt_QLTK;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
    }
}