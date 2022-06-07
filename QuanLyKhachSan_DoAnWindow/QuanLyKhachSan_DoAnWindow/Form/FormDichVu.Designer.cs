
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_themdv = new System.Windows.Forms.Button();
            this.button_suadv = new System.Windows.Forms.Button();
            this.button_xoadv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tendichvu2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_donvi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_madichvu2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_timkiem2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_timkiem2);
            this.tabPage2.Controls.Add(this.txt_madichvu2);
            this.tabPage2.Controls.Add(this.txt_donvi);
            this.tabPage2.Controls.Add(this.txt_gia);
            this.tabPage2.Controls.Add(this.txt_tendichvu2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã dịch vụ:";
            // 
            // txt_tendichvu2
            // 
            this.txt_tendichvu2.Location = new System.Drawing.Point(26, 93);
            this.txt_tendichvu2.Name = "txt_tendichvu2";
            this.txt_tendichvu2.Size = new System.Drawing.Size(167, 22);
            this.txt_tendichvu2.TabIndex = 38;
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
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(26, 137);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(167, 22);
            this.txt_gia.TabIndex = 40;
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
            // txt_donvi
            // 
            this.txt_donvi.Location = new System.Drawing.Point(23, 186);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(170, 22);
            this.txt_donvi.TabIndex = 42;
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
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txt_madichvu2
            // 
            this.txt_madichvu2.Location = new System.Drawing.Point(26, 47);
            this.txt_madichvu2.Name = "txt_madichvu2";
            this.txt_madichvu2.Size = new System.Drawing.Size(167, 22);
            this.txt_madichvu2.TabIndex = 45;
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
            // txt_timkiem2
            // 
            this.txt_timkiem2.Location = new System.Drawing.Point(91, 305);
            this.txt_timkiem2.Name = "txt_timkiem2";
            this.txt_timkiem2.Size = new System.Drawing.Size(121, 22);
            this.txt_timkiem2.TabIndex = 47;
            this.txt_timkiem2.TextChanged += new System.EventHandler(this.txt_timkiem2_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 393);
            this.tabControl1.TabIndex = 33;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_timkiem2;
        private System.Windows.Forms.TextBox txt_madichvu2;
        private System.Windows.Forms.TextBox txt_donvi;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_tendichvu2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_xoadv;
        private System.Windows.Forms.Button button_suadv;
        private System.Windows.Forms.Button button_themdv;
        private System.Windows.Forms.TabControl tabControl1;
    }
}