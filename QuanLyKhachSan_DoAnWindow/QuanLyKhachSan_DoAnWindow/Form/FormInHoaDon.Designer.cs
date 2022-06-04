
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
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tendichvu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_madichvu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbb_manhanvien = new System.Windows.Forms.ComboBox();
            this.cbb_khuyenmai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_maphieuthue = new System.Windows.Forms.ComboBox();
            this.cbb_makhachhang = new System.Windows.Forms.ComboBox();
            this.dtpk_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.quanLyKhachSanDataSet4 = new QuanLyKhachSan_DoAnWindow.QuanLyKhachSanDataSet4();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonTableAdapter = new QuanLyKhachSan_DoAnWindow.QuanLyKhachSanDataSet4TableAdapters.hoadonTableAdapter();
            this.txt_tkhoadon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbb_sotiencoc = new System.Windows.Forms.ComboBox();
            this.btn_themdichvu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Location = new System.Drawing.Point(8, 3);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.Size = new System.Drawing.Size(659, 139);
            this.dtgv_hoadon.TabIndex = 0;
            this.dtgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(476, 198);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(79, 36);
            this.btn_quaylai.TabIndex = 6;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(367, 198);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(79, 36);
            this.btn_in.TabIndex = 8;
            this.btn_in.Text = "In hóa đơn";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 300);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_themdichvu);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_tendichvu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbb_madichvu);
            this.groupBox2.Location = new System.Drawing.Point(16, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(636, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "label17";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(84, 67);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(121, 20);
            this.txt_soluong.TabIndex = 29;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(509, 66);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(121, 20);
            this.txt_thanhtien.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(441, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Thành tiền";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(299, 66);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(121, 20);
            this.txt_dongia.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Đơn giá";
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.Location = new System.Drawing.Point(299, 32);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.Size = new System.Drawing.Size(121, 20);
            this.txt_tendichvu.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số lượng ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tên dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã dịch vụ";
            // 
            // cbb_madichvu
            // 
            this.cbb_madichvu.FormattingEnabled = true;
            this.cbb_madichvu.Location = new System.Drawing.Point(84, 35);
            this.cbb_madichvu.Name = "cbb_madichvu";
            this.cbb_madichvu.Size = new System.Drawing.Size(121, 21);
            this.cbb_madichvu.TabIndex = 17;
            this.cbb_madichvu.SelectedIndexChanged += new System.EventHandler(this.cbb_madichvu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbb_sotiencoc);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_mahoadon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbb_manhanvien);
            this.groupBox1.Controls.Add(this.cbb_khuyenmai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_maphieuthue);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbb_makhachhang);
            this.groupBox1.Controls.Add(this.dtpk_ngaythanhtoan);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(114, 18);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(121, 20);
            this.txt_mahoadon.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã nhân viên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(669, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "%";
            // 
            // cbb_manhanvien
            // 
            this.cbb_manhanvien.FormattingEnabled = true;
            this.cbb_manhanvien.Location = new System.Drawing.Point(114, 73);
            this.cbb_manhanvien.Name = "cbb_manhanvien";
            this.cbb_manhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbb_manhanvien.TabIndex = 15;
            // 
            // cbb_khuyenmai
            // 
            this.cbb_khuyenmai.FormattingEnabled = true;
            this.cbb_khuyenmai.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90"});
            this.cbb_khuyenmai.Location = new System.Drawing.Point(607, 15);
            this.cbb_khuyenmai.Name = "cbb_khuyenmai";
            this.cbb_khuyenmai.Size = new System.Drawing.Size(56, 21);
            this.cbb_khuyenmai.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã phiếu thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày thanh toán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(541, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã hóa đơn";
            // 
            // cbb_maphieuthue
            // 
            this.cbb_maphieuthue.FormattingEnabled = true;
            this.cbb_maphieuthue.Location = new System.Drawing.Point(370, 16);
            this.cbb_maphieuthue.Name = "cbb_maphieuthue";
            this.cbb_maphieuthue.Size = new System.Drawing.Size(121, 21);
            this.cbb_maphieuthue.TabIndex = 4;
            // 
            // cbb_makhachhang
            // 
            this.cbb_makhachhang.FormattingEnabled = true;
            this.cbb_makhachhang.Location = new System.Drawing.Point(114, 46);
            this.cbb_makhachhang.Name = "cbb_makhachhang";
            this.cbb_makhachhang.Size = new System.Drawing.Size(121, 21);
            this.cbb_makhachhang.TabIndex = 3;
            // 
            // dtpk_ngaythanhtoan
            // 
            this.dtpk_ngaythanhtoan.Location = new System.Drawing.Point(370, 46);
            this.dtpk_ngaythanhtoan.Name = "dtpk_ngaythanhtoan";
            this.dtpk_ngaythanhtoan.Size = new System.Drawing.Size(164, 20);
            this.dtpk_ngaythanhtoan.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.btn_thanhtoan);
            this.panel2.Controls.Add(this.txt_tongtien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_huy);
            this.panel2.Controls.Add(this.dtgv_hoadon);
            this.panel2.Controls.Add(this.btn_quaylai);
            this.panel2.Controls.Add(this.btn_in);
            this.panel2.Location = new System.Drawing.Point(4, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 245);
            this.panel2.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(596, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "label16";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(588, 198);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(79, 36);
            this.btn_thanhtoan.TabIndex = 30;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(467, 159);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(121, 20);
            this.txt_tongtien.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tổng tiền";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(142, 198);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(79, 36);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu ";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(8, 198);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 36);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(259, 198);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(79, 36);
            this.btn_huy.TabIndex = 10;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // quanLyKhachSanDataSet4
            // 
            this.quanLyKhachSanDataSet4.DataSetName = "QuanLyKhachSanDataSet4";
            this.quanLyKhachSanDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.quanLyKhachSanDataSet4;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // txt_tkhoadon
            // 
            this.txt_tkhoadon.Location = new System.Drawing.Point(237, 19);
            this.txt_tkhoadon.Name = "txt_tkhoadon";
            this.txt_tkhoadon.Size = new System.Drawing.Size(121, 20);
            this.txt_tkhoadon.TabIndex = 17;
            this.txt_tkhoadon.TextChanged += new System.EventHandler(this.txt_tkhoadon_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_tkhoadon);
            this.groupBox3.Location = new System.Drawing.Point(12, 566);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 56);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hóa đơn";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(258, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Số tiền cọc";
            // 
            // cbb_sotiencoc
            // 
            this.cbb_sotiencoc.FormattingEnabled = true;
            this.cbb_sotiencoc.Location = new System.Drawing.Point(370, 73);
            this.cbb_sotiencoc.Name = "cbb_sotiencoc";
            this.cbb_sotiencoc.Size = new System.Drawing.Size(121, 21);
            this.cbb_sotiencoc.TabIndex = 17;
            // 
            // btn_themdichvu
            // 
            this.btn_themdichvu.Location = new System.Drawing.Point(509, 29);
            this.btn_themdichvu.Name = "btn_themdichvu";
            this.btn_themdichvu.Size = new System.Drawing.Size(118, 24);
            this.btn_themdichvu.TabIndex = 32;
            this.btn_themdichvu.Text = "Thêm dịch vụ";
            this.btn_themdichvu.UseVisualStyleBackColor = true;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private QuanLyKhachSanDataSet4 quanLyKhachSanDataSet4;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QuanLyKhachSanDataSet4TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_maphieuthue;
        private System.Windows.Forms.ComboBox cbb_makhachhang;
        private System.Windows.Forms.DateTimePicker dtpk_ngaythanhtoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_manhanvien;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_khuyenmai;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tendichvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_madichvu;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_tkhoadon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbb_sotiencoc;
        private System.Windows.Forms.Button btn_themdichvu;
    }
}