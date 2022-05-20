
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormVatTu
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Thống kê", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã loại phòng:"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã vật tư:"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tên vật tư:"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số lượng:"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mavattu = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tenvattu = new System.Windows.Forms.TextBox();
            this.combo_maloaiphong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lsvKH = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên vật tư :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại phòng :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mavattu);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_tenvattu);
            this.groupBox1.Controls.Add(this.combo_maloaiphong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cơ sở vật chất :";
            // 
            // txt_mavattu
            // 
            this.txt_mavattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mavattu.Location = new System.Drawing.Point(177, 91);
            this.txt_mavattu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mavattu.Name = "txt_mavattu";
            this.txt_mavattu.Size = new System.Drawing.Size(224, 27);
            this.txt_mavattu.TabIndex = 10;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(177, 172);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(224, 27);
            this.txt_soluong.TabIndex = 9;
            // 
            // txt_tenvattu
            // 
            this.txt_tenvattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenvattu.Location = new System.Drawing.Point(177, 129);
            this.txt_tenvattu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenvattu.Name = "txt_tenvattu";
            this.txt_tenvattu.Size = new System.Drawing.Size(224, 27);
            this.txt_tenvattu.TabIndex = 8;
            // 
            // combo_maloaiphong
            // 
            this.combo_maloaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_maloaiphong.FormattingEnabled = true;
            this.combo_maloaiphong.Items.AddRange(new object[] {
            "L-Vip",
            "L-Normal",
            "L-Cheap"});
            this.combo_maloaiphong.Location = new System.Drawing.Point(177, 52);
            this.combo_maloaiphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_maloaiphong.Name = "combo_maloaiphong";
            this.combo_maloaiphong.Size = new System.Drawing.Size(224, 28);
            this.combo_maloaiphong.TabIndex = 6;
            this.combo_maloaiphong.Text = "L-Vip";
            this.combo_maloaiphong.SelectedIndexChanged += new System.EventHandler(this.combo_maloaiphong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã vật tư :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(463, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(563, 278);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lsvKH
            // 
            this.lsvKH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lsvKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader3});
            this.lsvKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvKH.FullRowSelect = true;
            this.lsvKH.GridLines = true;
            listViewGroup5.Header = "Thống kê";
            listViewGroup5.Name = "lsvgKH";
            this.lsvKH.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            this.lsvKH.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvKH.HideSelection = false;
            listViewItem17.Group = listViewGroup5;
            listViewItem18.Group = listViewGroup5;
            listViewItem19.Group = listViewGroup5;
            listViewItem20.Group = listViewGroup5;
            this.lsvKH.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.lsvKH.Location = new System.Drawing.Point(463, 55);
            this.lsvKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvKH.MultiSelect = false;
            this.lsvKH.Name = "lsvKH";
            this.lsvKH.Scrollable = false;
            this.lsvKH.Size = new System.Drawing.Size(561, 142);
            this.lsvKH.TabIndex = 64;
            this.lsvKH.UseCompatibleStateImageBehavior = false;
            this.lsvKH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thông tin";
            this.columnHeader6.Width = 188;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá trị";
            this.columnHeader3.Width = 313;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(21, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 68);
            this.label8.TabIndex = 68;
            this.label8.Text = "Quản lý cơ sở vật chất";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MintCream;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(332, 334);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 43);
            this.btn_Xoa.TabIndex = 69;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MintCream;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Sua.Location = new System.Drawing.Point(180, 334);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 43);
            this.btn_Sua.TabIndex = 70;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MintCream;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.Location = new System.Drawing.Point(28, 334);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 43);
            this.btn_Them.TabIndex = 71;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 74;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Tìm kiếm: ";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(147, 434);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(169, 22);
            this.txt_timkiem.TabIndex = 76;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1041, 513);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lsvKH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Sản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_tenvattu;
        private System.Windows.Forms.ComboBox combo_maloaiphong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView lsvKH;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_mavattu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}

