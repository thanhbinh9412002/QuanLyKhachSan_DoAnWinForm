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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tên khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Giới tính",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "CMND/Passport",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Địa chỉ",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Điện thoại",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày thuê phòng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số người",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tiền cọc",
            ""}, -1);
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.gvdanhsach = new System.Windows.Forms.DataGridView();
            this.maphieucol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongcol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_songuoi = new System.Windows.Forms.ComboBox();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.bt_MaPD = new System.Windows.Forms.Button();
            this.txtmapd = new System.Windows.Forms.TextBox();
            this.date_ngaythue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDEL = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvdp = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChiTiet = new System.Windows.Forms.ListView();
            this.tt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.phongcol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaicol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadatcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhancol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiobutton = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            // gvdanhsach
            // 
            this.gvdanhsach.AllowUserToAddRows = false;
            this.gvdanhsach.AllowUserToDeleteRows = false;
            this.gvdanhsach.AllowUserToResizeColumns = false;
            this.gvdanhsach.AllowUserToResizeRows = false;
            this.gvdanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdanhsach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieucol,
            this.phongcol2,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column6,
            this.Column5});
            this.gvdanhsach.Location = new System.Drawing.Point(3, 9);
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.ReadOnly = true;
            this.gvdanhsach.RowHeadersVisible = false;
            this.gvdanhsach.RowHeadersWidth = 51;
            this.gvdanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdanhsach.Size = new System.Drawing.Size(513, 426);
            this.gvdanhsach.TabIndex = 0;
            this.gvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdanhsach_CellClick);
            this.gvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdanhsach_CellContentClick);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // maphieucol
            // 
            this.maphieucol.DataPropertyName = "maphieudat";
            this.maphieucol.FillWeight = 30F;
            this.maphieucol.HeaderText = "Mã phiếu";
            this.maphieucol.Name = "maphieucol";
            this.maphieucol.ReadOnly = true;
            // 
            // phongcol2
            // 
            this.phongcol2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phongcol2.DataPropertyName = "maphong";
            this.phongcol2.FillWeight = 30F;
            this.phongcol2.HeaderText = "Phòng";
            this.phongcol2.Name = "phongcol2";
            this.phongcol2.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenkhachhang";
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "sotiencoc";
            this.Column7.FillWeight = 40F;
            this.Column7.HeaderText = "Tiền cọc";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ngaythuephong";
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Ngày thuê phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Chọn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Xem";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 125);
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
            this.groupBox2.Controls.Add(this.txt_songuoi);
            this.groupBox2.Controls.Add(this.txt_sdtkh);
            this.groupBox2.Controls.Add(this.bt_MaPD);
            this.groupBox2.Controls.Add(this.txtmapd);
            this.groupBox2.Controls.Add(this.txt_tiencoc);
            this.groupBox2.Controls.Add(this.date_ngaythue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 224);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu đặt phòng";
            // 
            // txt_songuoi
            // 
            this.txt_songuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_songuoi.FormattingEnabled = true;
            this.txt_songuoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3 ",
            "4",
            "5",
            "6"});
            this.txt_songuoi.Location = new System.Drawing.Point(141, 87);
            this.txt_songuoi.Name = "txt_songuoi";
            this.txt_songuoi.Size = new System.Drawing.Size(155, 26);
            this.txt_songuoi.TabIndex = 19;
            this.txt_songuoi.Text = "1";
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
            // date_ngaythue
            // 
            this.date_ngaythue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_ngaythue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaythue.Location = new System.Drawing.Point(141, 162);
            this.date_ngaythue.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.date_ngaythue.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.date_ngaythue.Name = "date_ngaythue";
            this.date_ngaythue.Size = new System.Drawing.Size(155, 24);
            this.date_ngaythue.TabIndex = 12;
            this.date_ngaythue.Value = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày thuê:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.btnDEL);
            this.tabPage2.Controls.Add(this.txt_timkiem);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_quaylai);
            this.tabPage2.Controls.Add(this.bt_them);
            this.tabPage2.Controls.Add(this.gvdanhsach);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            // 
            // btnDEL
            // 
            this.btnDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDEL.Location = new System.Drawing.Point(321, 457);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(80, 30);
            this.btnDEL.TabIndex = 19;
            this.btnDEL.Text = "Xoá";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem.Location = new System.Drawing.Point(6, 459);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(160, 26);
            this.txt_timkiem.TabIndex = 18;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm:";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_quaylai.Location = new System.Drawing.Point(427, 455);
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
            this.bt_them.Location = new System.Drawing.Point(203, 455);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(90, 30);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(342, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 536);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvdp);
            this.tabPage3.Controls.Add(this.lsvChiTiet);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(523, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chi tiết";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.lvdp.Location = new System.Drawing.Point(4, 332);
            this.lvdp.Name = "lvdp";
            this.lvdp.Scrollable = false;
            this.lvdp.Size = new System.Drawing.Size(516, 168);
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
            this.lsvChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            listViewItem10.Group = listViewGroup3;
            listViewItem11.Group = listViewGroup3;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.Group = listViewGroup3;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.Group = listViewGroup3;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Group = listViewGroup3;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup3;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.Group = listViewGroup4;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.Group = listViewGroup4;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.Group = listViewGroup4;
            listViewItem18.StateImageIndex = 0;
            this.lsvChiTiet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.lsvChiTiet.Location = new System.Drawing.Point(3, 5);
            this.lsvChiTiet.MultiSelect = false;
            this.lsvChiTiet.Name = "lsvChiTiet";
            this.lsvChiTiet.Scrollable = false;
            this.lsvChiTiet.Size = new System.Drawing.Size(517, 321);
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
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phongcol1,
            this.maloaicol,
            this.dadatcol,
            this.danhancol,
            this.radiobutton});
            this.DataGridView1.Location = new System.Drawing.Point(6, 21);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(298, 274);
            this.DataGridView1.TabIndex = 1;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // phongcol1
            // 
            this.phongcol1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phongcol1.DataPropertyName = "maphong";
            this.phongcol1.FillWeight = 40F;
            this.phongcol1.HeaderText = "Phòng";
            this.phongcol1.Name = "phongcol1";
            this.phongcol1.ReadOnly = true;
            this.phongcol1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // maloaicol
            // 
            this.maloaicol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maloaicol.DataPropertyName = "maloai";
            this.maloaicol.FillWeight = 50F;
            this.maloaicol.HeaderText = "Loại";
            this.maloaicol.Name = "maloaicol";
            this.maloaicol.ReadOnly = true;
            this.maloaicol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dadatcol
            // 
            this.dadatcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dadatcol.DataPropertyName = "dadat";
            this.dadatcol.FillWeight = 50F;
            this.dadatcol.HeaderText = "Đã đặt";
            this.dadatcol.Name = "dadatcol";
            this.dadatcol.ReadOnly = true;
            this.dadatcol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // danhancol
            // 
            this.danhancol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.danhancol.DataPropertyName = "danhan";
            this.danhancol.FillWeight = 50F;
            this.danhancol.HeaderText = "Đã nhận";
            this.danhancol.Name = "danhancol";
            this.danhancol.ReadOnly = true;
            this.danhancol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // radiobutton
            // 
            this.radiobutton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.radiobutton.FalseValue = "false";
            this.radiobutton.FillWeight = 30F;
            this.radiobutton.HeaderText = "Chọn";
            this.radiobutton.Name = "radiobutton";
            this.radiobutton.ReadOnly = true;
            this.radiobutton.TrueValue = "true";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
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
            this.ClientSize = new System.Drawing.Size(879, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.DataGridView gvdanhsach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmapd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView DataGridView1;
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
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongcol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaicol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadatcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhancol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn radiobutton;
        private System.Windows.Forms.DateTimePicker date_ngaythue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieucol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongcol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.ComboBox txt_songuoi;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDEL;
    }
}