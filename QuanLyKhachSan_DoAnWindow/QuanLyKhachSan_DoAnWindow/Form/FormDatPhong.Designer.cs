namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormDatPhong
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("KHÁCH HÀNG", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ĐẶT PHÒNG", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tên khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Giới tính",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "CMND/Passport",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Địa chỉ",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Điện thoại",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày đến",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày đi",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số người",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tiền cọc",
            ""}, -1);
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.txt_songuoi = new System.Windows.Forms.TextBox();
            this.date_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.date_ngayden = new System.Windows.Forms.DateTimePicker();
            this.gvdanhsach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.bt_MaPD = new System.Windows.Forms.Button();
            this.txtmapd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvdp = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChiTiet = new System.Windows.Forms.ListView();
            this.tt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tiencoc.Location = new System.Drawing.Point(141, 119);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Size = new System.Drawing.Size(156, 24);
            this.txt_tiencoc.TabIndex = 15;
            // 
            // txt_songuoi
            // 
            this.txt_songuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_songuoi.Location = new System.Drawing.Point(141, 87);
            this.txt_songuoi.Name = "txt_songuoi";
            this.txt_songuoi.Size = new System.Drawing.Size(156, 24);
            this.txt_songuoi.TabIndex = 14;
            // 
            // date_ngaydi
            // 
            this.date_ngaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_ngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaydi.Location = new System.Drawing.Point(117, 183);
            this.date_ngaydi.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.date_ngaydi.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.date_ngaydi.Name = "date_ngaydi";
            this.date_ngaydi.Size = new System.Drawing.Size(180, 24);
            this.date_ngaydi.TabIndex = 13;
            this.date_ngaydi.Value = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            // 
            // date_ngayden
            // 
            this.date_ngayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_ngayden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayden.Location = new System.Drawing.Point(117, 151);
            this.date_ngayden.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.date_ngayden.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.date_ngayden.Name = "date_ngayden";
            this.date_ngayden.Size = new System.Drawing.Size(180, 24);
            this.date_ngayden.TabIndex = 12;
            this.date_ngayden.Value = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.AllowUserToAddRows = false;
            this.gvdanhsach.AllowUserToDeleteRows = false;
            this.gvdanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdanhsach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.gvdanhsach.Location = new System.Drawing.Point(6, 6);
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.ReadOnly = true;
            this.gvdanhsach.RowHeadersWidth = 51;
            this.gvdanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdanhsach.Size = new System.Drawing.Size(513, 420);
            this.gvdanhsach.TabIndex = 0;
            this.gvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdanhsach_CellClick);
            this.gvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "maphieudat";
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Mã phiếu đặt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "makhachhang";
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngayden";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Ngày đến";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ngaydi";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Ngày đi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "songuoi";
            this.Column6.FillWeight = 30F;
            this.Column6.HeaderText = "Số người";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Chọn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Xem";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày đi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền cọc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số người:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "SĐT khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_sdtkh);
            this.groupBox2.Controls.Add(this.bt_MaPD);
            this.groupBox2.Controls.Add(this.txtmapd);
            this.groupBox2.Controls.Add(this.txt_tiencoc);
            this.groupBox2.Controls.Add(this.txt_songuoi);
            this.groupBox2.Controls.Add(this.date_ngaydi);
            this.groupBox2.Controls.Add(this.date_ngayden);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 222);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu đặt phòng";
            // 
            // txt_sdtkh
            // 
            this.txt_sdtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sdtkh.Location = new System.Drawing.Point(141, 56);
            this.txt_sdtkh.Name = "txt_sdtkh";
            this.txt_sdtkh.Size = new System.Drawing.Size(156, 24);
            this.txt_sdtkh.TabIndex = 18;
            // 
            // bt_MaPD
            // 
            this.bt_MaPD.Location = new System.Drawing.Point(246, 25);
            this.bt_MaPD.Margin = new System.Windows.Forms.Padding(2);
            this.bt_MaPD.Name = "bt_MaPD";
            this.bt_MaPD.Size = new System.Drawing.Size(50, 19);
            this.bt_MaPD.TabIndex = 17;
            this.bt_MaPD.Text = "New";
            this.bt_MaPD.UseVisualStyleBackColor = true;
            this.bt_MaPD.Click += new System.EventHandler(this.bt_MaPD_Click);
            // 
            // txtmapd
            // 
            this.txtmapd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmapd.Location = new System.Drawing.Point(141, 22);
            this.txtmapd.Name = "txtmapd";
            this.txtmapd.Size = new System.Drawing.Size(101, 24);
            this.txtmapd.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_quaylai);
            this.tabPage2.Controls.Add(this.bt_them);
            this.tabPage2.Controls.Add(this.gvdanhsach);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(104, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 24);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm:";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_quaylai.Location = new System.Drawing.Point(398, 449);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(90, 30);
            this.bt_quaylai.TabIndex = 7;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_them.Location = new System.Drawing.Point(279, 449);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(90, 30);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(344, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 537);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lvdp);
            this.tabPage3.Controls.Add(this.lsvChiTiet);
            this.tabPage3.Controls.Add(this.btnSua);
            this.tabPage3.Controls.Add(this.btnHuy);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(523, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chi tiết";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(87, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tìm kiếm:";
            // 
            // lvdp
            // 
            this.lvdp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvdp.FullRowSelect = true;
            this.lvdp.GridLines = true;
            this.lvdp.HideSelection = false;
            this.lvdp.Location = new System.Drawing.Point(2, 313);
            this.lvdp.Name = "lvdp";
            this.lvdp.Scrollable = false;
            this.lvdp.Size = new System.Drawing.Size(523, 131);
            this.lvdp.TabIndex = 13;
            this.lvdp.UseCompatibleStateImageBehavior = false;
            this.lvdp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 10;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phòng";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại ";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số người";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá";
            this.columnHeader6.Width = 146;
            // 
            // lsvChiTiet
            // 
            this.lsvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tt,
            this.gt});
            this.lsvChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvChiTiet.FullRowSelect = true;
            listViewGroup3.Header = "KHÁCH HÀNG";
            listViewGroup3.Name = "listViewGroupKHACHHANG";
            listViewGroup4.Header = "ĐẶT PHÒNG";
            listViewGroup4.Name = "listViewGroupDATPHONG";
            this.lsvChiTiet.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lsvChiTiet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvChiTiet.HideSelection = false;
            listViewItem11.Group = listViewGroup3;
            listViewItem12.Group = listViewGroup3;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.Group = listViewGroup3;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Group = listViewGroup3;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup3;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.Group = listViewGroup3;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.Group = listViewGroup4;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.Group = listViewGroup4;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.Group = listViewGroup4;
            listViewItem19.StateImageIndex = 0;
            listViewItem20.Group = listViewGroup4;
            listViewItem20.StateImageIndex = 0;
            this.lsvChiTiet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.lsvChiTiet.Location = new System.Drawing.Point(1, 23);
            this.lsvChiTiet.MultiSelect = false;
            this.lsvChiTiet.Name = "lsvChiTiet";
            this.lsvChiTiet.Scrollable = false;
            this.lsvChiTiet.Size = new System.Drawing.Size(523, 284);
            this.lsvChiTiet.TabIndex = 12;
            this.lsvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lsvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // tt
            // 
            this.tt.Text = "Thông tin";
            this.tt.Width = 180;
            // 
            // gt
            // 
            this.gt.Text = "Giá trị";
            this.gt.Width = 464;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(291, 449);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(397, 449);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Xoá";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(6, 50);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(298, 245);
            this.DataGridView1.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(118, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 30);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridView1);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(9, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 300);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm phòng trống";
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDatPhong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.TextBox txt_songuoi;
        private System.Windows.Forms.DateTimePicker date_ngaydi;
        private System.Windows.Forms.DateTimePicker date_ngayden;
        private System.Windows.Forms.DataGridView gvdanhsach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmapd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_MaPD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvdp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lsvChiTiet;
        private System.Windows.Forms.ColumnHeader tt;
        private System.Windows.Forms.ColumnHeader gt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}