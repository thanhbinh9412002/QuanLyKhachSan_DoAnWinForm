
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormInHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_theomahoadon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd_passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiendatcoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuyenmai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theo mã hóa đơn :";
            // 
            // txt_theomahoadon
            // 
            this.txt_theomahoadon.Location = new System.Drawing.Point(129, 20);
            this.txt_theomahoadon.Name = "txt_theomahoadon";
            this.txt_theomahoadon.Size = new System.Drawing.Size(124, 20);
            this.txt_theomahoadon.TabIndex = 1;
            this.txt_theomahoadon.TextChanged += new System.EventHandler(this.txt_theomahoadon_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_theomahoadon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(595, 85);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(79, 36);
            this.btn_quaylai.TabIndex = 6;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.Location = new System.Drawing.Point(595, 146);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(79, 36);
            this.btn_inhoadon.TabIndex = 8;
            this.btn_inhoadon.Text = "In hóa đơn";
            this.btn_inhoadon.UseVisualStyleBackColor = true;
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_inhoadon);
            this.panel1.Controls.Add(this.btn_quaylai);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 235);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(4, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 253);
            this.panel2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_hoadon);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 247);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn :";
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahoadon,
            this.Tenkhachhang,
            this.cmnd_passport,
            this.sotiendatcoc,
            this.ngaythanhtoan,
            this.maphong,
            this.tendichvu,
            this.gia,
            this.khuyenmai,
            this.tongtien});
            this.dtgv_hoadon.Location = new System.Drawing.Point(11, 29);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.Size = new System.Drawing.Size(689, 212);
            this.dtgv_hoadon.TabIndex = 0;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            // 
            // Mahoadon
            // 
            this.Mahoadon.DataPropertyName = "mahoadon";
            this.Mahoadon.HeaderText = "Mã hóa đơn";
            this.Mahoadon.Name = "Mahoadon";
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.DataPropertyName = "tenkhachhang";
            this.Tenkhachhang.HeaderText = "Tên khách hàng";
            this.Tenkhachhang.Name = "Tenkhachhang";
            // 
            // cmnd_passport
            // 
            this.cmnd_passport.DataPropertyName = "cmnd_passport";
            this.cmnd_passport.HeaderText = "Số cmnd";
            this.cmnd_passport.Name = "cmnd_passport";
            // 
            // sotiendatcoc
            // 
            this.sotiendatcoc.DataPropertyName = "sotiendatcoc";
            this.sotiendatcoc.HeaderText = "Số tiền đặt cọc";
            this.sotiendatcoc.Name = "sotiendatcoc";
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "tendichvu";
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.Name = "tendichvu";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // khuyenmai
            // 
            this.khuyenmai.HeaderText = "Khuyến mãi";
            this.khuyenmai.Name = "khuyenmai";
            this.khuyenmai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.khuyenmai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_theomahoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_inhoadon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiendatcoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewComboBoxColumn khuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}