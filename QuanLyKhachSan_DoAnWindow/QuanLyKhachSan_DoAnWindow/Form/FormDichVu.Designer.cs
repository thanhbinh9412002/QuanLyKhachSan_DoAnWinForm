﻿
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormDichVu
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
            this.combo_maphieuthue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_themdvphong = new System.Windows.Forms.Button();
            this.button_suadvphong = new System.Windows.Forms.Button();
            this.button_xoadvphong = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_tendichvu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_madichvu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_timkiem2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_madichvu2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_donvi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tendichvu2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_xoadv = new System.Windows.Forms.Button();
            this.button_suadv = new System.Windows.Forms.Button();
            this.button_themdv = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_maphieuthue
            // 
            this.combo_maphieuthue.FormattingEnabled = true;
            this.combo_maphieuthue.Location = new System.Drawing.Point(6, 36);
            this.combo_maphieuthue.Name = "combo_maphieuthue";
            this.combo_maphieuthue.Size = new System.Drawing.Size(121, 24);
            this.combo_maphieuthue.TabIndex = 0;
            this.combo_maphieuthue.SelectedIndexChanged += new System.EventHandler(this.combo_maphieuthue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu thuê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phòng:";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(133, 36);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(121, 22);
            this.txt_date.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(133, 109);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(121, 22);
            this.txt_soluong.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 238);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_themdvphong
            // 
            this.button_themdvphong.Location = new System.Drawing.Point(276, 291);
            this.button_themdvphong.Name = "button_themdvphong";
            this.button_themdvphong.Size = new System.Drawing.Size(84, 46);
            this.button_themdvphong.TabIndex = 18;
            this.button_themdvphong.Text = "Thêm";
            this.button_themdvphong.UseVisualStyleBackColor = true;
            this.button_themdvphong.Click += new System.EventHandler(this.button_themdvphong_Click);
            // 
            // button_suadvphong
            // 
            this.button_suadvphong.Location = new System.Drawing.Point(599, 291);
            this.button_suadvphong.Name = "button_suadvphong";
            this.button_suadvphong.Size = new System.Drawing.Size(75, 46);
            this.button_suadvphong.TabIndex = 19;
            this.button_suadvphong.Text = "Sửa";
            this.button_suadvphong.UseVisualStyleBackColor = true;
            this.button_suadvphong.Click += new System.EventHandler(this.button_suadvphong_Click);
            // 
            // button_xoadvphong
            // 
            this.button_xoadvphong.Location = new System.Drawing.Point(894, 291);
            this.button_xoadvphong.Name = "button_xoadvphong";
            this.button_xoadvphong.Size = new System.Drawing.Size(75, 46);
            this.button_xoadvphong.TabIndex = 20;
            this.button_xoadvphong.Text = "Xoá";
            this.button_xoadvphong.UseVisualStyleBackColor = true;
            this.button_xoadvphong.Click += new System.EventHandler(this.button_xoadvphong_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 393);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_timkiem);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_maphong);
            this.tabPage1.Controls.Add(this.txt_tendichvu);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.combo_madichvu);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.combo_maphieuthue);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_date);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_soluong);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button_themdvphong);
            this.tabPage1.Controls.Add(this.button_suadvphong);
            this.tabPage1.Controls.Add(this.button_xoadvphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dịch vụ phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(81, 303);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(121, 22);
            this.txt_timkiem.TabIndex = 29;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tìm kiếm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bảng dịch vụ theo phòng hiện tại";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(6, 111);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(121, 22);
            this.txt_maphong.TabIndex = 26;
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.AutoSize = true;
            this.txt_tendichvu.Location = new System.Drawing.Point(133, 189);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.Size = new System.Drawing.Size(93, 16);
            this.txt_tendichvu.TabIndex = 25;
            this.txt_tendichvu.Text = "Dịch vụ A, B, C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tên dịch vụ:";
            // 
            // combo_madichvu
            // 
            this.combo_madichvu.FormattingEnabled = true;
            this.combo_madichvu.Location = new System.Drawing.Point(6, 186);
            this.combo_madichvu.Name = "combo_madichvu";
            this.combo_madichvu.Size = new System.Drawing.Size(121, 24);
            this.combo_madichvu.TabIndex = 21;
            this.combo_madichvu.SelectedIndexChanged += new System.EventHandler(this.combo_madichvu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã dịch vụ:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_timkiem2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_madichvu2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_donvi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_gia);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_tendichvu2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button_xoadv);
            this.tabPage2.Controls.Add(this.button_suadv);
            this.tabPage2.Controls.Add(this.button_themdv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem2
            // 
            this.txt_timkiem2.Location = new System.Drawing.Point(91, 305);
            this.txt_timkiem2.Name = "txt_timkiem2";
            this.txt_timkiem2.Size = new System.Drawing.Size(121, 22);
            this.txt_timkiem2.TabIndex = 47;
            this.txt_timkiem2.TextChanged += new System.EventHandler(this.txt_timkiem2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Tìm kiếm:";
            // 
            // txt_madichvu2
            // 
            this.txt_madichvu2.Location = new System.Drawing.Point(26, 47);
            this.txt_madichvu2.Name = "txt_madichvu2";
            this.txt_madichvu2.Size = new System.Drawing.Size(167, 22);
            this.txt_madichvu2.TabIndex = 45;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(211, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(789, 245);
            this.dataGridView2.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Đơn vị tính:";
            // 
            // txt_donvi
            // 
            this.txt_donvi.Location = new System.Drawing.Point(23, 186);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(170, 22);
            this.txt_donvi.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Giá:";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(26, 137);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(167, 22);
            this.txt_gia.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tên dịch vụ:";
            // 
            // txt_tendichvu2
            // 
            this.txt_tendichvu2.Location = new System.Drawing.Point(26, 93);
            this.txt_tendichvu2.Name = "txt_tendichvu2";
            this.txt_tendichvu2.Size = new System.Drawing.Size(167, 22);
            this.txt_tendichvu2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã dịch vụ:";
            // 
            // button_xoadv
            // 
            this.button_xoadv.Location = new System.Drawing.Point(879, 293);
            this.button_xoadv.Name = "button_xoadv";
            this.button_xoadv.Size = new System.Drawing.Size(75, 46);
            this.button_xoadv.TabIndex = 35;
            this.button_xoadv.Text = "Xoá";
            this.button_xoadv.UseVisualStyleBackColor = true;
            this.button_xoadv.Click += new System.EventHandler(this.button_xoadv_Click);
            // 
            // button_suadv
            // 
            this.button_suadv.Location = new System.Drawing.Point(585, 293);
            this.button_suadv.Name = "button_suadv";
            this.button_suadv.Size = new System.Drawing.Size(75, 46);
            this.button_suadv.TabIndex = 34;
            this.button_suadv.Text = "Sửa";
            this.button_suadv.UseVisualStyleBackColor = true;
            this.button_suadv.Click += new System.EventHandler(this.button_suadv_Click);
            // 
            // button_themdv
            // 
            this.button_themdv.Location = new System.Drawing.Point(264, 293);
            this.button_themdv.Name = "button_themdv";
            this.button_themdv.Size = new System.Drawing.Size(84, 46);
            this.button_themdv.TabIndex = 33;
            this.button_themdv.Text = "Thêm";
            this.button_themdv.UseVisualStyleBackColor = true;
            this.button_themdv.Click += new System.EventHandler(this.button_themdv_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "Bảng dịch vụ hiện tại";
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "FormDichVu";
            this.Text = "Chỉnh sửa dịch vụ";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_maphieuthue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_themdvphong;
        private System.Windows.Forms.Button button_suadvphong;
        private System.Windows.Forms.Button button_xoadvphong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_donvi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tendichvu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_xoadv;
        private System.Windows.Forms.Button button_suadv;
        private System.Windows.Forms.Button button_themdv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_madichvu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_tendichvu;
        private System.Windows.Forms.TextBox txt_madichvu2;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_timkiem2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}